using DigiLearn.Application.DomainEvents;
using DigiLearn.Domain.DomainEvents;
using DigiLearn.Domain.Factories.CourseManagement;
using DigiLearn.Domain.Factories.UserManagement;
using DigiLearn.Shared.Abstraction.Domain;
using DigiLearn.Shared.Commands;
using DigiLearn.Shared.Domain;
using DigiLearn.Shared.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace DigiLearn.Application;

public static class Extensions
{
    public static IServiceCollection AddApplicationConfigurations(this IServiceCollection services)
    {
        services.AddSingleton<IUserFactory, UserFactory>();
        services.AddSingleton<ICourseFactory, CourseFactory>();

        services.AddScoped<IDomainEventHandler<NewCourseCreatedEvent>, NewCourseCreatedEventHandler>();
        services.AddScoped<IDomainEventHandler<UserRegisteredEvent>, UserRegisteredEventHandler>();

        services.AddEvents();
        services.AddCommands();
        services.AddQueries();

        return services;
    }
}

