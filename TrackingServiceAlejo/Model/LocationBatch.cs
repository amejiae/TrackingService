using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingServiceAlejo.Model
{
    public class LocationBatch
    {
        public IEnumerable<Location> Locations { get; set; }
    }
}
