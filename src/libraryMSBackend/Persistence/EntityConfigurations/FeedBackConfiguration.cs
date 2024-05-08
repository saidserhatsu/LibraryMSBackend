using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
{
    public void Configure(EntityTypeBuilder<FeedBack> builder)
    {
        builder.ToTable("FeedBacks").HasKey(fb => fb.Id);

        builder.Property(fb => fb.Id).HasColumnName("Id").IsRequired();
        builder.Property(fb => fb.MemberId).HasColumnName("MemberId").IsRequired();
        builder.Property(fb => fb.FirstName).HasColumnName("FirstName").IsRequired();
        builder.Property(fb => fb.LastName).HasColumnName("LastName").IsRequired();
        builder.Property(fb => fb.Email).HasColumnName("Email").IsRequired();
        builder.Property(fb => fb.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
        builder.Property(fb => fb.Title).HasColumnName("Title").IsRequired();
        builder.Property(fb => fb.Description).HasColumnName("Description").IsRequired();
        builder.Property(fb => fb.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(fb => fb.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(fb => fb.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(fb => !fb.DeletedDate.HasValue);
    }
}