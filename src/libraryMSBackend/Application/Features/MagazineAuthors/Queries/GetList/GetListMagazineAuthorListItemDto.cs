using NArchitecture.Core.Application.Dtos;

namespace Application.Features.MagazineAuthors.Queries.GetList;

public class GetListMagazineAuthorListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid MagazineId { get; set; }
    public string MagazineMagazineTitle { get; set; }
    public Guid AuthorId { get; set; }
    public string AuthorFirstName { get; set; }
    public string AuthorLastName { get; set; }

}