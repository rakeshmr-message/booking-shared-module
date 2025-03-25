using BuildingBlocks.EventStoreDB.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BuildingBlocks.EventStoreDB.Projections;

public interface IProjectionPublisher
{
    Task PublishAsync<T>(StreamEvent<T> streamEvent, CancellationToken cancellationToken = default)
        where T : INotification;

    Task PublishAsync(StreamEvent streamEvent, CancellationToken cancellationToken = default);
}
