using DigiLearn.Application.Models.PaymentManagement;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DigiLearn.Infrastructure.EF.Configs.ReadConfigs;

internal sealed partial class ReadConfiguration : IEntityTypeConfiguration<InvoiceReadModel>
{
    public void Configure(EntityTypeBuilder<InvoiceReadModel> builder)
    {
        builder.ToTable("Invoices");
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Amount).IsRequired();
        builder.Property(i => i.Date);
        builder.Property(i => i.UserId);
        builder.Property(i => i.CourseId);
        builder.HasOne(i => i.User)
            .WithMany(u => u.Invoices)
            .HasForeignKey(i => i.UserId);
        builder.HasOne(i => i.Course)
            .WithMany(c => c.Invoices)
            .HasForeignKey(i => i.CourseId);
    }
}

