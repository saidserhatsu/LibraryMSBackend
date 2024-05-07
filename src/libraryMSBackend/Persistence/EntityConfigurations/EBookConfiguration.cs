using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class EBookConfiguration : IEntityTypeConfiguration<EBook>
{
    public void Configure(EntityTypeBuilder<EBook> builder)
    {
        builder.ToTable("EBooks").HasKey(eb => eb.Id);

        builder.Property(eb => eb.Id).HasColumnName("Id").IsRequired();
        builder.Property(eb => eb.ISBNCode).HasColumnName("ISBNCode");
        builder.Property(eb => eb.EBookTitle).HasColumnName("EBookTitle");
        builder.Property(eb => eb.ImageUrl).HasColumnName("ImageUrl");
        builder.Property(eb => eb.AuthorName).HasColumnName("AuthorName");
        builder.Property(eb => eb.ReleaseDate).HasColumnName("ReleaseDate");
        builder.Property(eb => eb.PageCount).HasColumnName("PageCount");
        builder.Property(eb => eb.CategoryId).HasColumnName("CategoryId");
        builder.Property(eb => eb.FileUrl).HasColumnName("FileUrl");
        builder.Property(eb => eb.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(eb => eb.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(eb => eb.DeletedDate).HasColumnName("DeletedDate");

        builder.HasData(

        new EBook() { Id = Guid.Parse("4fa38d56-3575-44ca-ab49-fa734492e642"), EBookTitle = "Akýllý yatýrýmcý", AuthorName = "Benjamin Graham", CategoryId = 27, FileUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715005441/to6kexw2ouxpyt4zhs5r.pdf", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg", PageCount = 343, ISBNCode = "9789759038472", ReleaseDate = 1977, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("8803a79b-fb10-4bc0-a726-45491e8a541b"), EBookTitle = "Çalýkuþu", AuthorName = "Reþat Nuri Güntekin", CategoryId = 3, FileUrl = "https://res.cloudinary.com/dafqsbtn7/raw/upload/v1714905358/jfiix2ymv4igm7trfife.pdf", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg", PageCount = 544, ISBNCode = "9789751027689", ReleaseDate = 1988, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("2583810b-e2bf-41de-8faa-a88409df1849"), EBookTitle = "Gece Yarýsý Kütüphanesi", AuthorName = "Matt Haig", CategoryId = 3, FileUrl = "https://res.cloudinary.com/dafqsbtn7/raw/upload/v1714833762/g9vhbjuvrnnkfzc7ujab.pdf", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg", PageCount = 283, ISBNCode = "9786051981833", ReleaseDate = 2020, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("f67e3283-e7f0-4ae9-8cb4-f7c237995669"), EBookTitle = "Deðersiz Bir Hayat", AuthorName = "Hanya Yanagihara", CategoryId = 31, FileUrl = "http://res.cloudinary.com/dafqsbtn7/raw/upload/v1715007073/xmfshiyayaq1a7th5ean.pdf", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg", PageCount = 864, ISBNCode = "9786050949889", ReleaseDate = 2023, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("e41fa03a-66ec-4231-9f9e-a289b8eec252"), EBookTitle = "Hýzlý ve Yavaþ Düþünme", AuthorName = "Daniel Kahneman", CategoryId = 31, FileUrl = "http://res.cloudinary.com/dafqsbtn7/raw/upload/v1715007315/vckl8qkjawrkph6e5tfm.pdf", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1715095690/mbk5rgfpdem0x20ixrin.jpg", PageCount = 588, ISBNCode = "9789754345315", ReleaseDate = 2023, CreatedDate = DateTime.Now }
        );

        builder.HasQueryFilter(eb => !eb.DeletedDate.HasValue);
    }
}