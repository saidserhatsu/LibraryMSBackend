using Application.Features.Authors.Queries.GetById;
using Application.Features.Locations.Queries.GetById;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Books.Queries.GetList;

public class GetListBookListItemDto : IDto
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public string Status { get; set; }
    public string CategoryName { get; set; }
    public string PublisherName { get; set; }
    public string LocationName { get; set; }

    public GetByIdLocationResponse Location { get; set; }
    public ICollection<GetByIdAuthorResponse> AuthorsDto { get; set; }
}