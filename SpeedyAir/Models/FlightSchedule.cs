namespace SpeedyAir.Models
{
    public class FlightSchedule
    {
        public int ScheduleId { get; set; }
        public int FlightId { get; set; }
        public int DepartureDay { get; set; }
        public int ArrivalDay { get; set; }
        public List<FreightOrder> Orders { get; set; }
    }
}
