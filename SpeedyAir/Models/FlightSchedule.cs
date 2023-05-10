namespace SpeedyAir.Models
{
    public class FlightSchedule
    {
        public FlightSchedule()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }        
        public int DepartureDay { get; set; }        
        public Flight Flight { get; set; }
        public List<ScheduledOrder> ScheduledOrders { get; set; }

        public override string ToString()
        {
            return $"departure: {Flight.Origin.Airport}, arrival: {Flight.Destination.Airport}, day: {DepartureDay}";
        }
    }
}
