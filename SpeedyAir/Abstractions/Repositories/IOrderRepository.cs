using SpeedyAir.Models;

namespace SpeedyAir.Abstractions.Repositories
{
    public interface IOrderRepository
    {
        public FreightOrder? FindOrder(string orderNo);
        public void AddOrders(List<FreightOrder> orders);
        public List<FreightOrder> GetUnscheduledOrders();
        public void AssignToFlight(FreightOrder order, FlightSchedule flightSchedule);
    }
}
