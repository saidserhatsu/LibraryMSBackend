using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class FavoriteBookConfiguration : IEntityTypeConfiguration<FavoriteBook>
{
    public void Configure(EntityTypeBuilder<FavoriteBook> builder)
    {
        builder.ToTable("FavoriteBooks").HasKey(fb => fb.Id);

        builder.Property(fb => fb.Id).HasColumnName("Id").IsRequired();
        builder.Property(fb => fb.BookId).HasColumnName("BookId");
        builder.Property(fb => fb.MemberId).HasColumnName("MemberId");
        builder.Property(fb => fb.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(fb => fb.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(fb => fb.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(fb => !fb.DeletedDate.HasValue);
    }
}