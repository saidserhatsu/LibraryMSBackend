using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors").HasKey(a => a.Id);

        builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
        builder.Property(a => a.FirstName).HasColumnName("FirstName");
        builder.Property(a => a.LastName).HasColumnName("LastName");
        builder.Property(a => a.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(a => a.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(a => a.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(
            new Author() { Id = Guid.Parse("999b5ec6-5d88-437c-a6a8-8f397772acd3"), FirstName = "Mustafa Kemal", LastName = "Atatürk", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("24a402a9-46e6-42f7-9d18-27ed258b8418"), FirstName = "Fyodor", LastName = "Dostoyevski", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("f52bd761-cef2-4728-b3a3-b8e1aaa86710"), FirstName = "Sun", LastName = "Tzu", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("bfcb46ec-fce6-4305-84fd-8453a0c032c2"), FirstName = "Orkun", LastName = "Uçar", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("0a0a0651-d2f9-4c37-a91d-334d850c23db"), FirstName = "Burak", LastName = "Turna", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("7d9fbe1e-67b2-4911-bb06-47b042e2245b"), FirstName = "Sabahattin", LastName = "Ali", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("283ba145-e4a5-4e21-8ae3-4a52cd44d399"), FirstName = "Oðuz", LastName = "Atay", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("ac24c21b-f665-4350-8129-9be9f02c2791"), FirstName = "Yusuf", LastName = "Atýlgan", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("2bae52f5-6e58-4071-b79c-da1cba7f560b"), FirstName = "Vedat", LastName = "Türkali", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("64919748-c9e3-423b-a9e0-51652edb5fba"), FirstName = "Jack", LastName = "London", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"), FirstName = "Reþat Nuri", LastName = "Güntekin", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("c5b259fb-a635-48b3-9a92-6155c317bc68"), FirstName = "Yaþar", LastName = "Kemal", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"), FirstName = "Emrah", LastName = "Serbes", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"), FirstName = "Grigory", LastName = "Petrov", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("8f75fb32-c516-4c3a-8a96-fa98aede126b"), FirstName = "Ahmet Hamdi", LastName = "Tanpýnar", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"), FirstName = "Aziz", LastName = "Nesin", CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}