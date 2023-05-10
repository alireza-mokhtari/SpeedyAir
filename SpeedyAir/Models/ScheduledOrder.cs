namespace SpeedyAir.Models
{
    public class ScheduledOrder
    {
        public Guid FlightScheduleId { get; set; }
        public int FreightOrderId { get; set; }
        public FreightOrder FreightOrder { get; set; }
        public FlightSchedule FlightSchedule { get; set; }
    }
}
