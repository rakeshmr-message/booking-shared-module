using BuildingBlocks.Domain.Event;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BuildingBlocks.Domain;

public interface IBusPublisher
{
    public Task SendAsync(IReadOnlyList<IDomainEvent> domainEvents, CancellationToken cancellationToken = default);
    public Task SendAsync(IDomainEvent domainEvent, CancellationToken cancellationToken = default);

    public Task SendAsync(IIntegrationEvent integrationEvent, CancellationToken cancellationToken = default);
    public Task SendAsync(IReadOnlyList<IIntegrationEvent> integrationEvents, CancellationToken cancellationToken = default);
}
