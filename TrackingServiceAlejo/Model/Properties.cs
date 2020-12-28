using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingServiceAlejo
{
    public class Properties
    {
        public DateTime timestamp { get; set; }
        public int altitude { get; set; }
        public int speed { get; set; }
        public int horizontal_accuracy { get; set; }
        public int vertical_accuracy { get; set; }
        public List<string> motion { get; set; }
        public bool pauses { get; set; }
        public string activity { get; set; }
        public int desired_accuracy { get; set; }
        public int deferred { get; set; }
        public string significant_change { get; set; }
        public int locations_in_payload { get; set; }
        public string battery_state { get; set; }
        public double battery_level { get; set; }
        public string device_id { get; set; }
        public string wifi { get; set; }
    }
}
