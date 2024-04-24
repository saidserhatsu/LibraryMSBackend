using NArchitecture.Core.Application.Dtos;

namespace Application.Features.EBooks.Queries.GetList;

public class GetListEBookListItemDto : IDto
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string EBookTitle { get; set; }
    public string AuthorName { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public int CategoryId { get; set; }
    public string FileUrl { get; set; }
}