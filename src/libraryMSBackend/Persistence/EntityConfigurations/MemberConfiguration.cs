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
        builder.Property(m => m.UserId).HasColumnName("UserId");
        builder.Property(m => m.UserId).HasColumnName("MemberSettingId");
        builder.Property(m => m.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(m => m.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(m => m.DeletedDate).HasColumnName("DeletedDate");

        // Make 1-1 relationship between Author and User
        builder.HasIndex(indexExpression: m => m.UserId, name: "Member_UserID_UK").IsUnique();
        builder.HasOne(m => m.User);

        builder.HasQueryFilter(m => !m.DeletedDate.HasValue);
    }
}