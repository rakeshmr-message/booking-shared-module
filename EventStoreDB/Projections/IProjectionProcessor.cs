using BuildingBlocks.EventStoreDB.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BuildingBlocks.EventStoreDB.Projections;

public interface IProjectionProcessor
{
    Task ProcessEventAsync<T>(StreamEvent<T> streamEvent, CancellationToken cancellationToken = default)
        where T : INotification;
}
