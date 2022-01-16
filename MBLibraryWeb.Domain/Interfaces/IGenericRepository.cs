using MBLibraryWeb.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MBLibraryWeb.Domain.Interfaces
{
    public interface IGenericRepository<TModelUI> where TModelUI : class
    {
        TModelUI GetById(int id);
        IEnumerable<TModelUI> GetAll();
        //IEnumerable<TModelUI> GetAllUsingExpression(Expression<Func<TModelUI, TModelUI>> expression);
        //IEnumerable<TModelUI> Find(Expression<Func<TModelUI, bool>> expression);
        void Add(TModelUI entity);
        void AddRange(IEnumerable<TModelUI> entities);
        void Update(TModelUI entity);
        void Remove(int id);
        void RemoveRange(IEnumerable<TModelUI> entities);
    }
}
