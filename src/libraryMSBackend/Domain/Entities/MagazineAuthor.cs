using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class MagazineAuthor : Entity<Guid>
{
    public Guid MagazineId { get; set; }
    public Guid AuthorId { get; set; }

    public virtual Magazine Magazine { get; set; }
    public virtual Author Author { get; set; }
}
