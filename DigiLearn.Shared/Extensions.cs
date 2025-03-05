using DigiLearn.Shared.Commands;
using DigiLearn.Shared.Domain;
using DigiLearn.Shared.Exceptions;
using DigiLearn.Shared.Queries;
using DigiLearn.Shared.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DigiLearn.Shared;

public static class Extensions
{
    public static IServiceCollection ConfigureSharedServices(this IServiceCollection services)
    {
        services.AddHostedService<AppIntializer>();
        services.AddCommands();
        services.AddQueries();
        services.AddEvents();
        services.AddScoped<ExceptionMiddleware>();
        return services;
    }

    public static IApplicationBuilder UseShared(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
        return app;
    }
}
