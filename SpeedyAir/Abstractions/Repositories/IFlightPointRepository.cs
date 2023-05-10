using SpeedyAir.Models;

namespace SpeedyAir.Abstractions.Repositories
{
    public interface IFlightPointRepository
    {
        public FlightPoint FindByAirportName(string airport);
    }

}
