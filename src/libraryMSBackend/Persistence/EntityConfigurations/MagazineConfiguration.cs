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
        builder.Property(m => m.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(m => m.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(m => m.DeletedDate).HasColumnName("DeletedDate");



        builder.HasData(
        new Magazine
        {
            Id = Guid.Parse("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
            ISSNCode = "ISSN1234-5678",
            MagazineTitle = "Tech Insights",
            ReleaseDate = new DateTime(2024, 3, 15),
            Number = 1,
            PublisherId = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
            CategoryId = 2,
            CreatedDate = DateTime.UtcNow.AddDays(-30)
        },
        new Magazine
        {
            Id = Guid.Parse("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
            ISSNCode = "ISSN9876-5432",
            MagazineTitle = "Health & Wellness",
            ReleaseDate = new DateTime(2024, 4, 5),
            Number = 2,
            PublisherId = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
            CategoryId = 1,
            CreatedDate = DateTime.UtcNow.AddDays(-20)
        },
        new Magazine
        {
            Id = Guid.Parse("c5939743-2f35-48f8-9858-51f4c1556bf0"),
            ISSNCode = "ISSN5555-1234",
            MagazineTitle = "Finance Focus",
            ReleaseDate = new DateTime(2024, 4, 10),
            Number = 3,
            PublisherId = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
            CategoryId = 3,
            CreatedDate = DateTime.UtcNow.AddDays(-15)
        },
        new Magazine
        {
            Id = Guid.Parse("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
            ISSNCode = "ISSN7777-4321",
            MagazineTitle = "Travel Trends",
            ReleaseDate = new DateTime(2024, 4, 20),
            Number = 4,
            PublisherId = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"),
            CategoryId = 1,
            CreatedDate = DateTime.UtcNow.AddDays(-10)
        },
        new Magazine
        {
            Id = Guid.Parse("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
            ISSNCode = "ISSN8888-9999",
            MagazineTitle = "Foodie Finds",
            ReleaseDate = new DateTime(2024, 4, 8),
            Number = 5,
            PublisherId = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"),
            CategoryId = 2,
            CreatedDate = DateTime.UtcNow.AddDays(-25)
        },
        new Magazine
        {
            Id = Guid.Parse("44519209-e844-4908-9d92-75db10400dcc"),
            ISSNCode = "ISSN4444-3333",
            MagazineTitle = "Artistic Expressions",
            ReleaseDate = new DateTime(2024, 4, 12),
            Number = 6,
            PublisherId = Guid.Parse("96946aaa-597d-4b96-a270-02a46204ebf6"),
            CategoryId = 1,
            CreatedDate = DateTime.UtcNow.AddDays(-5)
        },
        new Magazine
        {
            Id = Guid.Parse("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
            ISSNCode = "ISSN2222-1111",
            MagazineTitle = "Fashion Forward",
            ReleaseDate = new DateTime(2024, 4, 18),
            Number = 7,
            PublisherId = Guid.Parse("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
            CategoryId = 2,
            CreatedDate = DateTime.UtcNow.AddDays(-12)
        },
        new Magazine
        {
            Id = Guid.Parse("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
            ISSNCode = "ISSN9999-8888",
            MagazineTitle = "Sports Spectacle",
            ReleaseDate = new DateTime(2024, 4, 22),
            Number = 8,
            PublisherId = Guid.Parse("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
            CategoryId = 1,
            CreatedDate = DateTime.UtcNow.AddDays(-8)
        },
        new Magazine
        {
            Id = Guid.Parse("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
            ISSNCode = "ISSN3333-4444",
            MagazineTitle = "Science Scopes",
            ReleaseDate = new DateTime(2024, 4, 25),
            Number = 9,
            PublisherId = Guid.Parse("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
            CategoryId = 3,
            CreatedDate = DateTime.UtcNow.AddDays(-3)
        },
        new Magazine
        {
            Id = Guid.Parse("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
            ISSNCode = "ISSN6666-5555",
            MagazineTitle = "Music Monthly",
            ReleaseDate = new DateTime(2024, 4, 28),
            Number = 10,
            PublisherId = Guid.Parse("96946aaa-597d-4b96-a270-02a46204ebf6"),
            CategoryId = 2,
            CreatedDate = DateTime.UtcNow.AddDays(-1)
        });

        builder.HasQueryFilter(m => !m.DeletedDate.HasValue);
    }
}