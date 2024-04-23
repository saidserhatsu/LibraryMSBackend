using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class SearchCriteriaConfiguration : IEntityTypeConfiguration<SearchCriteria>
{
    public void Configure(EntityTypeBuilder<SearchCriteria> builder)
    {
        builder.ToTable("SearchCriterias").HasKey(sc => sc.Id);

        builder.Property(sc => sc.Id).HasColumnName("Id").IsRequired();
        builder.Property(sc => sc.BookTitle).HasColumnName("BookTitle");
        builder.Property(sc => sc.MagazineTitle).HasColumnName("MagazineTitle");
        builder.Property(sc => sc.MaterialType).HasColumnName("MaterialType");
        builder.Property(sc => sc.AuthorName).HasColumnName("AuthorName");
        builder.Property(sc => sc.AuthorSurname).HasColumnName("AuthorSurname");
        builder.Property(sc => sc.MagazineISSNCode).HasColumnName("MagazineISSNCode");
        builder.Property(sc => sc.BookISBNCode).HasColumnName("BookISBNCode");
        builder.Property(sc => sc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(sc => sc.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(sc => sc.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(sc => !sc.DeletedDate.HasValue);
    }
}