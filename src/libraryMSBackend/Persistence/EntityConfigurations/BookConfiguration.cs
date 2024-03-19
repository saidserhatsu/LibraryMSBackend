using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.ISBN_Code).HasColumnName("ISBN_Code");
        builder.Property(b => b.BookTitle).HasColumnName("BookTitle");
        builder.Property(b => b.BookEdition).HasColumnName("BookEdition");
        builder.Property(b => b.ReleaseDate).HasColumnName("ReleaseDate");
        builder.Property(b => b.PublisherId).HasColumnName("PublisherId");
        builder.Property(b => b.CategoryId).HasColumnName("CategoryId");
        builder.Property(b => b.LocationId).HasColumnName("LocationId");
        builder.Property(b => b.Status).HasColumnName("Status");
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder
            .HasOne(b => b.Category)
            .WithMany(b => b.Books)
            .HasForeignKey(b => b.CategoryId);

        builder.HasOne(b => b.Location)
               .WithMany(l => l.Books)
               .HasForeignKey(b => b.LocationId);

        builder.HasOne(b => b.Publisher)
               .WithMany(l => l.Books)
               .HasForeignKey(b => b.PublisherId);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}