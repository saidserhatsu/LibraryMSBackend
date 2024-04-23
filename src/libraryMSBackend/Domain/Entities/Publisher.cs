using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Publisher : Entity<Guid>
{
    public string Name { get; set; }
    public string Language { get; set; }
    public Publisher()
    {
        Books = new HashSet<Book>();
    }
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<Magazine> Magazines { get; set; }
    public virtual ICollection<Material> Materials { get; set; }


}
