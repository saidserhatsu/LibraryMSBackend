using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("Locations").HasKey(l => l.Id);

        builder.Property(l => l.Id).HasColumnName("Id").IsRequired();
        builder.Property(l => l.Name).HasColumnName("Name");
        builder.Property(l => l.ShelfNo).HasColumnName("ShelfNo");
        builder.Property(l => l.FloorNo).HasColumnName("FloorNo");
        builder.Property(l => l.ShelfName).HasColumnName("ShelfName");
        builder.Property(l => l.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(l => l.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(l => l.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(
            new Location() { Id = Guid.Parse("66a89aa8-e8ad-4add-8ec8-df9d372e4833"), Name = "Merkez Kütüphane", FloorNo = 1, ShelfNo = 1, ShelfName = "Tarih Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("6347179f-64d6-4c1d-a3ec-62bc02147d73"), Name = "Merkez Kütüphane", FloorNo = 1, ShelfNo = 2, ShelfName = "Psikoloji Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("6e3709bf-803e-42d6-818c-c82cf15be93b"), Name = "Merkez Kütüphane", FloorNo = 1, ShelfNo = 3, ShelfName = "Edebiyat Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), Name = "Merkez Kütüphane", FloorNo = 1, ShelfNo = 4, ShelfName = "Roman Kitaplarý", CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(l => !l.DeletedDate.HasValue);
    }
}