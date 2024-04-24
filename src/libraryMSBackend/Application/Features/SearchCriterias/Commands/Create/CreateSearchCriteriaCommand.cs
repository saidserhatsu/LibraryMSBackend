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

namespace Application.Features.SearchCriterias.Commands.Create;

public class CreateSearchCriteriaCommand : IRequest<CreatedSearchCriteriaResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string? BookTitle { get; set; }
    public string? MagazineTitle { get; set; }
    public string? MaterialName { get; set; }
    public string? AuthorName { get; set; }
    public string? AuthorSurname { get; set; }
    public string? MagazineISSNCode { get; set; }
    public string? BookISBNCode { get; set; }

    public string[] Roles => [Admin, Write, SearchCriteriasOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetSearchCriterias"];

    public class CreateSearchCriteriaCommandHandler : IRequestHandler<CreateSearchCriteriaCommand, CreatedSearchCriteriaResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISearchCriteriaRepository _searchCriteriaRepository;
        private readonly SearchCriteriaBusinessRules _searchCriteriaBusinessRules;

        public CreateSearchCriteriaCommandHandler(IMapper mapper, ISearchCriteriaRepository searchCriteriaRepository,
                                         SearchCriteriaBusinessRules searchCriteriaBusinessRules)
        {
            _mapper = mapper;
            _searchCriteriaRepository = searchCriteriaRepository;
            _searchCriteriaBusinessRules = searchCriteriaBusinessRules;
        }

        public async Task<CreatedSearchCriteriaResponse> Handle(CreateSearchCriteriaCommand request, CancellationToken cancellationToken)
        {
            SearchCriteria searchCriteria = _mapper.Map<SearchCriteria>(request);

            await _searchCriteriaRepository.AddAsync(searchCriteria);

            CreatedSearchCriteriaResponse response = _mapper.Map<CreatedSearchCriteriaResponse>(searchCriteria);
            return response;
        }
    }
}