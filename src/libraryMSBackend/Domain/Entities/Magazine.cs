using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Magazine : Entity<Guid>
{
    public string ISSNCode { get; set; }
    public string MagazineTitle { get; set; }
    public int ReleaseDate { get; set; }
    public int Number { get; set; }
    public Guid PublisherId { get; set; }
    public int? CategoryId { get; set; }
    public Guid? CatalogId { get; set; }

    public virtual Publisher Publisher { get; set; }
    public virtual Category? Category { get; set; }
    public virtual Catalog? Catalog { get; set; }
    public virtual ICollection<MagazineAuthor> MagazineAuthors { get; set; }
}
