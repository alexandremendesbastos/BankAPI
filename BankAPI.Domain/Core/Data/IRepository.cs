using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BankAPI.Domain.Core.Data
{
    public interface IRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        TEntity GetById(TKey id);
        Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        IQueryable<TEntity> GetAll();
        IUnitOfWork UnitOfWork { get; }
    }
}
