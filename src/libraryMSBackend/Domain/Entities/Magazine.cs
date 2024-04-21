using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Magazine : Entity<Guid>
{
    public string ISSNCode { get; set; }
    public string MagazineTitle { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Number { get; set; }
    public Guid PublisherId { get; set; }
    public int? CategoryId { get; set; }
    public Magazine()
    {
        CatalogManagements = new HashSet<CatalogManagement>();
        MagazineAuthors = new HashSet<MagazineAuthor>();
    }
    public virtual Publisher Publisher { get; set; }
    public virtual Category? Category { get; set; }
    public virtual ICollection<CatalogManagement> CatalogManagements { get; set; }
    public virtual ICollection<MagazineAuthor> MagazineAuthors { get; set; }

   
}
