using NArchitecture.Core.Application.Responses;

namespace Application.Features.EBooks.Commands.Create;

public class CreatedEBookResponse : IResponse
{
    public Guid Id { get; set; }
    public string FileUrl { get; set; }
    public Guid? BookId { get; set; }
}