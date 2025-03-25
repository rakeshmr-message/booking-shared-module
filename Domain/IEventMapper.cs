using BuildingBlocks.Domain.Event;
using System.Collections.Generic;

namespace BuildingBlocks.Domain;

public interface IEventMapper
{
    IIntegrationEvent Map(IDomainEvent @event);
    IEnumerable<IIntegrationEvent> MapAll(IEnumerable<IDomainEvent> events);
}
