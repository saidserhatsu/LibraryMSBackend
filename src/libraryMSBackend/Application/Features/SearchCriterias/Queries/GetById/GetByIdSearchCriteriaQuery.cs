using Application.Features.SearchCriterias.Constants;
using Application.Features.SearchCriterias.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.SearchCriterias.Constants.SearchCriteriasOperationClaims;

namespace Application.Features.SearchCriterias.Queries.GetById;

public class GetByIdSearchCriteriaQuery : IRequest<GetByIdSearchCriteriaResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdSearchCriteriaQueryHandler : IRequestHandler<GetByIdSearchCriteriaQuery, GetByIdSearchCriteriaResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISearchCriteriaRepository _searchCriteriaRepository;
        private readonly SearchCriteriaBusinessRules _searchCriteriaBusinessRules;

        public GetByIdSearchCriteriaQueryHandler(IMapper mapper, ISearchCriteriaRepository searchCriteriaRepository, SearchCriteriaBusinessRules searchCriteriaBusinessRules)
        {
            _mapper = mapper;
            _searchCriteriaRepository = searchCriteriaRepository;
            _searchCriteriaBusinessRules = searchCriteriaBusinessRules;
        }

        public async Task<GetByIdSearchCriteriaResponse> Handle(GetByIdSearchCriteriaQuery request, CancellationToken cancellationToken)
        {
            SearchCriteria? searchCriteria = await _searchCriteriaRepository.GetAsync(predicate: sc => sc.Id == request.Id, cancellationToken: cancellationToken);
            await _searchCriteriaBusinessRules.SearchCriteriaShouldExistWhenSelected(searchCriteria);

            GetByIdSearchCriteriaResponse response = _mapper.Map<GetByIdSearchCriteriaResponse>(searchCriteria);
            return response;
        }
    }
}