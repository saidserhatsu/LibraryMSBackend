using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class BookReservationConfiguration : IEntityTypeConfiguration<BookReservation>
{
    public void Configure(EntityTypeBuilder<BookReservation> builder)
    {
        builder.ToTable("BookReservations").HasKey(br => br.Id);

        builder.Property(br => br.Id).HasColumnName("Id").IsRequired();
        builder.Property(br => br.BookId).HasColumnName("BookId");
        builder.Property(br => br.MemberId).HasColumnName("MemberId");
        builder.Property(br => br.NearestAvailableDate).HasColumnName("NearestAvailableDate");
        builder.Property(br => br.RequestDate).HasColumnName("RequestDate");
        builder.Property(br => br.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(br => br.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(br => br.DeletedDate).HasColumnName("DeletedDate");

        builder.HasOne(br => br.Book)
               .WithMany(m => m.BookReserves)
               .HasForeignKey(br => br.BookId);

        builder.HasOne(br => br.Member)
               .WithMany(m => m.BookReserves)
               .HasForeignKey(br => br.MemberId);

        builder.HasQueryFilter(br => !br.DeletedDate.HasValue);
    }
}