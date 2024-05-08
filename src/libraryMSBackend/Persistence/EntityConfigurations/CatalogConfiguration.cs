using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CatalogConfiguration : IEntityTypeConfiguration<Catalog>
{
    public void Configure(EntityTypeBuilder<Catalog> builder)
    {
        builder.ToTable("Catalogs").HasKey(c => c.Id);

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.Name).HasColumnName("Name");
        builder.Property(c => c.ImageUrl).HasColumnName("ImageUrl");
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate");
        builder.HasData(
        new Catalog() { Id = Guid.Parse("e2ddf880-692a-4dc6-9919-4ddf57f01daf"), Name = "Kiþisel Geliþim Kataloðu", CreatedDate=DateTime.Now, ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715190002/ngkgqhsyqf4jufgxbvds.jpg" },
        new Catalog() { Id = Guid.Parse("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"), Name = "Dünya Coðrafyasý Kataloðu" , CreatedDate = DateTime.Now, ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715190002/ngkgqhsyqf4jufgxbvds.jpg" },
        new Catalog() { Id = Guid.Parse("b5cad88a-dbbc-441c-a095-e9957d4fa286"), Name = "Edebiyat ve Roman Kataloðu", CreatedDate=DateTime.Now , ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715190002/ngkgqhsyqf4jufgxbvds.jpg" },
        new Catalog() { Id = Guid.Parse("398c79ce-2501-475e-b86f-0959b89e73ad"), Name = "Tarih ve Tarihî Eserler Kataloðu", CreatedDate=DateTime.Now, ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715190002/ngkgqhsyqf4jufgxbvds.jpg" },
        new Catalog() { Id = Guid.Parse("834183d5-be5d-4701-8b65-9593f2839066"), Name = "Bilim ve Teknoloji Kataloðu" , CreatedDate=DateTime.Now, ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715190002/ngkgqhsyqf4jufgxbvds.jpg" },
        new Catalog() { Id = Guid.Parse("429824df-e22f-4ca1-b8de-1eaa320a68b7"), Name = "Sanat ve Kültür Kataloðu" , CreatedDate=DateTime.Now, ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715190002/ngkgqhsyqf4jufgxbvds.jpg" });
        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
    }
}