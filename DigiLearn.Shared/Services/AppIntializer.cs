﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DigiLearn.Shared.Services;

internal sealed class AppIntializer : IHostedService
{
    private readonly IServiceProvider _serviceProvider;

    public AppIntializer(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        var dbContextTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes()
            .Where(a => typeof(DbContext).IsAssignableFrom(a) && !a.IsInterface && a != typeof(DbContext)));

        using var scope = _serviceProvider.CreateScope();

        foreach (var dbContextType in dbContextTypes)
        {
            var dbContext = scope.ServiceProvider.GetRequiredService(dbContextType) as DbContext;
            if (dbContext is null)
                continue;
            await dbContext.Database.EnsureCreatedAsync(cancellationToken);
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
