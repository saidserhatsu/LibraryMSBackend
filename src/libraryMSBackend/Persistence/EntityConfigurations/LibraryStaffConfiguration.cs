using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class LibraryStaffConfiguration : IEntityTypeConfiguration<LibraryStaff>
{
    public void Configure(EntityTypeBuilder<LibraryStaff> builder)
    {
        builder.ToTable("LibraryStaffs").HasKey(ls => ls.Id);

        builder.Property(ls => ls.Id).HasColumnName("Id").IsRequired();
        builder.Property(ls => ls.FirstName).HasColumnName("FirstName");
        builder.Property(ls => ls.LastName).HasColumnName("LastName");
        builder.Property(ls => ls.BirthDate).HasColumnName("BirthDate");
        builder.Property(ls => ls.ImageUrl).HasColumnName("ImageUrl");
        builder.Property(ls => ls.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ls => ls.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(ls => ls.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(
            new LibraryStaff() { Id = Guid.Parse("f9206bc5-cf90-4623-a942-598395cb431e"), FirstName = "Ahmet", LastName = "Çetinkaya", BirthDate = DateTime.Parse("1980-02-03"), ImageUrl = "...", CreatedDate = DateTime.UtcNow},
            new LibraryStaff() { Id = Guid.Parse("7be672cf-558f-4513-98a3-cdf0b2a22d5c"), FirstName = "Halit Enes", LastName = "Kalaycý", BirthDate = DateTime.Parse("1978-06-04"), ImageUrl = "...", CreatedDate = DateTime.UtcNow },
            new LibraryStaff() { Id = Guid.Parse("22027a43-0eb7-40d2-bca6-3184563c4813"), FirstName = "Irem", LastName = "Balcý", BirthDate = DateTime.Parse("1976-10-12"), ImageUrl = "...", CreatedDate = DateTime.UtcNow },
            new LibraryStaff() { Id = Guid.Parse("5f1f04fb-c293-431d-bd8f-7b021416d048"), FirstName = "Kader", LastName = "Ergin", BirthDate = DateTime.Parse("1974-01-09"), ImageUrl = "...", CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(ls => !ls.DeletedDate.HasValue);
    }
}