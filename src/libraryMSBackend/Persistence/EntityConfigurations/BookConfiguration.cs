using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Persistence.EntityConfigurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books").HasKey(b => b.Id);

        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.ISBNCode).HasColumnName("ISBNCode");
        builder.Property(b => b.BookTitle).HasColumnName("BookTitle");
        builder.Property(b => b.BookEdition).HasColumnName("BookEdition");
        builder.Property(b => b.ReleaseDate).HasColumnName("ReleaseDate");
        builder.Property(b => b.Status).HasColumnName("Status");
        builder.Property(b => b.PublisherId).HasColumnName("PublisherId");
        builder.Property(b => b.CategoryId).HasColumnName("CategoryId");
        builder.Property(b => b.LocationId).HasColumnName("LocationId");
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(
            new Book() { Id = Guid.Parse("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"), ISBNCode = "9781234567897", BookTitle = "Nutuk", BookEdition = 10, ReleaseDate = 1927, Status = Domain.Enums.BookStatus.Available, PublisherId = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"), CategoryId = 2, LocationId = Guid.Parse("66a89aa8-e8ad-4add-8ec8-df9d372e4833"), CreatedDate = DateTime.UtcNow },
            new Book() { Id = Guid.Parse("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"), ISBNCode = "4373695632743", BookTitle = "Savaþ Sanatý", BookEdition = 15, ReleaseDate = 1959, Status = Domain.Enums.BookStatus.Available, PublisherId = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"), CategoryId = 2, LocationId = Guid.Parse("66a89aa8-e8ad-4add-8ec8-df9d372e4833"), CreatedDate = DateTime.UtcNow },
            new Book() { Id = Guid.Parse("224b200d-a4cb-4ad0-8957-662dd965794c"), ISBNCode = "9472837462176", BookTitle = "Yeraltýndan Notlar", BookEdition = 21, ReleaseDate = 2000, Status = Domain.Enums.BookStatus.Available, PublisherId = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"), CategoryId = 1, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow },
            new Book() { Id = Guid.Parse("9c5fad3d-7630-4dc5-80f5-4647ceb50830"), ISBNCode = "6482901846372", BookTitle = "Suç ve Ceza", BookEdition = 9, ReleaseDate = 1983, Status = Domain.Enums.BookStatus.Available, PublisherId = Guid.Parse("96946aaa-597d-4b96-a270-02a46204ebf6"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}