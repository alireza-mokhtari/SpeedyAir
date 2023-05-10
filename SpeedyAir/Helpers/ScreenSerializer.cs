using SpeedyAir.Models;
using System.Text;

namespace SpeedyAir.Helpers
{
    public static class ScreenSerializer
    {
        public static string SerializeFlightScheduleCollection(this List<FlightSchedule> schedules)
        {
            StringBuilder responseBuilder = new();

            for (int i = 0; i < schedules.Count; i++)
                responseBuilder.AppendLine($"Flight {i + 1}, {schedules[i].ToString()}");

            return responseBuilder.ToString();
        }

        public static string SerializeItineraries(this List<FreightOrder> orders)
        {
            StringBuilder responseBuilder = new();

            foreach(FreightOrder order in orders)
                responseBuilder.AppendLine(order.ToString());

            return responseBuilder.ToString();
        }
    }
}
