using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class EBook : Entity<Guid>
{
    public string ISBNCode { get; set; }
    public string EBookTitle { get; set; }
    public string AuthorName { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public int CategoryId { get; set; }
    public string FileUrl { get; set; }
    public string ImageUrl { get; set; } = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg";

    public virtual Category Category { get; set; }
    public virtual ICollection<CatalogManagement> CatalogManagements { get; set; }
}
