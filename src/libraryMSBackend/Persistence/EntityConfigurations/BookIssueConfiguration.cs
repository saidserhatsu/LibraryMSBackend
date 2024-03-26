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

        builder.HasData(
            new BookIssue() { Id = Guid.Parse("e902bad2-62ea-4273-8e0b-9667e9ec0566"), BookId = Guid.Parse("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"), MemberId = Guid.Parse("e8676014-fff7-4c43-8baa-ae40263b0069"), LibraryStaffId = Guid.Parse("f9206bc5-cf90-4623-a942-598395cb431e"), ReturnDate = DateTime.UtcNow, CreatedDate = DateTime.UtcNow },
            new BookIssue() { Id = Guid.Parse("0f5ab2b8-1e2a-4380-94c6-5ea6524c4a84"), BookId = Guid.Parse("224b200d-a4cb-4ad0-8957-662dd965794c"), MemberId = Guid.Parse("10f30ed6-aa0d-4cc5-8155-63e13cc50cd9"), LibraryStaffId = Guid.Parse("22027a43-0eb7-40d2-bca6-3184563c4813"), ReturnDate = DateTime.UtcNow, CreatedDate = DateTime.UtcNow },
            new BookIssue() { Id = Guid.Parse("d36b9b6d-86bf-4dc0-b1d3-b6a1aadd0d11"), BookId = Guid.Parse("9c5fad3d-7630-4dc5-80f5-4647ceb50830"), MemberId = Guid.Parse("10f30ed6-aa0d-4cc5-8155-63e13cc50cd9"), LibraryStaffId = Guid.Parse("5f1f04fb-c293-431d-bd8f-7b021416d048"), ReturnDate = DateTime.UtcNow, CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(bi => !bi.DeletedDate.HasValue);
    }
}