using SpeedyAir.Abstractions;
using SpeedyAir.Models;

namespace SpeedyAir.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly IApplicationContext _context;
        public FlightRepository(IApplicationContext applicationContext)
        {
            _context = applicationContext;
        }   

        public List<Flight> GetFlights()
        {
            throw new NotImplementedException();
        }

        public List<FlightSchedule> GetFlightSchedules()
        {
            return _context.Flights
                .SelectMany(f => f.Schedules)
                .ToList();
        }

        public List<FlightSchedule> GetLoadedFlightSchedules()
        {
            throw new NotImplementedException();
        }
    }
}
