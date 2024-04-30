using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
{
    public void Configure(EntityTypeBuilder<BookAuthor> builder)
    {
        builder.ToTable("BookAuthors").HasKey(ba => new {ba.BookId,ba.AuthorId});

        builder.Property(ba => ba.BookId).HasColumnName("BookId");
        builder.Property(ba => ba.AuthorId).HasColumnName("AuthorId");

        builder
            .HasOne(ba => ba.Book)
            .WithMany(a => a.BookAuthors)
            .HasForeignKey(ba => ba.BookId);

        builder
            .HasOne(ba => ba.Author)
            .WithMany(a => a.BookAuthors)
            .HasForeignKey(ba => ba.AuthorId);

        builder.HasData(
            new BookAuthor() { BookId = Guid.Parse("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"), AuthorId = Guid.Parse("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5") },
            new BookAuthor() { BookId = Guid.Parse("1aa5427d-24ac-48ae-8788-a5d8102056eb"), AuthorId = Guid.Parse("999b5ec6-5d88-437c-a6a8-8f397772acd3") },
            new BookAuthor() { BookId = Guid.Parse("d1d16714-3328-42bd-a2b3-53fe5e03cb41"), AuthorId = Guid.Parse("8f75fb32-c516-4c3a-8a96-fa98aede126b") },
            new BookAuthor() { BookId = Guid.Parse("8214333a-6ddd-4c4c-8803-dd2efd58cd64"), AuthorId = Guid.Parse("7d9fbe1e-67b2-4911-bb06-47b042e2245b") },
            new BookAuthor() { BookId = Guid.Parse("9a315107-d02c-4d47-ab72-b48b3cfc0d56"), AuthorId = Guid.Parse("283ba145-e4a5-4e21-8ae3-4a52cd44d399") },
            new BookAuthor() { BookId = Guid.Parse("399c68e7-f2ce-4416-893c-946dd3696ed3"), AuthorId = Guid.Parse("ac24c21b-f665-4350-8129-9be9f02c2791") },
            new BookAuthor() { BookId = Guid.Parse("81e99a97-2bfd-4754-9637-978b162bd04e"), AuthorId = Guid.Parse("2bae52f5-6e58-4071-b79c-da1cba7f560b") },
            new BookAuthor() { BookId = Guid.Parse("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"), AuthorId = Guid.Parse("64919748-c9e3-423b-a9e0-51652edb5fba") },
            new BookAuthor() { BookId = Guid.Parse("0ac0f60e-20d3-47d0-982e-2d642c19e704"), AuthorId = Guid.Parse("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e") },
            new BookAuthor() { BookId = Guid.Parse("2e73afc5-80d2-4549-bab8-02b69762dd04"), AuthorId = Guid.Parse("c5b259fb-a635-48b3-9a92-6155c317bc68") },
            new BookAuthor() { BookId = Guid.Parse("c776b453-d81f-4d5b-82af-845fcd3b08fb"), AuthorId = Guid.Parse("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21") },
            new BookAuthor() { BookId = Guid.Parse("a6e2a4ba-ab5f-473d-a47e-b6634c241389"), AuthorId = Guid.Parse("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34") }
            );
      
    }
}