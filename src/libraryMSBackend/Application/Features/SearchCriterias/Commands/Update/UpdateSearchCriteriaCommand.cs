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

namespace Application.Features.SearchCriterias.Commands.Update;

public class UpdateSearchCriteriaCommand : IRequest<UpdatedSearchCriteriaResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public string? BookTitle { get; set; }
    public string? MagazineTitle { get; set; }
    public string? MaterialName { get; set; }
    public string? AuthorName { get; set; }
    public string? AuthorSurname { get; set; }
    public string? MagazineISSNCode { get; set; }
    public string? BookISBNCode { get; set; }

    public string[] Roles => [Admin, Write, SearchCriteriasOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetSearchCriterias"];

    public class UpdateSearchCriteriaCommandHandler : IRequestHandler<UpdateSearchCriteriaCommand, UpdatedSearchCriteriaResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISearchCriteriaRepository _searchCriteriaRepository;
        private readonly SearchCriteriaBusinessRules _searchCriteriaBusinessRules;

        public UpdateSearchCriteriaCommandHandler(IMapper mapper, ISearchCriteriaRepository searchCriteriaRepository,
                                         SearchCriteriaBusinessRules searchCriteriaBusinessRules)
        {
            _mapper = mapper;
            _searchCriteriaRepository = searchCriteriaRepository;
            _searchCriteriaBusinessRules = searchCriteriaBusinessRules;
        }

        public async Task<UpdatedSearchCriteriaResponse> Handle(UpdateSearchCriteriaCommand request, CancellationToken cancellationToken)
        {
            SearchCriteria? searchCriteria = await _searchCriteriaRepository.GetAsync(predicate: sc => sc.Id == request.Id, cancellationToken: cancellationToken);
            await _searchCriteriaBusinessRules.SearchCriteriaShouldExistWhenSelected(searchCriteria);
            searchCriteria = _mapper.Map(request, searchCriteria);

            await _searchCriteriaRepository.UpdateAsync(searchCriteria!);

            UpdatedSearchCriteriaResponse response = _mapper.Map<UpdatedSearchCriteriaResponse>(searchCriteria);
            return response;
        }
    }
}