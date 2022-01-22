using MBLibraryWeb.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseOb
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Remove(int id);
        void RemoveRange(IEnumerable<TEntity> entities);
    }

}
