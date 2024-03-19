using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Books.Queries.GetList;

public class GetListBookListItemDto : IDto
{
    public Guid Id { get; set; }
    public int ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public Guid PublisherId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid LocationId { get; set; }
    public bool Status { get; set; }
}