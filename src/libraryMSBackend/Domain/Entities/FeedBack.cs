using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class FeedBack : Entity<Guid>
{
    public Guid MemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }

    public virtual Member Member { get; set; }
}
