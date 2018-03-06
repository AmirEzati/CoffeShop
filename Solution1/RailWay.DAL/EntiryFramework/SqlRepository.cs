using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using RailWayCoffee.Models;

namespace RailWayCoffee.DAL.EntiryFramework
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity
    {
        private DbSet<T> _dbSet { get; set; }
        public SqlRepository(DatabaseContext databaseContext)
        {
            if (databaseContext==null)
            {
                throw new ArgumentNullException("DatabaseContext");
            }
            _dbSet = databaseContext.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public IQueryable<T> GetAll()
        {
            return
                _dbSet;
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return
                _dbSet.Where(predicate);
        }

        public T GetById(Guid id)
        {
            return
                _dbSet.SingleOrDefault(p=>p.Id==id);
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

              public void Update(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
