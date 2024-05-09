using NArchitecture.Core.Application.Dtos;

namespace Application.Features.CatalogManagements.Queries.GetList;

public class GetListCatalogManagementListItemDto : IDto
{
    public Guid Id { get; set; }
    public string BookTitle { get; set; }  // Kitab�n ad�
    //public string AuthorName { get; set; } // Yazar�n ad�
}