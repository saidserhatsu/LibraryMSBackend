using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Member : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool Subscribe { get; set; }
    public Guid UserId { get; set; }
    public int MemberSettingId { get; set; }

    public virtual User User { get; set; }
    public virtual MemberSetting MemberSetting { get; set; }
    public virtual ICollection<BookReservation> BookReservations { get; set; }
    public virtual ICollection<BookIssue> BookIssues { get; set; }
    public virtual ICollection<FinePayment> FinePayments { get; set; }
}
