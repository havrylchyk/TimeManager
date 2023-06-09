using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TimeManager.Core.Context;
using TimeManager.Core.Entity;

namespace TimeManager.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : BaseEntity
    {
        protected TimeManagerContext ctx;

        public Repository(TimeManagerContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(TEntity entity)
        {
            ctx.Set<TEntity>().Add(entity);
            Save();
        }

        public void Delete(TEntity entity)
        {
            ctx.Set<TEntity>().Remove(entity);
            Save();
        }

        public TEntity Get(TKey key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public IEnumerable<TEntity> GetAll() => ctx.Set<TEntity>().ToList();

        public void Save()
        {
            ctx.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            ctx.Set<TEntity>().Update(entity);
            Save();
        }

        public Guid GetIdByName(string name)
        {
            var entityParameter = Expression.Parameter(typeof(TEntity), "entity");
            var nameProperty = Expression.Property(entityParameter, "Name");
            var nameEquals = Expression.Equal(nameProperty, Expression.Constant(name));
            var lambda = Expression.Lambda<Func<TEntity, bool>>(nameEquals, entityParameter);
            var entity = ctx.Set<TEntity>().FirstOrDefault(lambda);
            return entity != null ? entity.Id : default(Guid);
        }

    }
}
