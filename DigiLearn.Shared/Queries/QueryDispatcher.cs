﻿using DigiLearn.Shared.Abstraction.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace DigiLearn.Shared.Queries;

internal sealed class QueryDispatcher : IQueryDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public QueryDispatcher(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task<TResult> FetchAsync<TResult>(IQuery<TResult> query)
    {
        using var scope = _serviceProvider.CreateScope();

        var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));

        var handler = scope.ServiceProvider.GetRequiredService(handlerType);

        return await (Task<TResult>)handlerType.GetMethod(nameof(IQueryHandler<IQuery<TResult>, TResult>.HandleAsync))?
                 .Invoke(handler, new[] { query });
    }
}

