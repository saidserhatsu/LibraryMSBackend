using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class LibraryStaff : Entity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ImageUrl { get; set; }
    public DateTime BirthDate { get; set; }
    public LibraryStaff()
    {
        BookIssues = new HashSet<BookIssue>();
    }
    public virtual ICollection<BookIssue> BookIssues { get; set; }

   
}
