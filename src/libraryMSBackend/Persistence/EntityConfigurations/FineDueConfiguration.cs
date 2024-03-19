using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class FineDueConfiguration : IEntityTypeConfiguration<FineDue>
{
    public void Configure(EntityTypeBuilder<FineDue> builder)
    {
        builder.ToTable("FineDues").HasKey(fd => fd.Id);

        builder.Property(fd => fd.Id).HasColumnName("Id").IsRequired();
        builder.Property(fd => fd.FineTotal).HasColumnName("FineTotal");
        builder.Property(fd => fd.BookIssueId).HasColumnName("BookIssueId");
        builder.Property(fd => fd.FineDate).HasColumnName("FineDate");
        builder.Property(fd => fd.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(fd => fd.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(fd => fd.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(fd => fd.BookIssue)
               .WithMany(r => r.FineDues)
               .HasForeignKey(fd => fd.BookIssueId);

        builder.HasQueryFilter(fd => !fd.DeletedDate.HasValue);
    }
}