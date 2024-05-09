using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class LibraryStaff : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; } = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714577504/su3bzwsbp855r2xzsvib.png";
    public string Email { get; set; } 
    public DateTime BirthDate { get; set; }
    public Guid UserId { get; set; }
    public LibraryStaff()
    {
        BookIssues = new HashSet<BookIssue>();
    }
    public virtual User User { get; set; }
    public virtual ICollection<BookIssue> BookIssues { get; set; }
}
