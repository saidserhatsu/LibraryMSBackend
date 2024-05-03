using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class EBookConfiguration : IEntityTypeConfiguration<EBook>
{
    public void Configure(EntityTypeBuilder<EBook> builder)
    {
        builder.ToTable("EBooks").HasKey(eb => eb.Id);

        builder.Property(eb => eb.Id).HasColumnName("Id").IsRequired();
        builder.Property(eb => eb.ISBNCode).HasColumnName("ISBNCode");
        builder.Property(eb => eb.EBookTitle).HasColumnName("EBookTitle");
        builder.Property(eb => eb.ImageUrl).HasColumnName("ImageUrl");
        builder.Property(eb => eb.AuthorName).HasColumnName("AuthorName");
        builder.Property(eb => eb.ReleaseDate).HasColumnName("ReleaseDate");
        builder.Property(eb => eb.PageCount).HasColumnName("PageCount");
        builder.Property(eb => eb.CategoryId).HasColumnName("CategoryId");
        builder.Property(eb => eb.FileUrl).HasColumnName("FileUrl");
        builder.Property(eb => eb.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(eb => eb.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(eb => eb.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(eb => !eb.DeletedDate.HasValue);
    }
}