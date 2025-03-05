using DigiLearn.Shared.Abstraction.Queries;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DigiLearn.Shared.Queries;

public static class QueriesConfiguration
{
    public static IServiceCollection AddQueries(this IServiceCollection services)
    {
        var assembly = Assembly.GetCallingAssembly();
        services.AddSingleton<IQueryDispatcher, QueryDispatcher>();
        services.Scan(s => s.FromAssemblies(assembly)
        .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
        .AsImplementedInterfaces()
        .WithScopedLifetime());

        return services;
    }
}

