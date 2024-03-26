using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
{
    public void Configure(EntityTypeBuilder<Announcement> builder)
    {
        builder.ToTable("Announcements").HasKey(a => a.Id);

        builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
        builder.Property(a => a.Title).HasColumnName("Title");
        builder.Property(a => a.Content).HasColumnName("Content");
        builder.Property(a => a.Tag).HasColumnName("Tag");
        builder.Property(a => a.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(a => a.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(a => a.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(
            new Announcement() { Id = Guid.Parse("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"), Title = "Kütüphane Üyelikleri", Content = "Content 1", Tag = Domain.Enums.AnnouncementTag.Announcement, CreatedDate = DateTime.UtcNow },
            new Announcement() { Id = Guid.Parse("e014efc4-0973-4fc1-80bb-464b4d791173"), Title = "Hıdırellez Yarışması", Content = "Content 2", Tag = Domain.Enums.AnnouncementTag.Event, CreatedDate = DateTime.UtcNow },
            new Announcement() { Id = Guid.Parse("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"), Title = "Yeni Kitaplar", Content = "Content 3", Tag = Domain.Enums.AnnouncementTag.News, CreatedDate = DateTime.UtcNow },
            new Announcement() { Id = Guid.Parse("bf3669a9-a784-4941-bf6e-4893374abb2b"), Title = "Yeni Yıl Etkinliği", Content = "Content 4", Tag = Domain.Enums.AnnouncementTag.Event, CreatedDate = DateTime.UtcNow },
            new Announcement() { Id = Guid.Parse("9c6c985f-b331-4a85-bee5-c7d2a9d57073"), Title = "Bayramlaşma", Content = "Content 5", Tag = Domain.Enums.AnnouncementTag.Event, CreatedDate = DateTime.UtcNow },
            new Announcement() { Id = Guid.Parse("7085aa16-5230-42ca-941b-6d73c692053b"), Title = "Kütüphane Açılış Saatleri", Content = "Content 6", Tag = Domain.Enums.AnnouncementTag.Announcement, CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
    }
}