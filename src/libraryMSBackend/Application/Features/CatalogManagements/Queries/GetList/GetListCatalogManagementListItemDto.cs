using NArchitecture.Core.Application.Dtos;

namespace Application.Features.CatalogManagements.Queries.GetList;

public class GetListCatalogManagementListItemDto : IDto
{
    public Guid Id { get; set; }
    //public Guid? MaterialId { get; set; }
    //public Guid? BookId { get; set; }
    //public Guid? MagazineId { get; set; }
    //public Guid CatalogId { get; set; }

    public string BookTitle { get; set; }  // Kitab�n ad�
    public string AuthorName { get; set; } // Yazar�n ad�
}