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
            new Location() { Id = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), Name = "Merkez Kütüphane", FloorNo = 1, ShelfNo = 4, ShelfName = "Roman Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("e6f25590-b816-405f-815f-dd543bcd9bbb"), Name = "Merkez Kütüphane", FloorNo = 1, ShelfNo = 5, ShelfName = "Sanat Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("9466485b-9c11-433a-b384-7d6382333193"), Name = "Merkez Kütüphane", FloorNo = 2, ShelfNo = 1, ShelfName = "Mimarlýk Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"), Name = "Merkez Kütüphane", FloorNo = 2, ShelfNo = 2, ShelfName = "Bilim Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"), Name = "Merkez Kütüphane", FloorNo = 2, ShelfNo = 3, ShelfName = "Teknoloji Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("173c9483-082d-46e9-9bf3-6ee28f906508"), Name = "Merkez Kütüphane", FloorNo = 2, ShelfNo = 4, ShelfName = "Felsefe Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"), Name = "Merkez Kütüphane", FloorNo = 2, ShelfNo = 5, ShelfName = "Ýþletme Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("c4fa4874-380f-494c-af36-423ccdfd2dea"), Name = "Merkez Kütüphane", FloorNo = 3, ShelfNo = 1, ShelfName = "Ekonomi Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("80da673f-f14f-4ce2-9d9b-bada572ddf91"), Name = "Merkez Kütüphane", FloorNo = 3, ShelfNo = 2, ShelfName = "Hukuk Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("ddacb573-f83a-4fdc-ba85-c647378da1bc"), Name = "Merkez Kütüphane", FloorNo = 3, ShelfNo = 3, ShelfName = "Medya ve Ýletiþim Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("814b3b30-e185-4181-964a-bfa2c162c9ac"), Name = "Merkez Kütüphane", FloorNo = 3, ShelfNo = 4, ShelfName = "Müzik Kitaplarý", CreatedDate = DateTime.UtcNow },
            new Location() { Id = Guid.Parse("13b7a063-80a1-4d22-bb03-0f883ef12e85"), Name = "Merkez Kütüphane", FloorNo = 3, ShelfNo = 5, ShelfName = "Sanat ve Tasarým Kitaplarý", CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(l => !l.DeletedDate.HasValue);
    }
} 