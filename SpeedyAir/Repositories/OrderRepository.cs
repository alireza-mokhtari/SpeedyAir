using SpeedyAir.Abstractions;
using SpeedyAir.Abstractions.Repositories;
using SpeedyAir.Models;

namespace SpeedyAir.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IApplicationContext _context;
        public OrderRepository(IApplicationContext context)
        {
            _context = context;
        }

        public void AddOrders(List<FreightOrder> orders)
        {            
            _context.FreightOrders.AddRange(orders);
        }

        public void AssignToFlight(FreightOrder order, FlightSchedule flightSchedule)
        {
            flightSchedule.ScheduledOrders.Add(order);
            order.FlightSchedule = flightSchedule;
        }

        public FreightOrder? FindOrder(string orderNo)
        {
            return _context.FreightOrders
                .FirstOrDefault(o => o.OrderNo.Equals(orderNo, StringComparison.InvariantCultureIgnoreCase));
        }

        public List<FreightOrder> GetUnscheduledOrders()
        {
            return _context.FreightOrders
                .Where(fo => fo.FlightSchedule == null)
                .OrderBy(fo => fo.OrderNo)
                .ToList();
        }
    }
}
