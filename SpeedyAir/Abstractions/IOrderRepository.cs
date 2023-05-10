using SpeedyAir.Models;

namespace SpeedyAir.Abstractions
{
    public interface IOrderRepository
    {
        public List<FreightOrder> GetFreightOrders();
        public void AssignToFlight(FlightSchedule flightSchedule);
    }
}
