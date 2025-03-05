using DigiLearn.Application.Services;
using DigiLearn.Domain.Repositories.CourseManagement;
using DigiLearn.Domain.Repositories.UserManagement;
using DigiLearn.Infrastructure.EF.Contexts;
using DigiLearn.Infrastructure.EF.Options;
using DigiLearn.Infrastructure.EF.Repositories;
using DigiLearn.Infrastructure.EF.Services;
using DigiLearn.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DigiLearn.Infrastructure.EF;

public static class Extensions
{
    public static IServiceCollection AddEFConfigurations(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<IUserReadModelService, UserReadModelService>();
        services.AddScoped<ICourseReadModelService, CourseReadModelService>();

        var options = configuration.GetOptions<DataBaseOptions>("DigiLearnDbContextConnectionString");

        services.AddDbContext<ReadDbContext>(ct => ct.UseSqlServer(options.ConnectionString));
        services.AddDbContext<WriteDbContext>(ct => ct.UseSqlServer(options.ConnectionString));
        return services;

    }
}
