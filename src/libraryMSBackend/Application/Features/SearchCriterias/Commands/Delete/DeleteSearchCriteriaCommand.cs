using Application.Features.SearchCriterias.Constants;
using Application.Features.SearchCriterias.Constants;
using Application.Features.SearchCriterias.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.SearchCriterias.Constants.SearchCriteriasOperationClaims;

namespace Application.Features.SearchCriterias.Commands.Delete;

public class DeleteSearchCriteriaCommand : IRequest<DeletedSearchCriteriaResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, SearchCriteriasOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetSearchCriterias"];

    public class DeleteSearchCriteriaCommandHandler : IRequestHandler<DeleteSearchCriteriaCommand, DeletedSearchCriteriaResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISearchCriteriaRepository _searchCriteriaRepository;
        private readonly SearchCriteriaBusinessRules _searchCriteriaBusinessRules;

        public DeleteSearchCriteriaCommandHandler(IMapper mapper, ISearchCriteriaRepository searchCriteriaRepository,
                                         SearchCriteriaBusinessRules searchCriteriaBusinessRules)
        {
            _mapper = mapper;
            _searchCriteriaRepository = searchCriteriaRepository;
            _searchCriteriaBusinessRules = searchCriteriaBusinessRules;
        }

        public async Task<DeletedSearchCriteriaResponse> Handle(DeleteSearchCriteriaCommand request, CancellationToken cancellationToken)
        {
            SearchCriteria? searchCriteria = await _searchCriteriaRepository.GetAsync(predicate: sc => sc.Id == request.Id, cancellationToken: cancellationToken);
            await _searchCriteriaBusinessRules.SearchCriteriaShouldExistWhenSelected(searchCriteria);

            await _searchCriteriaRepository.DeleteAsync(searchCriteria!);

            DeletedSearchCriteriaResponse response = _mapper.Map<DeletedSearchCriteriaResponse>(searchCriteria);
            return response;
        }
    }
}