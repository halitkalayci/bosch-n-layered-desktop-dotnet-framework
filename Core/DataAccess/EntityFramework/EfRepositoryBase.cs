using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TContext : DbContext,new()
        where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var entityToAdd = context.Entry(entity);
                entityToAdd.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var entityToDelete = context.Entry(entity);
                entityToDelete.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        // Get(i=>i.Id==5)
        // Get()
        // filter = optional
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using(TContext context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).FirstOrDefault();
            }
        }

        // GetAll(i=>i.Name == "X")
        // GetAll()
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                // TEntityleri al, filter null değilse uygula ve dön.
                var query = context.Set<TEntity>().AsQueryable();
                // ternacy operator
                return (filter != null ? query.Where(filter).ToList() : query.ToList());
            }
        }
        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var entityToUpdate = context.Entry(entity);
                entityToUpdate.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
