using Application.Features.Authors.Queries.GetById;
using Application.Features.Authors.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Domain.Enums;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Books.Queries.GetById;

public class GetByIdBookResponse : IResponse
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public BookStatus Status { get; set; }
    public Guid PublisherId { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public string PublisherName { get; set; }
    public GetListLocationListItemDto Location { get; set; }
    public List<GetListAuthorListItemDto> Authors { get; set; }
}