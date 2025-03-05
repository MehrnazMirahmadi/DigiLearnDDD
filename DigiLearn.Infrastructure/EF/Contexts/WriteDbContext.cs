using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.Entities.PaymentManagement;
using DigiLearn.Domain.Entities.UserManagement;
using DigiLearn.Domain.ValueObjects;
using DigiLearn.Infrastructure.EF.Configs.WriteConfigs;
using DigiLearn.Shared.Abstraction.Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace DigiLearn.Infrastructure.EF.Contexts;

public sealed class WriteDbContext : DbContext
{
    private readonly IDomainEventDispatcher _dispatcher;
    #region Course Management DbSets
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseCatalog> CourseCatalogs { get; set; }
    public DbSet<CourseAttendee> CourseAttendees { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    #endregion

    #region User Management DbSets
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    #endregion

    #region Payment Management DbSets
    public DbSet<Invoice> Invoices { get; set; }
    #endregion

    public WriteDbContext(DbContextOptions<WriteDbContext> options, IDomainEventDispatcher dispatcher) : base(options)
    {
        _dispatcher = dispatcher;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var configuration = new WriteConfiguration();

        #region Course Management Configurations
        modelBuilder.ApplyConfiguration<Course>(configuration);
        modelBuilder.ApplyConfiguration<CourseCatalog>(configuration);
        modelBuilder.ApplyConfiguration<CourseAttendee>(configuration);
        modelBuilder.ApplyConfiguration<Lesson>(configuration);
        modelBuilder.ApplyConfiguration<Instructor>(configuration);
        #endregion

        #region User Management Configurations
        modelBuilder.ApplyConfiguration<User>(configuration);
        modelBuilder.ApplyConfiguration<Role>(configuration);
        modelBuilder.ApplyConfiguration<UserRole>(configuration);
        #endregion

        #region Payment Management Configurations
        modelBuilder.ApplyConfiguration<Invoice>(configuration);
        #endregion
    }

    public override int SaveChanges()
    {
        var response = base.SaveChanges();
        DispatchDomainEvents().GetAwaiter().GetResult();
        return response;
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var response = await base.SaveChangesAsync(cancellationToken);
        await DispatchDomainEvents();
        return response;
    }

    private async Task DispatchDomainEvents()
    {
        var aggregateRoots = ChangeTracker.Entries<AggregateRoot<BaseId>>()
            .Select(entry => entry.Entity)
            .Where(aggregate => aggregate.Events.Any())
            .ToArray();

        foreach (var aggregate in aggregateRoots)
        {
            var events = aggregate.Events.ToArray();
            aggregate.ClearEvents();

            foreach (var @event in events)
            {
                await _dispatcher.DispatchAsync(@event);
            }
        }
    }
}

