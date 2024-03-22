using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
{
    public void Configure(EntityTypeBuilder<BookAuthor> builder)
    {
        builder.ToTable("BookAuthors").HasKey(ba => new {ba.BookId,ba.AuthorId});

        builder.Property(ba => ba.Id).HasColumnName("Id").IsRequired();
        builder.Property(ba => ba.BookId).HasColumnName("BookId");
        builder.Property(ba => ba.AuthorId).HasColumnName("AuthorId");
        builder.Property(ba => ba.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ba => ba.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(ba => ba.DeletedDate).HasColumnName("DeletedDate");

        builder
            .HasOne(ba => ba.Book)
            .WithMany(a => a.BookAuthors)
            .HasForeignKey(ba => ba.BookId);

        builder
            .HasOne(ba => ba.Author)
            .WithMany(a => a.BookAuthors)
            .HasForeignKey(ba => ba.AuthorId);

        builder.HasQueryFilter(ba => !ba.DeletedDate.HasValue);
    }
}