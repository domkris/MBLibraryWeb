using MBLibraryWeb.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllUsingExpression(Expression<Func<T, T>> expression);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity, params Expression<Func<T, object>>[] navigations);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
