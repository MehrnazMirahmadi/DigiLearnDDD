using DigiLearn.Shared.Abstraction.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace DigiLearn.Shared.Domain;

public class DomainEventDispatcher : IDomainEventDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public DomainEventDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    async Task IDomainEventDispatcher.DispatchAsync<TEvent>(TEvent @event)
    {
        using var scope = _serviceProvider.CreateScope();

        var handler = scope.ServiceProvider.GetRequiredService<IDomainEventHandler<TEvent>>();

        await handler.HandleAsync(@event);
    }
}
