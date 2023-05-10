using SpeedyAir.Models;

namespace SpeedyAir.Abstractions
{
    public interface IFlightRepository
    {
        public List<Flight> GetFlights();
        public List<FlightSchedule> GetFlightSchedules();
        public List<FlightSchedule> GetLoadedFlightSchedules();
    }
}
