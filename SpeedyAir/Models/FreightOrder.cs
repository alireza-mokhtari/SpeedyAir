namespace SpeedyAir.Models
{
    public class FreightOrder
    {
        public string OrderNo { get; set; }
        public FlightPoint Origin { get; set; }
        public FlightPoint Destination { get; set; }
        public FlightSchedule FlightSchedule { get; set; }

        public override string ToString()
        {
            return $"order: {OrderNo}, flightNumber: {FlightSchedule.Id}, departure: {Origin.City}, arrival: {Destination.City}, day: {FlightSchedule.DepartureDay}";
        }
    }
}
