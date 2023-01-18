using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetBank.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);
        Task<TEntity> AddAsync(TEntity obj, CancellationToken cancellation = default);
        Task<IEnumerable<TEntity>> AddAsync(IEnumerable<TEntity> list, CancellationToken cancellation = default);
        TEntity GetById(int id);
        IEnumerable<TEntity> Get();
        Task<List<TEntity>> GetAsync();
        TEntity Update(TEntity obj, TEntity detachedObj);
        Task<TEntity> UpdateAsync(TEntity obj, CancellationToken cancellation = default);
        void Remove(int id);
        Task RemoveAsync(int id);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
        
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
