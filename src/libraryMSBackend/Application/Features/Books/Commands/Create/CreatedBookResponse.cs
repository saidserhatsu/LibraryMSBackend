using NArchitecture.Core.Application.Responses;

namespace Application.Features.Books.Commands.Create;

public class CreatedBookResponse : IResponse
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