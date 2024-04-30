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

namespace Application.Features.FineDues.Commands.Update;

public class UpdateFineDueCommand : IRequest<UpdatedFineDueResponse>,  ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public decimal FineTotal { get; set; }
    public Guid BookIssueId { get; set; }
    public DateTime FineDate { get; set; }

    public string[] Roles => [Admin, Write, FineDuesOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetFineDues"];

    public class UpdateFineDueCommandHandler : IRequestHandler<UpdateFineDueCommand, UpdatedFineDueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFineDueRepository _fineDueRepository;
        private readonly FineDueBusinessRules _fineDueBusinessRules;

        public UpdateFineDueCommandHandler(IMapper mapper, IFineDueRepository fineDueRepository,
                                         FineDueBusinessRules fineDueBusinessRules)
        {
            _mapper = mapper;
            _fineDueRepository = fineDueRepository;
            _fineDueBusinessRules = fineDueBusinessRules;
        }

        public async Task<UpdatedFineDueResponse> Handle(UpdateFineDueCommand request, CancellationToken cancellationToken)
        {
            FineDue? fineDue = await _fineDueRepository.GetAsync(predicate: fd => fd.Id == request.Id, cancellationToken: cancellationToken);
            await _fineDueBusinessRules.FineDueShouldExistWhenSelected(fineDue);
            fineDue = _mapper.Map(request, fineDue);

            await _fineDueRepository.UpdateAsync(fineDue!);

            UpdatedFineDueResponse response = _mapper.Map<UpdatedFineDueResponse>(fineDue);
            return response;
        }
    }
}