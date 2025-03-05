using DigiLearn.Application.Services;
using DigiLearn.Infrastructure.EF;
using DigiLearn.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DigiLearn.Infrastructure;

public static class Extensions
{
    public static IServiceCollection ConfigureInfraServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddEFConfigurations(configuration);
        services.AddSingleton<IEmailService, EmailService>();

        return services;
    }
}

