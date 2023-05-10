using SpeedyAir.Abstractions;
using SpeedyAir.Abstractions.Repositories;
using SpeedyAir.Helpers;
using SpeedyAir.Models;
using SpeedyAir.Repositories;

namespace SpeedyAir.Commands
{
    public class GenerateIterneriesCommand : ICommand
    {
        private const string ORDERES_JSON_FILE_NAME = "orders";
        private const string MONTREAL_AIRPORT = "YUL";

        private readonly IFlightRepository _flightRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IFlightPointRepository _flightPointRepository;
        public GenerateIterneriesCommand(IFlightRepository flightRepository
            , IOrderRepository orderRepository
            , IFlightPointRepository flightPointRepository)
        {
            _flightRepository = flightRepository;
            _orderRepository = orderRepository;
            _flightPointRepository = flightPointRepository;
        }

        public string CommandKey => "C";
        public string CommandLine => "Load Orders and Generate flight itineraries";

        public string Execute()
        {
            var filedOrdersDictionary = JsonReader.ReadFromFile<Dictionary<string, OrderFileModel>>(ORDERES_JSON_FILE_NAME);

            LoadOrders(filedOrdersDictionary);

            List<FreightOrder> unscheduledOrders = _orderRepository.GetUnscheduledOrders();

            var assignedOrders = AssignOrders(unscheduledOrders);

            if (assignedOrders == null || !assignedOrders.Any())
                return Constants.NOT_FOUND;

            return assignedOrders.SerializeItineraries();
        }

        private List<FreightOrder> AssignOrders(List<FreightOrder> unscheduledOrders)
        {
            foreach (var unscheduledOrder in unscheduledOrders)
            {
                var firstVacantFlightSchedule = _flightRepository
                    .FindFirstVacantFlight(unscheduledOrder.Origin, unscheduledOrder.Destination);

                if (firstVacantFlightSchedule == null)
                    continue;

                _orderRepository.AssignToFlight(unscheduledOrder, firstVacantFlightSchedule);
            }

            return unscheduledOrders
                .Where(o => o.FlightSchedule != null)
                .ToList();
        }

        private void LoadOrders(Dictionary<string, OrderFileModel> ordersDictionary)
        {
            var montreal = _flightPointRepository.FindByAirportName(MONTREAL_AIRPORT);
            List<FreightOrder> orders = new();

            foreach (var orderFM in ordersDictionary)
            {
                if (_orderRepository.FindOrder(orderFM.Key) != null)
                    continue;

                orders.Add(new FreightOrder
                {
                    Destination = _flightPointRepository.FindByAirportName(orderFM.Value.Destination),
                    Origin = montreal,
                    OrderNo = orderFM.Key
                });
            }

            _orderRepository.AddOrders(orders);
        }
    }

}
