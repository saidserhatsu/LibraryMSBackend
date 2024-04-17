using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class MagazineConfiguration : IEntityTypeConfiguration<Magazine>
{
    public void Configure(EntityTypeBuilder<Magazine> builder)
    {
        builder.ToTable("Magazines").HasKey(m => m.Id);

        builder.Property(m => m.Id).HasColumnName("Id").IsRequired();
        builder.Property(m => m.ISSNCode).HasColumnName("ISSNCode");
        builder.Property(m => m.MagazineTitle).HasColumnName("MagazineTitle");
        builder.Property(m => m.ReleaseDate).HasColumnName("ReleaseDate");
        builder.Property(m => m.Number).HasColumnName("Number");
        builder.Property(m => m.PublisherId).HasColumnName("PublisherId");
        builder.Property(m => m.CategoryId).HasColumnName("CategoryId");
        builder.Property(m => m.CatalogId).HasColumnName("CatalogId");
        builder.Property(m => m.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(m => m.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(m => m.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(m => !m.DeletedDate.HasValue);
    }
}