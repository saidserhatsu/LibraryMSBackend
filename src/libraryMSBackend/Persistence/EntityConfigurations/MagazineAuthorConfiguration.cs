using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class MagazineAuthorConfiguration : IEntityTypeConfiguration<MagazineAuthor>
{
    public void Configure(EntityTypeBuilder<MagazineAuthor> builder)
    {
        builder.ToTable("MagazineAuthors").HasKey(ma => new { ma.AuthorId, ma.MagazineId });

        builder.Property(ma => ma.MagazineId).HasColumnName("MagazineId");
        builder.Property(ma => ma.AuthorId).HasColumnName("AuthorId");

        builder
            .HasOne(ma => ma.Author)
            .WithMany(a => a.MagazineAuthors)
            .HasForeignKey(ma => ma.AuthorId);

        builder.HasOne(ma => ma.Magazine)
               .WithMany(m => m.MagazineAuthors)
               .HasForeignKey(ma => ma.MagazineId);

        builder.HasQueryFilter(ma => !ma.DeletedDate.HasValue);
    }
}