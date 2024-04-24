using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CatalogManagementConfiguration : IEntityTypeConfiguration<CatalogManagement>
{
    public void Configure(EntityTypeBuilder<CatalogManagement> builder)
    {
        builder.ToTable("CatalogManagements").HasKey(cm => cm.Id);

        builder.Property(cm => cm.Id).HasColumnName("Id").IsRequired();
        builder.Property(cm => cm.MaterialId).HasColumnName("MaterialId");
        builder.Property(cm => cm.BookId).HasColumnName("BookId");
        builder.Property(cm => cm.MagazineId).HasColumnName("MagazineId");
        builder.Property(cm => cm.EBookId).HasColumnName("EBookId");
        builder.Property(cm => cm.CatalogId).HasColumnName("CatalogId");
        builder.Property(cm => cm.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(cm => cm.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(cm => cm.DeletedDate).HasColumnName("DeletedDate");

        builder
            .HasOne(cm => cm.Book)
            .WithMany(b => b.CatalogManagements)
            .HasForeignKey(cm => cm.BookId);

        builder
            .HasOne(cm => cm.Magazine)
            .WithMany(m => m.CatalogManagements)
            .HasForeignKey(cm => cm.MagazineId);

        builder
            .HasOne(cm => cm.Material)
            .WithMany(m => m.CatalogManagements)
            .HasForeignKey(cm => cm.MaterialId);

        builder
            .HasOne(cm => cm.EBook)
            .WithMany(m => m.CatalogManagements)
            .HasForeignKey(cm => cm.EBookId);

        builder.HasQueryFilter(cm => !cm.DeletedDate.HasValue);
    }
}