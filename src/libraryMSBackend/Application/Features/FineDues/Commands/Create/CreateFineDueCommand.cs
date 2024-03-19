using Application.Features.FineDues.Constants;
using Application.Features.FineDues.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.FineDues.Constants.FineDuesOperationClaims;

namespace Application.Features.FineDues.Commands.Create;

public class CreateFineDueCommand : IRequest<CreatedFineDueResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public decimal FineTotal { get; set; }
    public Guid BookIssueId { get; set; }
    public DateTime FineDate { get; set; }

    public string[] Roles => [Admin, Write, FineDuesOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetFineDues"];

    public class CreateFineDueCommandHandler : IRequestHandler<CreateFineDueCommand, CreatedFineDueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFineDueRepository _fineDueRepository;
        private readonly FineDueBusinessRules _fineDueBusinessRules;

        public CreateFineDueCommandHandler(IMapper mapper, IFineDueRepository fineDueRepository,
                                         FineDueBusinessRules fineDueBusinessRules)
        {
            _mapper = mapper;
            _fineDueRepository = fineDueRepository;
            _fineDueBusinessRules = fineDueBusinessRules;
        }

        public async Task<CreatedFineDueResponse> Handle(CreateFineDueCommand request, CancellationToken cancellationToken)
        {
            FineDue fineDue = _mapper.Map<FineDue>(request);

            await _fineDueRepository.AddAsync(fineDue);

            CreatedFineDueResponse response = _mapper.Map<CreatedFineDueResponse>(fineDue);
            return response;
        }
    }
}