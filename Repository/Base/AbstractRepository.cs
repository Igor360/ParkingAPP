using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexts;
using WebApplication1.Models;

namespace WebApplication1.Repository.Base
{
    public abstract class AbstractRepository<T> : IRepository<T> where T : Model
    {
        private DbContext DbContext;

        protected AbstractRepository(ParkingContext baseContext)
        {
            this.DbContext = baseContext;
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }

        public IQueryable<T> All()
        {
            return DbContext.Set<T>().AsNoTracking();
        }

        public T Get(int id)
        {
            return DbContext.Find<T>(id);
        }

        public void Update(T model)
        {
            DbContext.Update(model);
            this.Save();
        }

        public void Create(T model)
        {
            DbContext.Add(model);
            this.Save();
        }

        public void Delete(int id)
        {
            T entity = DbContext.Find<T>(id);
            if (entity != null)
            {
                DbContext.Remove(entity);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}