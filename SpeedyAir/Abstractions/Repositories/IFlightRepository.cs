using SpeedyAir.Models;

namespace SpeedyAir.Abstractions.Repositories
{
    public interface IFlightRepository
    {
        public FlightSchedule? FindFirstVacantFlight(FlightPoint originAirport, FlightPoint destinationAirport);
        public List<FlightSchedule> GetFlightSchedules();
        public List<FlightSchedule> GetLoadedFlightSchedules();
    }

}
