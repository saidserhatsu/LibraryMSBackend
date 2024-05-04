using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nest;
using System.Reflection.Emit;
using System.Security.Policy;

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
        builder.Property(b => b.PageCount).HasColumnName("PageCount");
        builder.Property(b => b.Status).HasColumnName("Status");
        builder.Property(b => b.ImageUrl).HasColumnName("ImageUrl");
        builder.Property(b => b.PublisherId).HasColumnName("PublisherId");
        builder.Property(b => b.CategoryId).HasColumnName("CategoryId");
        builder.Property(b => b.LocationId).HasColumnName("LocationId");
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        

        builder.HasData(
            new Book() { Id = Guid.Parse("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"), ISBNCode = "9789759038472", BookTitle = "Yaþar Ne Yaþar Ne Yaþamaz", BookEdition = 1, ReleaseDate = 1977, PageCount = 343, Status = Domain.Enums.BookStatus.Available, PublisherId = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow, ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png" },
            new Book() { Id = Guid.Parse("1aa5427d-24ac-48ae-8788-a5d8102056eb"), ISBNCode = "9789944888349", BookTitle = "Nutuk", BookEdition = 1, ReleaseDate = 1977, PageCount = 343, Status = Domain.Enums.BookStatus.Available, PublisherId = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"), CategoryId = 2, LocationId = Guid.Parse("66a89aa8-e8ad-4add-8ec8-df9d372e4833"), CreatedDate = DateTime.UtcNow, ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png" },
            new Book() { Id = Guid.Parse("d1d16714-3328-42bd-a2b3-53fe5e03cb41"), ISBNCode = "9786051414315", BookTitle = "Saatleri Ayarlama Enstitüsü", BookEdition = 1, ReleaseDate = 1961, PageCount = 420, Status = BookStatus.Available, PublisherId = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow, ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png"},
            new Book() { Id = Guid.Parse("8214333a-6ddd-4c4c-8803-dd2efd58cd64"), ISBNCode = "9789754700114", BookTitle = "Kürk Mantolu Madonna", BookEdition = 1, ReleaseDate = 1943, PageCount = 168, Status = BookStatus.Available, PublisherId = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow, ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png"},
            new Book() { Id = Guid.Parse("9a315107-d02c-4d47-ab72-b48b3cfc0d56"), ISBNCode = "9789750812705", BookTitle = "Tutunamayanlar", BookEdition = 1, ReleaseDate = 1972, PageCount = 712, Status = BookStatus.Available, PublisherId = Guid.Parse("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow ,ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png"},
            new Book() { Id = Guid.Parse("399c68e7-f2ce-4416-893c-946dd3696ed3"), ISBNCode = "9789750805158", BookTitle = "Aylak Adam", BookEdition = 1, ReleaseDate = 1959, PageCount = 176, Status = BookStatus.Available, PublisherId = Guid.Parse("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow, ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png"},
            new Book() { Id = Guid.Parse("81e99a97-2bfd-4754-9637-978b162bd04e"), ISBNCode = "9789750736056", BookTitle = "Bir Gün Tek Baþýna", BookEdition = 1, ReleaseDate = 1974, PageCount = 424, Status = BookStatus.Available, PublisherId = Guid.Parse("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow, ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png"},
            new Book() { Id = Guid.Parse("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"), ISBNCode = "9786052954018", BookTitle = "Beyaz Diþ", BookEdition = 1, ReleaseDate = 1906, PageCount = 240, Status = BookStatus.Available, PublisherId = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow ,ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png"},
            new Book() { Id = Guid.Parse("0ac0f60e-20d3-47d0-982e-2d642c19e704"), ISBNCode = "9786051414315", BookTitle = "Çalýkuþu", BookEdition = 1, ReleaseDate = 1922, PageCount = 280, Status = BookStatus.Available, PublisherId = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow ,ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png"},
            new Book() { Id = Guid.Parse("2e73afc5-80d2-4549-bab8-02b69762dd04"), ISBNCode = "9789754709117", BookTitle = "Ýnce Memed", BookEdition = 1, ReleaseDate = 1955, PageCount = 440, Status = BookStatus.Available, PublisherId = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow , ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png"},
            new Book() { Id = Guid.Parse("c776b453-d81f-4d5b-82af-845fcd3b08fb"), ISBNCode = "9789750718352", BookTitle = "Gülþah", BookEdition = 1, ReleaseDate = 1985, PageCount = 360, Status = BookStatus.Available, PublisherId = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"), CategoryId = 3, LocationId = Guid.Parse("57cac248-2a17-43bf-a584-9d2e7e966457"), CreatedDate = DateTime.UtcNow ,ImageUrl= "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png"}
           
            );

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
    }
}

            