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

        new EBook() { Id = Guid.Parse("4fa38d56-3575-44ca-ab49-fa734492e642"), EBookTitle = "Yaþar Ne Yaþar Ne Yaþamaz", AuthorName = "Hasan Tek", CategoryId = 3, FileUrl = "www.fileurl.com/pdf1", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 343, ISBNCode = "9789759038472", ReleaseDate = 1977, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("8803a79b-fb10-4bc0-a726-45491e8a541b"), EBookTitle = "Siyah Beyaz", AuthorName = "Ahmet Yýlmaz", CategoryId = 4, FileUrl = "www.fileurl.com/pdf2", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 210, ISBNCode = "9789759038473", ReleaseDate = 1988, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("2583810b-e2bf-41de-8faa-a88409df1849"), EBookTitle = "Gökyüzü", AuthorName = "Emine Gül", CategoryId = 2, FileUrl = "www.fileurl.com/pdf3", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 176, ISBNCode = "9789759038474", ReleaseDate = 1995, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("217a3bae-a23e-43f6-b7c9-30d9731b536c"), EBookTitle = "Deniz Yýldýzý", AuthorName = "Mustafa Koca", CategoryId = 1, FileUrl = "www.fileurl.com/pdf4", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 310, ISBNCode = "9789759038475", ReleaseDate = 2000, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("1c9505c2-16a5-4830-aee9-630e70f51391"), EBookTitle = "Yeþil Bahçe", AuthorName = "Ayþe Nur", CategoryId = 5, FileUrl = "www.fileurl.com/pdf5", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 250, ISBNCode = "9789759038476", ReleaseDate = 2005, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("b7456736-9fbf-4e9b-869c-8935a4f5cca1"), EBookTitle = "Mavi Yol", AuthorName = "Ali Demir", CategoryId = 6, FileUrl = "www.fileurl.com/pdf6", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 270, ISBNCode = "9789759038477", ReleaseDate = 2010, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("179a926b-d022-4bcc-8e78-f977127853e1"), EBookTitle = "Çöl Rüzgarý", AuthorName = "Merve Korkmaz", CategoryId = 7, FileUrl = "www.fileurl.com/pdf7", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 290, ISBNCode = "9789759038478", ReleaseDate = 2015, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("74e96a42-91c6-4d66-bacb-ee04e90ca081"), EBookTitle = "Vadi", AuthorName = "Selin Özgür", CategoryId = 8, FileUrl = "www.fileurl.com/pdf8", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 260, ISBNCode = "9789759038479", ReleaseDate = 2020, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("6cc13c88-973f-4720-9aea-5fe3fe6d4670"), EBookTitle = "Nehrin Kýyýsý", AuthorName = "Zeynep Kýlýç", CategoryId = 9, FileUrl = "www.fileurl.com/pdf9", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 330, ISBNCode = "9789759038480", ReleaseDate = 2022, CreatedDate = DateTime.Now },
        new EBook() { Id = Guid.Parse("602a8dfe-36e7-4945-a569-c3eb3300d490"), EBookTitle = "Dað Baþýnda", AuthorName = "Barýþ Taþ", CategoryId = 10, FileUrl = "www.fileurl.com/pdf10", ImageUrl = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", PageCount = 305, ISBNCode = "9789759038481", ReleaseDate = 2023, CreatedDate = DateTime.Now }
        );

        builder.HasQueryFilter(eb => !eb.DeletedDate.HasValue);
    }
}