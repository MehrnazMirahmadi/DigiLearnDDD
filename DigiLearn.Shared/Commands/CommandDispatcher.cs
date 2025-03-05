using DigiLearn.Shared.Abstraction.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace DigiLearn.Shared.Commands;

internal sealed class CommandDispatcher : ICommandDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public CommandDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    async Task ICommandDispatcher.DispatchAsync<TCommand>(TCommand command)
    {
        using var scope = _serviceProvider.CreateScope();

        var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();

        await handler.HandleAsync(command);
    }
}