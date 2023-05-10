namespace SpeedyAir.Models
{
    public class FreightOrder
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public FlightPoint Origin { get; set; }
        public FlightPoint Destination { get; set; }

    }
}
