using NArchitecture.Core.Application.Responses;

namespace Application.Features.EBooks.Commands.Update;

public class UpdatedEBookResponse : IResponse
{
    public Guid Id { get; set; }
    public string FileUrl { get; set; }
    public Guid? BookId { get; set; }
}