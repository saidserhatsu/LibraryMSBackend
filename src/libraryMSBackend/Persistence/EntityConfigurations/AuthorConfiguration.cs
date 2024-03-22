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
            new Author() { Id = Guid.Parse("999b5ec6-5d88-437c-a6a8-8f397772acd3"), FirstName = "Mustafa Kemal", LastName = "Atatürk", CreatedDate = DateTime.UtcNow},
            new Author() { Id = Guid.Parse("24a402a9-46e6-42f7-9d18-27ed258b8418"), FirstName = "Fyodor", LastName = "Dostoyevski", CreatedDate = DateTime.UtcNow },
            new Author() { Id = Guid.Parse("f52bd761-cef2-4728-b3a3-b8e1aaa86710"), FirstName = "Sun", LastName = "Tzu", CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}