using MBLibraryWeb.Domain.Entities.Base;
using MBLibraryWeb.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MBLibraryWeb.DB.Repositories
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> 
        where TEntity : BaseOb
    {
        protected readonly MBLibraryDbContext context;
        public GenericRepository(MBLibraryDbContext context)
        {
            this.context = context;
        }
        public virtual void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().AsNoTracking().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public virtual void Remove(int id)
        {
            TEntity entity = context.Set<TEntity>().Find(id);
            context.Set<TEntity>().Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().RemoveRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
        }
    }
}
