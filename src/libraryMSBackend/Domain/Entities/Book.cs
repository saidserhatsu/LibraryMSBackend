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
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public BookStatus Status { get; set; }
    public Guid PublisherId { get; set; }
    public int CategoryId { get; set; }
    public Guid LocationId { get; set; }
 

    public virtual Category Category { get; set; }
    public virtual Location Location { get; set; }
    public virtual Publisher Publisher { get; set; }

    public Book()
    {
        BookAuthors = new HashSet<BookAuthor>();
        CatalogManagements = new HashSet<CatalogManagement>();
        BookReservations = new HashSet<BookReservation>();
        BookIssues = new HashSet<BookIssue>();
    }

    public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    public virtual ICollection<CatalogManagement> CatalogManagements { get; set; }
    public virtual ICollection<BookReservation> BookReservations { get; set; }
    public virtual ICollection<BookIssue> BookIssues { get; set; }

    
}
