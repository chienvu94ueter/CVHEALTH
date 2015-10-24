using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using CV.Entity;

namespace CV.Data
{
    public class Repository<T> where T : class
    {
        internal CVDbContext Context;
        internal DbSet<T> DbSet;

        public Repository(CVDbContext context)
        {
            Context = context;
            DbSet = Context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable();
        }

        public virtual IEnumerable<T> FindAll(Expression<Func<T, bool>> expression)
        {
            return DbSet.Where(expression);
        }
        public virtual bool Contains(Expression<Func<T, bool>> expression)
        {
            return DbSet.Count(expression) > 0;
        }

        public virtual T Find(Expression<Func<T, bool>> expression)
        {
            return DbSet.FirstOrDefault(expression);
        }

        public virtual T Add(T entity)
        {
            try
            {
                DbSet.Add(entity);
                Context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public virtual bool Delete(T entity)
        {
            try
            {
                var entry = Context.Entry(entity);
                entry.State = EntityState.Deleted;
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public virtual T Update(T entity)
        {
            try
            {
                var entry = Context.Entry(entity);
                DbSet.Attach(entity);
                entry.State = EntityState.Modified;
                Context.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public virtual int Count(Expression<Func<T, bool>> expression)
        {
            return DbSet.Count(expression);
        }

    }
}
