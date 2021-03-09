using Core.DataAccess.Abstract;
using Core.Model;
using Core.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class RepositoryEntityFramework<TEntity, TContext> : IRepository<TEntity>
        where TContext : DbContext, new()
        where TEntity : BaseEntity, new()
    {
        public void Delete(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Entry(entity).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Delete(GetById(id));
        }

        public void DeleteNoActive(TEntity entity)
        {
            using(TContext ctx=new TContext())
            {
                entity.IsActive = false;
                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public void DeleteNoActive(int id)
        {
            DeleteNoActive(GetById(id));
        }

        public TEntity Get(Func<TEntity, bool> filter,params string[] includeList)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> dbSet = ctx.Set<TEntity>();

                if (includeList.Length > 0)
                {
                    for (int i = 0; i < includeList.Length; i++)
                    {
                        dbSet = dbSet.Include(includeList[i]);
                    }
                }

                return dbSet.SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(
            Func<TEntity, bool> filter = null,
            Func<TEntity,string> orderBy=null,
            Direction direction = Direction.Ascending,
            int? top = null,
            params string[] includeList)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> dbSet = ctx.Set<TEntity>();

                if (includeList.Length > 0)
                {
                    for (int i = 0; i < includeList.Length; i++)
                    {
                        dbSet = dbSet.Include(includeList[i]);
                    }
                }


                if (filter != null)
                    dbSet = dbSet.Where(filter).AsQueryable();

                if (orderBy != null)
                {
                    if (direction == Direction.Ascending)
                        dbSet = dbSet.OrderBy(orderBy).AsQueryable();
                    else
                        dbSet = dbSet.OrderByDescending(orderBy).AsQueryable();
                }

               
               return top != null 
                          ? dbSet.Take(top.Value).ToList() 
                          : dbSet.ToList();
               
            }
        }

        public TEntity GetById(int id, params string[] includeList)
        {
            return Get(x => x.Id == id,includeList);
        }

     

        public void Insert(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                entity.Created = DateTime.Now;
                entity.Modified = DateTime.Now;

                ctx.Entry(entity).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                entity.Modified = DateTime.Now;

                ctx.Entry(entity).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
