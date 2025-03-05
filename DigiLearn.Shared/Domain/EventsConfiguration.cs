using DigiLearn.Shared.Abstraction.Domain;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DigiLearn.Shared.Domain;

public static class EventsConfiguration
{
    public static IServiceCollection AddEvents(this IServiceCollection services)
    {
        var assembly = Assembly.GetCallingAssembly();
        services.AddSingleton<IDomainEventDispatcher, DomainEventDispatcher>();
        services.Scan(s => s.FromAssemblies(assembly)
        .AddClasses(c => c.AssignableTo(typeof(IDomainEventHandler<>)))
        .AsImplementedInterfaces()
        .WithScopedLifetime());

        return services;
    }
}

