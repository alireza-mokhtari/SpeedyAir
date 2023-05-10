using SpeedyAir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAir.Abstractions
{
    public interface IApplicationContext
    {
        public List<Flight> Flights { get; set; }
        public List<FreightOrder> FreightOrders { get; set; }
        public List<FlightPoint> FlightPoints { get; set; }

    }
}
