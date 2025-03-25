using System;
using System.Threading;
using System.Threading.Tasks;

namespace BuildingBlocks.Mongo;

public interface IUnitOfWork : IDisposable
{
    System.Threading.Tasks.Task BeginTransactionAsync(CancellationToken cancellationToken = default);
    Task CommitAsync(CancellationToken cancellationToken = default);
}

public interface IUnitOfWork<out TContext> : IUnitOfWork
    where TContext : class
{
    TContext Context { get; }
}
