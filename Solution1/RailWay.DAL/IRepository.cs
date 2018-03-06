using RailWayCoffee.Models;
using System;
using System.Linq;

namespace RailWayCoffee.DAL
{
    public interface IRepository<T> where T : class, IEntity
    {
        T GetById(Guid id);
        IQueryable<T> GetAll();
        IQueryable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
