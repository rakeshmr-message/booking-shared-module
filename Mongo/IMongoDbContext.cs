using MongoDB.Driver;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BuildingBlocks.Mongo;

public interface IMongoDbContext : IDisposable
{
    IMongoCollection<T> GetCollection<T>(string? name = null);
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    Task BeginTransactionAsync(CancellationToken cancellationToken = default);
    Task CommitTransactionAsync(CancellationToken cancellationToken = default);
    Task RollbackTransaction(CancellationToken cancellationToken = default);
    void AddCommand(Func<Task> func);
}
