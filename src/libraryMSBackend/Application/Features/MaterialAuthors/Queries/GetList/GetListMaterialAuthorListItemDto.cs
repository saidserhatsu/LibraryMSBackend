using NArchitecture.Core.Application.Dtos;

namespace Application.Features.MaterialAuthors.Queries.GetList;

public class GetListMaterialAuthorListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid MaterialId { get; set; }
    public string MaterialName { get; set; }
    public Guid AuthorId { get; set; }
    public string AuthorFirstName { get; set; }
    public string AuthorLastName { get; set; }

}