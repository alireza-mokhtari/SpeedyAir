using SpeedyAir.Abstractions;
using SpeedyAir.Abstractions.Repositories;
using SpeedyAir.Models;

namespace SpeedyAir.Repositories
{
    public class FlightPointRepository : IFlightPointRepository
    {
        private readonly IApplicationContext _context;
        public FlightPointRepository(IApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public FlightPoint? FindByAirportName(string airport)
        {
            return _context.FlightPoints.FirstOrDefault(fp => fp.Airport.Equals(airport, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
