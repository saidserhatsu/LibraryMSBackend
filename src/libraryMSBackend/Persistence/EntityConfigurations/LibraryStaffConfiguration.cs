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

        builder.HasQueryFilter(ls => !ls.DeletedDate.HasValue);
    }
}