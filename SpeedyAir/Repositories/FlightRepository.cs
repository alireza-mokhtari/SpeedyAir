using SpeedyAir.Abstractions;
using SpeedyAir.Abstractions.Repositories;
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

        public FlightSchedule? FindFirstVacantFlight(FlightPoint origin, FlightPoint destination)
        {
            return _context.FlightSchedules
                .FirstOrDefault(fs => fs.Flight.Origin.Equals(origin)
                    && fs.Flight.Destination.Equals(destination)
                    && fs.HasFreightVacancy());
        }

        public List<FlightSchedule> GetFlightSchedules()
        {
            return _context.FlightSchedules                
                .ToList();
        }

        public List<FlightSchedule> GetLoadedFlightSchedules()
        {
            return _context.FlightSchedules                
                .Where(sc => sc.ScheduledOrders.Any())
                .ToList();
        }
    }
}
