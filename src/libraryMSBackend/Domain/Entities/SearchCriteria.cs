using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class SearchCriteria : Entity<Guid>
{
    public string? BookTitle { get; set; } // Nullable
    public string? MagazineTitle { get; set; }
    public string? MaterialName { get; set; }
    public string? AuthorName { get; set; }
    public string? AuthorSurname { get; set; }
    public string? MagazineISSNCode { get; set; }
    public string? BookISBNCode { get; set; }
    public string? CategoryName { get; set; }
    public string? PublisherName { get; set; }
    public string? PublisherLanguage { get; set; }
    public string? LocationsName { get; set; }
    public string? LocationsShelfName { get; set; }
    public string? MembersEmail { get; set; }
    public string? MemberFirstName { get; set; }
    public string? MemberLastName { get; set; }
    public string? EBookISBNCode { get; set; }
    public string? EBookTitle { get; set; }
    public string? EBookAuthorName { get; set; }
    public string?  AnnouncementTitle { get; set; } 

}
