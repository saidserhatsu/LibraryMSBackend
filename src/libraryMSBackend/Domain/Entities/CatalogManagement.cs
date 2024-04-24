using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class CatalogManagement : Entity<Guid>
{
    public Guid? MaterialId { get; set; }
    public Guid? BookId { get; set; }
    public Guid? MagazineId { get; set; }
    public Guid? EBookId { get; set; }
    public Guid CatalogId { get; set; }

    public virtual Material? Material { get; set; }
    public virtual Catalog Catalog { get; set; }
    public virtual Magazine? Magazine { get; set; }
    public virtual Book? Book { get; set; }
    public virtual EBook? EBook { get; set; }
}
