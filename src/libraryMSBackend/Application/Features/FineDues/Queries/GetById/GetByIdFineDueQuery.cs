using Application.Features.FineDues.Constants;
using Application.Features.FineDues.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.FineDues.Constants.FineDuesOperationClaims;

namespace Application.Features.FineDues.Queries.GetById;

public class GetByIdFineDueQuery : IRequest<GetByIdFineDueResponse>
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdFineDueQueryHandler : IRequestHandler<GetByIdFineDueQuery, GetByIdFineDueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFineDueRepository _fineDueRepository;
        private readonly FineDueBusinessRules _fineDueBusinessRules;

        public GetByIdFineDueQueryHandler(IMapper mapper, IFineDueRepository fineDueRepository, FineDueBusinessRules fineDueBusinessRules)
        {
            _mapper = mapper;
            _fineDueRepository = fineDueRepository;
            _fineDueBusinessRules = fineDueBusinessRules;
        }

        public async Task<GetByIdFineDueResponse> Handle(GetByIdFineDueQuery request, CancellationToken cancellationToken)
        {
            FineDue? fineDue = await _fineDueRepository.GetAsync(predicate: fd => fd.Id == request.Id, cancellationToken: cancellationToken);
            await _fineDueBusinessRules.FineDueShouldExistWhenSelected(fineDue);

            GetByIdFineDueResponse response = _mapper.Map<GetByIdFineDueResponse>(fineDue);
            return response;
        }
    }
}