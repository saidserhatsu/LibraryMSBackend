using NArchitecture.Core.Application.Responses;

namespace Application.Features.EBooks.Commands.Create;

public class CreatedEBookResponse : IResponse
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string EBookTitle { get; set; }
    public string AuthorName { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public int CategoryId { get; set; }
    public string FileUrl { get; set; }
    public string ImageUrl { get; set; }
}