using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingServiceAlejo
{
    public class Tracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TrackingId { get; set; }

        public string Content { get; set; }

        public string DeviceId { get; set; }

        public double Longitude { get; set; }

        public double Lattitude { get; set; }
    }
}
