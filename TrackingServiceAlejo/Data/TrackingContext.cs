using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackingServiceAlejo.Model;

namespace TrackingServiceAlejo
{
    public class TrackingContext : DbContext
    {
        public TrackingContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Tracking> Trackings { get; set; }
    }
}
