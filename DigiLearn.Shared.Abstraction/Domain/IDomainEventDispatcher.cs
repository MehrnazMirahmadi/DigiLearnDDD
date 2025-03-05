namespace DigiLearn.Shared.Abstraction.Domain;

public interface IDomainEventDispatcher
{
    Task DispatchAsync<TEvent>(TEvent @event) where TEvent : class, IDomainEvent;
}
