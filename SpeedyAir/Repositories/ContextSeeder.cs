using Microsoft.Extensions.DependencyInjection;
using SpeedyAir.Abstractions;
using SpeedyAir.Models;

namespace SpeedyAir.Repositories
{
    public static class ContextSeeder
    {
        public const int DEFAULT_PLANE_FREIGHT_CAPACITY = 2;
        public static void SeedContext(this ServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<IApplicationContext>();

            SeedFlightPoints(context);

            SeedFlights(context);

            SeedFlightSchedules(context);
        }

        private static void SeedFlightSchedules(IApplicationContext context)
        {
            foreach (var flight in context.Flights)
            {
                flight.Schedules.Add(new FlightSchedule
                {
                    DepartureDay = 1,
                    Flight = flight
                });

                flight.Schedules.Add(new FlightSchedule
                {
                    DepartureDay = 2,
                    Flight = flight
                });
            }
        }

        private static void SeedFlights(IApplicationContext context)
        {
            var YUL = context.FlightPoints.FirstOrDefault(p => p.Airport == "YUL") ?? new FlightPoint();
            context.Flights.Add(new Flight
            {
                Origin = YUL,
                Destination = context.FlightPoints.FirstOrDefault(p => p.Airport == "YYZ") ?? new FlightPoint(),
                FreightCapacity = DEFAULT_PLANE_FREIGHT_CAPACITY
            });

            context.Flights.Add(new Flight
            {
                Origin = YUL,
                Destination = context.FlightPoints.FirstOrDefault(p => p.Airport == "YYC") ?? new FlightPoint(),
                FreightCapacity = DEFAULT_PLANE_FREIGHT_CAPACITY
            });

            context.Flights.Add(new Flight
            {
                Origin = YUL,
                Destination = context.FlightPoints.FirstOrDefault(p => p.Airport == "YVR") ?? new FlightPoint(),
                FreightCapacity = DEFAULT_PLANE_FREIGHT_CAPACITY
            });
        }

        private static void SeedFlightPoints(IApplicationContext context)
        {
            context.FlightPoints.Add(new FlightPoint { Airport = "YUL", City = "Montreal" });
            context.FlightPoints.Add(new FlightPoint { Airport = "YYZ", City = "Toronto" });
            context.FlightPoints.Add(new FlightPoint { Airport = "YYC", City = "Calgary" });
            context.FlightPoints.Add(new FlightPoint { Airport = "YVR", City = "Vancouver" });
        }
    }
}
