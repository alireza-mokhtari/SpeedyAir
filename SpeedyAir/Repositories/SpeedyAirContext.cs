using SpeedyAir.Abstractions;
using SpeedyAir.Models;

namespace SpeedyAir.Repositories
{
    public class SpeedyAirContext : IApplicationContext
    {
        public List<Flight> Flights { get; set; } = new List<Flight>(); 
        public List<FreightOrder> FreightOrders { get; set; } = new List<FreightOrder>();
        public List<FlightPoint> FlightPoints { get; set; } = new List<FlightPoint>();
    }
}
