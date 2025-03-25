using BuildingBlocks.Domain.Event;
using Microsoft.EntityFrameworkCore;

namespace BuildingBlocks.EFCore;

using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    IReadOnlyList<IDomainEvent> GetDomainEvents();
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    Task BeginTransactionAsync(CancellationToken cancellationToken = default);
    Task CommitTransactionAsync(CancellationToken cancellationToken = default);
    Task RollbackTransactionAsync(CancellationToken cancellationToken = default);
    IExecutionStrategy CreateExecutionStrategy();
    Task ExecuteTransactionalAsync(CancellationToken cancellationToken = default);
}
