using System.Collections.Generic;

namespace TrackingServiceAlejo
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
    }
}
