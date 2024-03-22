using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories").HasKey(c => c.Id);

        builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
        builder.Property(c => c.Name).HasColumnName("Name");
        builder.Property(c => c.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(c => c.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(c => c.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(
            new Category() { Id = 1, Name = "Edebiyat", CreatedDate = DateTime.UtcNow},
            new Category() { Id = 2, Name = "Tarih", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 3, Name = "Roman", CreatedDate = DateTime.UtcNow },
            new Category() { Id = 4, Name = "Psikoloji", CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
    }
}