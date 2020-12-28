using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackingServiceAlejo
{
    public class TrackingManager : IDataRepository<Tracking>
    {
        readonly TrackingContext _trackingContext;

        public TrackingManager(TrackingContext context)
        {
            _trackingContext = context;
        }

        public IEnumerable<Tracking> GetAll()
        {
            return _trackingContext.Trackings.ToList();
        }

        public Tracking Get(long id)
        {
            return _trackingContext.Trackings.FirstOrDefault(e => e.TrackingId == id);
        }

        public void Add(Tracking entity)
        {
            _trackingContext.Trackings.Add(entity);
            _trackingContext.SaveChanges();
        }

        public void AddRange(IEnumerable<Tracking> entities)
        {
            _trackingContext.Trackings.AddRange(entities);
            _trackingContext.SaveChanges();
        }
    }
}
