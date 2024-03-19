using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Location : Entity<Guid>
{
    public int ShelfNo { get; set; }
    public int FloorNo { get; set; }
    public string ShelfName { get; set; }
    public string LibraryName { get; set; }

    public virtual ICollection<Book> Books { get; set; }
}
