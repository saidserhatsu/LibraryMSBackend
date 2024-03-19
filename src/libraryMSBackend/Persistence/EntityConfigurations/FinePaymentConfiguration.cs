using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class FinePaymentConfiguration : IEntityTypeConfiguration<FinePayment>
{
    public void Configure(EntityTypeBuilder<FinePayment> builder)
    {
        builder.ToTable("FinePayments").HasKey(fp => fp.Id);

        builder.Property(fp => fp.Id).HasColumnName("Id").IsRequired();
        builder.Property(fp => fp.PaymentAmount).HasColumnName("PaymentAmount");
        builder.Property(fp => fp.MemberId).HasColumnName("MemberId");
        builder.Property(fp => fp.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(fp => fp.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(fp => fp.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(fp => fp.Member)
            .WithMany(m => m.FinePayments)
            .HasForeignKey(fp => fp.MemberId);

        builder.HasQueryFilter(fp => !fp.DeletedDate.HasValue);
    }
}