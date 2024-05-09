using NArchitecture.Core.Application.Dtos;

namespace Application.Features.CatalogManagements.Queries.GetList;

public class GetListCatalogManagementListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid? MaterialId { get; set; }
    public string MaterialName { get; set; }
    public Guid? BookId { get; set; }
    public string BookBookTitle { get; set; }  // Kitab�n ad�
    public Guid? MagazineId { get; set; }
    public string MagazineMagazineTitle { get; set; }  // Kitab�n ad�
    public Guid CatalogId { get; set; }
    public string CatalogName { get; set; }
    //public string AuthorName { get; set; } // Yazar�n ad�
}