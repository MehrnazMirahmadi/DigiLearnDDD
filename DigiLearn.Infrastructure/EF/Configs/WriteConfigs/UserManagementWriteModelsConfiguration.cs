using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.Entities.UserManagement;
using DigiLearn.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;

namespace DigiLearn.Infrastructure.EF.Configs.WriteConfigs;

internal sealed partial class WriteConfiguration : IEntityTypeConfiguration<User>, IEntityTypeConfiguration<Role>,
    IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        var userNameConverter = new ValueConverter<Username, string>(un => un.Value, un => new Username(un));
        var passwordConverter = new ValueConverter<Password, string>(p => p.Value, p => new Password(p));
        var emailConverter = new ValueConverter<Email, string>(e => e.Value, e => new Email(e));

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id)
            .HasConversion(idConverter);

        builder.Property(typeof(Username), "_userName")
        .HasConversion(userNameConverter)
        .HasColumnName("Username")
        .IsRequired();

        builder.Property(typeof(Password), "_password")
        .HasConversion(passwordConverter)
        .HasColumnName("Password")
        .IsRequired();

        builder.Property(typeof(Email), "_email")
        .HasConversion(emailConverter)
        .HasColumnName("Email")
        .IsRequired();

        builder.Property(typeof(bool), "_isConfirmed")
        .HasColumnName("IsConfirmed");

        builder.HasMany(typeof(CourseAttendee), "_courseAttendees")
            .WithOne()
            .HasForeignKey("_userId");

        builder.HasMany(typeof(UserRole), "_userRoles")
            .WithOne()
            .HasForeignKey("_userId");

        builder.ToTable("Users");
    }

    public void Configure(EntityTypeBuilder<Role> builder)
    {
        var roleNameConverter = new ValueConverter<RoleName, string>(rn => rn.Value, rn => new RoleName(rn));

        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id)
            .HasConversion(idConverter);

        builder.Property(typeof(RoleName), "_roleName")
        .HasConversion(roleNameConverter)
        .HasColumnName("RoleName")
        .IsRequired();

        builder.HasMany(typeof(UserRole), "_userRoles")
        .WithOne()
        .HasForeignKey("_roleId");

        builder.ToTable("Roles");
    }

    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.Property(typeof(BaseId), "_userId")
        .HasConversion(idConverter)
        .HasColumnName("UserId")
        .IsRequired();

        builder.Property(typeof(BaseId), "_roleId")
            .HasConversion(idConverter)
            .HasColumnName("RoleId")
            .IsRequired();

        builder.HasKey("_userId", "_roleId");

        builder.HasOne<User>()
            .WithMany("_userRoles")
            .HasForeignKey("_userId");

        builder.HasOne<Role>()
            .WithMany("_userRoles")
            .HasForeignKey("_roleId");

        builder.ToTable("UserRoles");
    }
}
