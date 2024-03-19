using NArchitecture.Core.Application.Responses;

namespace Application.Features.FineDues.Commands.Delete;

public class DeletedFineDueResponse : IResponse
{
    public Guid Id { get; set; }
}