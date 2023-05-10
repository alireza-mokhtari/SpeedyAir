using SpeedyAir.Models;

namespace SpeedyAir.Abstractions
{
    public interface IApplicationContext
    {
        public List<Flight> Flights { get; set; }
        public List<FlightSchedule> FlightSchedules { get; set; }
        public List<FreightOrder> FreightOrders { get; set; }
        public List<FlightPoint> FlightPoints { get; set; }
    }
}
