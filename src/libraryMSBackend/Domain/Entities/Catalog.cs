using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Catalog : Entity<Guid>
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public Catalog()
    {
        CatalogManagements = new HashSet<CatalogManagement>();
    }
    public virtual ICollection<CatalogManagement> CatalogManagements { get; set; }

   
}
