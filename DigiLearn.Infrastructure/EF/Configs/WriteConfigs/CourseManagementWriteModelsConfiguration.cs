using DigiLearn.Domain.Entities.CourseManagement;
using DigiLearn.Domain.Entities.UserManagement;
using DigiLearn.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DigiLearn.Infrastructure.EF.Configs.WriteConfigs;

internal sealed partial class WriteConfiguration : IEntityTypeConfiguration<Course>, IEntityTypeConfiguration<CourseCatalog>,
    IEntityTypeConfiguration<CourseAttendee>, IEntityTypeConfiguration<Lesson>, IEntityTypeConfiguration<Instructor>
{
    private ValueConverter idConverter = new ValueConverter<BaseId, Guid>(id => id.Value, id => new BaseId(id));
    private ValueConverter titleConverter = new ValueConverter<Title, string>(t => t.Value, t => new Title(t));
    private ValueConverter descriptionConverter = new ValueConverter<Description, string>(dsc => dsc.Value, dsc => new Description(dsc));

    public void Configure(EntityTypeBuilder<Course> builder)
    {
        var priceConverter = new ValueConverter<Price, decimal>(pr => pr.Value, pr => new Price(pr));

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
            .HasConversion(idConverter);

        builder.Property(typeof(Title), "_title")
                .HasConversion(titleConverter)
                .HasColumnName("Title")
                .IsRequired();

        builder.Property(typeof(Description), "_description")
                .HasConversion(descriptionConverter)
                .HasColumnName("Description")
                .IsRequired();

        builder.Property(typeof(bool), "_isFree")
                .HasColumnName("IsFree");

        builder.Property(typeof(Price), "_price")
        .HasConversion(priceConverter)
        .HasColumnName("Price")
        .IsRequired();

        builder.Property(typeof(BaseId), "_instructorId")
            .HasConversion(idConverter)
            .HasColumnName("InstructorId");

        builder.HasOne<Instructor>()
            .WithMany()
            .HasForeignKey("_instructorId")
            .IsRequired();

        builder.HasMany(typeof(CourseAttendee), "_courseAttendees")
            .WithOne()
            .HasForeignKey("_userId");

        builder.ToTable("Courses");
    }

    public void Configure(EntityTypeBuilder<CourseCatalog> builder)
    {
        builder.HasKey(cc => cc.Id);
        builder.Property(cc => cc.Id)
            .HasConversion(idConverter);

        builder.Property(typeof(Title), "_title")
        .HasConversion(titleConverter)
        .HasColumnName("Title")
        .IsRequired();

        builder.Property(typeof(Description), "_description")
                .HasConversion(descriptionConverter)
                .HasColumnName("Description")
                .IsRequired();

        builder.Property(typeof(BaseId), "_courseId")
            .HasConversion(idConverter)
            .HasColumnName("CourseId");

        builder.HasOne<Course>()
            .WithMany()
            .HasForeignKey("_courseId")
            .IsRequired();

        builder.HasMany(typeof(Lesson), "_lessons")
            .WithOne()
            .HasForeignKey("_courseCatalogId")
            .IsRequired();
    }

    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        var urlConverter = new ValueConverter<VideoUrl, string>(dsc => dsc.Value, dsc => new VideoUrl(dsc));

        builder.HasKey(l => l.Id);
        builder.Property(l => l.Id)
            .HasConversion(idConverter);

        builder.Property(typeof(Title), "_title")
            .HasConversion(titleConverter)
            .HasColumnName("Title")
            .IsRequired();

        builder.Property(typeof(VideoUrl), "_videoUrl")
            .HasConversion(urlConverter)
            .HasColumnName("VideoUrl")
            .IsRequired();

        builder.Property(typeof(BaseId), "_courseCatalogId")
           .HasConversion(idConverter)
           .HasColumnName("CourseCatalogId");

        builder.HasOne<CourseCatalog>()
            .WithMany()
            .HasForeignKey("_courseCatalogId")
            .IsRequired();

        builder.ToTable("Lessons");
    }

    public void Configure(EntityTypeBuilder<CourseAttendee> builder)
    {
        builder.HasKey(ca => ca.Id);
        builder.Property(ca => ca.Id)
            .HasConversion(idConverter);

        builder.Property(typeof(BaseId), "_userId")
           .HasConversion(idConverter)
           .HasColumnName("UserId");

        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey("_userId")
            .IsRequired();

        builder.Property(typeof(BaseId), "_courseId")
           .HasConversion(idConverter)
           .HasColumnName("CourseId");

        builder.HasOne<Course>()
            .WithMany()
            .HasForeignKey("_courseId")
            .IsRequired();

        builder.ToTable("CourseAttendees");
    }

    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        var fullNameConverter = new ValueConverter<FullName, string>(fl => fl.Value, fl => new FullName(fl));
        var bioConverter = new ValueConverter<Biography, string>(bio => bio.Value, bio => new Biography(bio));

        builder.HasKey(i => i.Id);
        builder.Property(i => i.Id)
            .HasConversion(idConverter);

        builder.Property(typeof(FullName), "_fullName")
        .HasConversion(fullNameConverter)
        .HasColumnName("FullName")
        .IsRequired();

        builder.Property(typeof(Biography), "_bio")
        .HasConversion(bioConverter)
        .HasColumnName("Biography")
        .IsRequired();

        builder.Property(typeof(double), "_rating")
        .HasColumnName("Rating");

        builder.Property(typeof(int), "_experience")
        .HasColumnName("Experience");

        builder.HasMany(typeof(Course), "_courses")
        .WithOne()
        .HasForeignKey("_instructorId");

        builder.ToTable("Instructors");
    }
}

