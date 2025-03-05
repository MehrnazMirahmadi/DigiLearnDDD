namespace DigiLearn.Shared.Abstraction.Domain;


public interface IDomainEventHandler<TEvent> where TEvent : class, IDomainEvent
{
    Task HandleAsync(TEvent @event);
}