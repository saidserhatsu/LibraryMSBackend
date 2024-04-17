using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class MaterialAuthorConfiguration : IEntityTypeConfiguration<MaterialAuthor>
{
    public void Configure(EntityTypeBuilder<MaterialAuthor> builder)
    {
        builder.ToTable("MaterialAuthors").HasKey(ma => new { ma.AuthorId, ma.MaterialId });

        builder.Property(ma => ma.MaterialId).HasColumnName("MaterialId");
        builder.Property(ma => ma.AuthorId).HasColumnName("AuthorId");

        builder
            .HasOne(ma => ma.Author)
            .WithMany(a => a.MaterialAuthors)
            .HasForeignKey(ma => ma.AuthorId);

        builder.HasOne(ma => ma.Material)
               .WithMany(m => m.MaterialAuthors)
               .HasForeignKey(ma => ma.MaterialId);

        builder.HasQueryFilter(ma => !ma.DeletedDate.HasValue);
    }
}