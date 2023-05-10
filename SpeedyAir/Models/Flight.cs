namespace SpeedyAir.Models
{
    public class Flight
    {
        public Flight()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public FlightPoint Origin { get; set; }
        public FlightPoint Destination { get; set; }
        public int FreightCapacity { get; set; }
        public List<FlightSchedule> Schedules { get; set; } = new List<FlightSchedule>(); 
    }
}
