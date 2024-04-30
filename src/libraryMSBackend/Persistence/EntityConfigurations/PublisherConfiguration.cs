using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.ToTable("Publishers").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Name).HasColumnName("Name");
        builder.Property(p => p.Language).HasColumnName("Language");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(

        new Publisher() { Id = Guid.Parse("cbb7895d-a862-459c-9622-2a2f3f5be99e"), Name = "Can Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("65584687-00c3-4673-b2da-d7c287e12a7c"), Name = "Kapra Yayýncýlýk", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("96946aaa-597d-4b96-a270-02a46204ebf6"), Name = "Alfa Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), Name = "Timaþ Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("ceaac2a8-b341-44cd-928c-d472e38a7f20"), Name = "YKY - Yapý Kredi Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("124589ea-4803-490c-9c86-dd68e59b8825"), Name = "Ýletiþim Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"), Name = "Doðan Kitap", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("b8fea0cc-e29a-4028-8b1b-08126eedcecb"), Name = "Bilgi Yayýnevi", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("8ecae9d5-c9c1-4362-96a2-db0231083372"), Name = "Altýn Kitaplar", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("5d604071-905c-4da5-9277-a8c0d17a717b"), Name = "Everest Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("6bb7922f-079e-41e9-bbd2-1be557f30957"), Name = "Destek Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"), Name = "Koridor Yayýncýlýk", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("5f503f17-5ca7-4a17-b131-6330c7fd52eb"), Name = "Remzi Kitabevi", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("3f51e2c8-dd62-49be-a384-6af21e614507"), Name = "Martý Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("d72f299e-e695-49c5-94fb-79e382710b91"), Name = "Ýthaki Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("46266a6c-ed71-4b7a-8367-340f2f3f8e42"), Name = "Artemis Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("53458011-9e2b-4cf9-9647-3a7364c4e8a2"), Name = "Pegasus Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("3cdebc03-bad8-4657-8ecf-f196b55bf223"), Name = "Epsilon Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("e875fb59-639f-4cd8-b2d3-3e222adb9211"), Name = "Altýn Nokta Yayýnevi", Language = "TR", CreatedDate = DateTime.UtcNow },
        new Publisher() { Id = Guid.Parse("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"), Name = "Ýþ Bankasý Kültür Yayýnlarý", Language = "TR", CreatedDate = DateTime.UtcNow }
            );

        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
    }
}