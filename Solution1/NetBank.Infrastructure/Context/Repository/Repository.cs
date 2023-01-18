using Microsoft.EntityFrameworkCore;
using NetBank.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetBank.Infrastructure.Context.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Constructor
        protected internal DbContext DbContext;
        protected internal DbSet<TEntity> DbSet;

        public Repository(DbContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<TEntity>();
        }
        #endregion

        public virtual TEntity Add(TEntity obj)
        {
            var objreturn = DbSet.Add(obj);
            SaveChanges();
            return objreturn.Entity;
        }

        public virtual async Task<TEntity> AddAsync(TEntity obj, CancellationToken cancellation = default)
        {
            var objreturn = await DbSet.AddAsync(obj, cancellation);
            await SaveChangesAsync(cancellation);
            return objreturn.Entity;
        }

        public virtual async Task<IEnumerable<TEntity>> AddAsync(IEnumerable<TEntity> list, CancellationToken cancellation = default)
        {
            foreach (var obj in list)
            {
                await DbSet.AddAsync(obj, cancellation);
            }

            await SaveChangesAsync(cancellation);
            return list;
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return DbSet.ToList();
        }

        public virtual Task<List<TEntity>> GetAsync()
        {
            return DbSet.ToListAsync();
        }

        public virtual TEntity Update(TEntity obj, TEntity detachedObj)
        {
            var objreturn = DbSet.Update(obj);
            SaveChanges();
            return objreturn.Entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity obj, CancellationToken cancellation = default)
        {
            var result = DbSet.Update(obj);
            await SaveChangesAsync(cancellation);
            return result.Entity;
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

        public virtual async Task RemoveAsync(int id)
        {
            DbSet.Remove(await DbSet.FindAsync(id));
            await SaveChangesAsync();
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return DbContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellation = default)
        {
            return DbContext.SaveChangesAsync(cancellation);
        }


        public virtual async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
            => await DbSet.CountAsync(predicate, cancellationToken: cancellationToken);

        public virtual async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
            => await DbSet.AnyAsync(predicate, cancellationToken: cancellationToken);

        public void Dispose()
        {
            DbContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
