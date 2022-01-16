using MBLibraryWeb.Domain.Interfaces;
using MBLibraryWeb.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBLibraryWeb.DB.Repositories
{
    public abstract class GenericRepository<TModelDb, TModelUI> : IGenericRepository<TModelUI> 
        where TModelDb : class
        where TModelUI : class
    {
        protected readonly MBLibraryDbContext context;
        public GenericRepository(MBLibraryDbContext context)
        {
            this.context = context;
        }
        public virtual void Add(TModelUI entityUI)
        {
            context.Set<TModelDb>().Add(ToDbModel(entityUI));
        }

        public virtual void AddRange(IEnumerable<TModelUI> entitiesUI)
        {
            context.Set<TModelDb>().AddRange(ToDbModelList(entitiesUI));
        }

        public virtual IEnumerable<TModelUI> GetAll()
        {
            var result = context.Set<TModelDb>().AsNoTracking().ToList();
            return ToUIModelList(result);
        }

        public virtual TModelUI GetById(int id)
        {
            TModelDb entityDb = context.Set<TModelDb>().Find(id);
            return ToUIModel(entityDb);
        }

        public virtual void Remove(int id)
        {
            TModelDb entityDb = context.Set<TModelDb>().Find(id);
            context.Set<TModelDb>().Remove(entityDb);
        }

        public virtual void RemoveRange(IEnumerable<TModelUI> entitiesUI)
        {
            IEnumerable<TModelDb> entitiesDb = ToDbModelList(entitiesUI);
            context.Set<TModelDb>().RemoveRange(entitiesDb);
        }

        public virtual void Update(TModelUI entityUI)
        {
            TModelDb entityDb = ToDbModel(entityUI);
            EntityEntry dbEntityEntry = context.Entry<TModelDb>(entityDb);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                context.Set<TModelDb>().Attach(entityDb);

                dbEntityEntry.State = EntityState.Modified;
            }
        }

        protected abstract TModelDb ToDbModel(TModelUI modelUI);
        protected abstract TModelUI ToUIModel(TModelDb modelDb);
        protected abstract IEnumerable<TModelDb> ToDbModelList(IEnumerable<TModelUI> modelUI);
        protected abstract IEnumerable<TModelUI> ToUIModelList(IEnumerable<TModelDb> modelDb);
    }
}
