namespace SpeedyAir.Models
{
    public class FlightPoint : IEquatable<FlightPoint>
    {
        public string Airport { get; set; }
        public string City { get; set; }

        public bool Equals(FlightPoint? other)
        {
            if (other == null)
                return false;

            return Airport.Equals(other.Airport, StringComparison.InvariantCultureIgnoreCase) 
                && City.Equals(other.City, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
