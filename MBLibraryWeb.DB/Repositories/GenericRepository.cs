using MBLibraryWeb.Domain.Interfaces;
using MBLibraryWeb.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.DB.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly MBLibraryDbContext context;
        public GenericRepository(MBLibraryDbContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().AsNoTracking().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            var result = context.Set<T>().AsNoTracking().ToList();
            return result;
        }

        public IEnumerable<T> GetAllUsingExpression(Expression<Func<T, T>> expression)
        {
            return context.Set<T>().AsNoTracking().Select(expression).ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity, params Expression<Func<T, object>>[] navigations)
        {
            
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
