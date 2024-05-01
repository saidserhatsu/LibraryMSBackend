using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Member : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool Subscribe { get; set; }
    public Guid UserId { get; set; }
    public string ImageUrl { get; set; } = "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714577504/su3bzwsbp855r2xzsvib.png";

    public Member()
    {
        BookReservations = new HashSet<BookReservation>();
        BookIssues = new HashSet<BookIssue>();
        FinePayments = new HashSet<FinePayment>();
        FavoriteBooks = new HashSet<FavoriteBook>();
    }

    public virtual User User { get; set; }
    public virtual MemberSetting MemberSetting { get; set; }
    public virtual ICollection<BookReservation> BookReservations { get; set; }
    public virtual ICollection<BookIssue> BookIssues { get; set; }
    public virtual ICollection<FinePayment> FinePayments { get; set; }
    public virtual ICollection<FavoriteBook> FavoriteBooks { get; set; }
}
