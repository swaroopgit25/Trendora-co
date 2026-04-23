using Ardalis.SharedKernel;

namespace Trendora.ApplicationCore.Entities.OrderAggregate.Events;
public class OrderCreatedEvent(Order order) : DomainEventBase
{
    public Order Order { get; init; } = order;
}

