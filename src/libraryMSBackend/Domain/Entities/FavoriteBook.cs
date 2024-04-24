using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class FavoriteBook : Entity<Guid>
{
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }

    public virtual Member Member { get; set; }
    public virtual Book Book { get; set; }
}
