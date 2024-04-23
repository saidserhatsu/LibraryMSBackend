using NArchitecture.Core.Application.Responses;

namespace Application.Features.SearchCriterias.Commands.Delete;

public class DeletedSearchCriteriaResponse : IResponse
{
    public Guid Id { get; set; }
}