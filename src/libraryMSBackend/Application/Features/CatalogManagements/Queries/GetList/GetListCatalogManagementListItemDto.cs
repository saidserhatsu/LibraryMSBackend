using NArchitecture.Core.Application.Dtos;

namespace Application.Features.CatalogManagements.Queries.GetList;

public class GetListCatalogManagementListItemDto : IDto
{
    public Guid Id { get; set; }
    public string BookTitle { get; set; }  // Kitabýn adý
    //public string AuthorName { get; set; } // Yazarýn adý
}