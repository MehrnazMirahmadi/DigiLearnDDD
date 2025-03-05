using DigiLearn.Application.Models.CourseManagement;
using DigiLearn.Application.Models.PaymentManagement;
using DigiLearn.Application.Models.UserManagement;
using DigiLearn.Infrastructure.EF.Configs.ReadConfigs;
using Microsoft.EntityFrameworkCore;

namespace DigiLearn.Infrastructure.EF.Contexts;
public sealed class ReadDbContext : DbContext
{
    #region Course Management DbSets
    public DbSet<CourseReadModel> Courses { get; set; }
    public DbSet<CourseCatalogReadModel> CourseCatalogs { get; set; }
    public DbSet<CourseAttendeReadModel> CourseAttendees { get; set; }
    public DbSet<LessonReadModel> Lessons { get; set; }
    public DbSet<InstructorReadModel> Instructors { get; set; }
    #endregion

    #region User Management DbSets
    public DbSet<UserReadModel> Users { get; set; }
    public DbSet<RoleReadModel> Roles { get; set; }
    public DbSet<UserRoleReadModel> UserRoles { get; set; }
    #endregion

    #region Payment Management DbSets
    public DbSet<InvoiceReadModel> Invoices { get; set; }
    #endregion

    public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var configuration = new ReadConfiguration();

        #region Course Management Configurations
        modelBuilder.ApplyConfiguration<CourseReadModel>(configuration);
        modelBuilder.ApplyConfiguration<CourseCatalogReadModel>(configuration);
        modelBuilder.ApplyConfiguration<CourseAttendeReadModel>(configuration);
        modelBuilder.ApplyConfiguration<LessonReadModel>(configuration);
        modelBuilder.ApplyConfiguration<InstructorReadModel>(configuration);
        #endregion

        #region User Management Configurations
        modelBuilder.ApplyConfiguration<UserReadModel>(configuration);
        modelBuilder.ApplyConfiguration<RoleReadModel>(configuration);
        modelBuilder.ApplyConfiguration<UserRoleReadModel>(configuration);
        #endregion

        #region Payment Management Configurations
        modelBuilder.ApplyConfiguration<InvoiceReadModel>(configuration);
        #endregion

    }
}
