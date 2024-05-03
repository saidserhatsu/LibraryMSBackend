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
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate");
        builder.HasData(
        new Catalog() { Id = Guid.Parse("e2ddf880-692a-4dc6-9919-4ddf57f01daf"), Name = "Kiþisel Geliþim Kataloðu", CreatedDate=DateTime.Now },
        new Catalog() { Id = Guid.Parse("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"), Name = "Dünya Coðrafyasý Kataloðu" , CreatedDate = DateTime.Now },
        new Catalog() { Id = Guid.Parse("b5cad88a-dbbc-441c-a095-e9957d4fa286"), Name = "Edebiyat ve Roman Kataloðu", CreatedDate=DateTime.Now },
        new Catalog() { Id = Guid.Parse("398c79ce-2501-475e-b86f-0959b89e73ad"), Name = "Tarih ve Tarihî Eserler Kataloðu", CreatedDate=DateTime.Now },
        new Catalog() { Id = Guid.Parse("834183d5-be5d-4701-8b65-9593f2839066"), Name = "Bilim ve Teknoloji Kataloðu" , CreatedDate=DateTime.Now},
        new Catalog() { Id = Guid.Parse("429824df-e22f-4ca1-b8de-1eaa320a68b7"), Name = "Sanat ve Kültür Kataloðu" , CreatedDate=DateTime.Now},
        new Catalog() { Id = Guid.Parse("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"), Name = "Psikoloji Kataloðu", CreatedDate=DateTime.Now },
        new Catalog() { Id = Guid.Parse("23182d33-1ebf-4a74-a93d-0c63cd2047a2"), Name = "Ekonomi ve Finans Kataloðu" , CreatedDate=DateTime.Now},
        new Catalog() { Id = Guid.Parse("cf491419-601d-4bde-9b46-0e610589a4d7"), Name = "Felsefe ve Din Kataloðu", CreatedDate=DateTime.Now },
        new Catalog() { Id = Guid.Parse("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"), Name = "Çocuk ve Gençlik Kitaplarý Kataloðu", CreatedDate=DateTime.Now },
        new Catalog() { Id = Guid.Parse("35c235e3-95c5-4fd4-b0a1-93a730d9f839"), Name = "Biliþim", CreatedDate=DateTime.Now });
        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
    }
}