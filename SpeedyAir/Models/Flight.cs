namespace SpeedyAir.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public FlightPoint Origin { get; set; }
        public FlightPoint Destination { get; set; }
        public int FreightCapacity { get; set; }
        public List<FlightSchedule> Schedules { get; set; }
    }
}
