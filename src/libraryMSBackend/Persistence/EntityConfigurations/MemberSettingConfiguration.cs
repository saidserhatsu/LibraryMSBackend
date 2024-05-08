using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class MemberSettingConfiguration : IEntityTypeConfiguration<MemberSetting>
{
    public void Configure(EntityTypeBuilder<MemberSetting> builder)
    {
        builder.ToTable("MemberSettings").HasKey(ms => ms.Id);

        builder.Property(ms => ms.Id).HasColumnName("Id").IsRequired();
        builder.Property(ms => ms.UiTheme).HasColumnName("UiTheme");
        builder.Property(ms => ms.Language).HasColumnName("Language");
        
        builder.Property(ms => ms.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ms => ms.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(ms => ms.DeletedDate).HasColumnName("DeletedDate");

        builder.HasIndex(indexExpression: i => i.MemberId, name: "UK_MemberSettings_MemberId").IsUnique();
        builder.HasOne(m => m.Member);

        builder.HasQueryFilter(ms => !ms.DeletedDate.HasValue);
    }
}