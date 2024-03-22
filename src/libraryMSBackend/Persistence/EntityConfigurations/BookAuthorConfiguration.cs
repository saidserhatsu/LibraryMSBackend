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
            new BookAuthor() { BookId = Guid.Parse("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"), AuthorId = Guid.Parse("999b5ec6-5d88-437c-a6a8-8f397772acd3") },
            new BookAuthor() { BookId = Guid.Parse("224b200d-a4cb-4ad0-8957-662dd965794c"), AuthorId = Guid.Parse("24a402a9-46e6-42f7-9d18-27ed258b8418") },
            new BookAuthor() { BookId = Guid.Parse("9c5fad3d-7630-4dc5-80f5-4647ceb50830"), AuthorId = Guid.Parse("24a402a9-46e6-42f7-9d18-27ed258b8418") },
            new BookAuthor() { BookId = Guid.Parse("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"), AuthorId = Guid.Parse("f52bd761-cef2-4728-b3a3-b8e1aaa86710") }
            );
    }
}