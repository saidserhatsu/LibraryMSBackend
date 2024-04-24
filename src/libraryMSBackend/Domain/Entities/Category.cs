using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Category : Entity<int> 
{
    public string Name { get; set; }
    public Category()
    {
        Books = new HashSet<Book>();
        Magazines = new HashSet<Magazine>();
        Materials = new HashSet<Material>();
        EBooks = new HashSet<EBook>();
    }
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<EBook> EBooks { get; set; }
    public virtual ICollection<Magazine> Magazines { get; set; } = null;
    public virtual ICollection<Material> Materials { get; set; } = null;

  
}
