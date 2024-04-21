using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BookIssueConfiguration : IEntityTypeConfiguration<BookIssue>
{
    public void Configure(EntityTypeBuilder<BookIssue> builder)
    {
        builder.ToTable("BookIssues").HasKey(bi => bi.Id);

        builder.Property(bi => bi.Id).HasColumnName("Id").IsRequired();
        builder.Property(bi => bi.BookId).HasColumnName("BookId");
        builder.Property(bi => bi.MemberId).HasColumnName("MemberId");
        builder.Property(bi => bi.LibraryStaffId).HasColumnName("LibraryStaffId");
        builder.Property(bi => bi.ReturnDate).HasColumnName("ReturnDate");
        builder.Property(bi => bi.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(bi => bi.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(bi => bi.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(r => r.Book)
              .WithMany(b => b.BookIssues)
              .HasForeignKey(r => r.BookId);

        builder.HasOne(r => r.Member)
              .WithMany(b => b.BookIssues)
              .HasForeignKey(r => r.MemberId);

        builder.HasOne(r => r.LibraryStaff)
              .WithMany(b => b.BookIssues)
              .HasForeignKey(r => r.LibraryStaffId);


        builder.HasQueryFilter(bi => !bi.DeletedDate.HasValue);
    }
}