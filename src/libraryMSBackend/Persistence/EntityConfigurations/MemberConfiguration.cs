using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class MemberConfiguration : IEntityTypeConfiguration<Member>
{
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.ToTable("Members").HasKey(m => m.Id);

        builder.Property(m => m.Id).HasColumnName("Id").IsRequired();
        builder.Property(m => m.FirstName).HasColumnName("FirstName");
        builder.Property(m => m.LastName).HasColumnName("LastName");
        builder.Property(m => m.PhoneNumber).HasColumnName("PhoneNumber");
        builder.Property(m => m.DateOfBirth).HasColumnName("DateOfBirth");
        builder.Property(m => m.Subscribe).HasColumnName("Subscribe");
        builder.Property(m => m.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(m => m.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(m => m.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(
            new Member() { Id = Guid.Parse("e8676014-fff7-4c43-8baa-ae40263b0069"), FirstName = "Cihat", LastName = "Keskin", PhoneNumber = "05438753978", DateOfBirth = DateTime.Parse("1999-01-01"), Subscribe = false, CreatedDate = DateTime.UtcNow },
            new Member() { Id = Guid.Parse("2d7e8997-68c0-4a84-846f-ded3e8a3d6ab"), FirstName = "Sercan", LastName = "Ateþ", PhoneNumber = "05364785647", DateOfBirth = DateTime.Parse("1998-02-09"), Subscribe = false, CreatedDate = DateTime.UtcNow },
            new Member() { Id = Guid.Parse("3e754b13-3554-4f20-805f-29ba737d96cc"), FirstName = "Murat Çaðdaþ", LastName = "Balcý", PhoneNumber = "05324854373", DateOfBirth = DateTime.Parse("1997-03-10"), Subscribe = false, CreatedDate = DateTime.UtcNow },
            new Member() { Id = Guid.Parse("10f30ed6-aa0d-4cc5-8155-63e13cc50cd9"), FirstName = "Said Serhat", LastName = "Su", PhoneNumber = "05472837482", DateOfBirth = DateTime.Parse("1996-10-11"), Subscribe = false, CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(m => !m.DeletedDate.HasValue);
    }
}