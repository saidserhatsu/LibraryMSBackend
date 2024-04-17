using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Author : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    public virtual ICollection<MaterialAuthor> MaterialAuthors { get; set; }
    public virtual ICollection<MagazineAuthor> MagazineAuthors { get; set; }
}
