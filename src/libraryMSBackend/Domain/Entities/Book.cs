using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Book : Entity<Guid> 
{
    public string ISBN_Code { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public BookStatus Status { get; set; }
    public Guid PublisherId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid LocationId { get; set; }

    public virtual Category Category { get; set; }
    public virtual Location Location { get; set; }
    public virtual Publisher Publisher { get; set; }
    public virtual ICollection<BookAuthor> Authors { get; set; }
    public virtual ICollection<BookReservation> BookReservations { get; set; }
    public virtual ICollection<BookIssue> BookIssues { get; set; }
}
