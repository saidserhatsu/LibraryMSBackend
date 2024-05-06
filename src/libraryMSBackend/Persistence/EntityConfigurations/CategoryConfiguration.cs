using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories").HasKey(c => c.Id);

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.Name).HasColumnName("Name");
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(
            new Category() { Id = 1, Name = "Edebiyat", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 2, Name = "Tarih", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 3, Name = "Roman", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 4, Name = "Psikoloji", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 5, Name = "Felsefe", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 6, Name = "Bilim Kurgu", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 7, Name = "Fantastik", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 8, Name = "Polisiye", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 9, Name = "Macera", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 10, Name = "Aþk", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 11, Name = "Çocuk", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 12, Name = "Biyografi", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 13, Name = "Otobiyografi", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 14, Name = "Gezi", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 15, Name = "Sanat", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 16, Name = "Mimari", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 17, Name = "Müzik", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 18, Name = "Tiyatro", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 19, Name = "Dans", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 20, Name = "Sinema", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 21, Name = "Þiir", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 22, Name = "Antoloji", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 23, Name = "Yemek", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 24, Name = "Saðlýk", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 25, Name = "Týp", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 26, Name = "Eðitim", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 27, Name = "Ekonomi", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 28, Name = "Ýþ Dünyasý", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 29, Name = "Hukuk", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 30, Name = "Politika", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 31, Name = "Kiþisel Geliþim", CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
    }
}