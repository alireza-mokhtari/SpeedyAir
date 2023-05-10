namespace SpeedyAir.Models
{
    public class FlightSchedule
    {
        public FlightSchedule()
        {            
        }
        public int Id { get; set; }        
        public int DepartureDay { get; set; }        
        public Flight Flight { get; set; }
        public List<FreightOrder> ScheduledOrders { get; set; } = new List<FreightOrder>();

        public bool HasFreightVacancy()
        {
            return ScheduledOrders.Count < Flight.FreightCapacity;
        }

        public override string ToString()
        {
            return $"departure: {Flight.Origin.Airport}, arrival: {Flight.Destination.Airport}, day: {DepartureDay}";
        }        
    }
}
