using Application.Features.FineDues.Constants;
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

namespace Application.Features.FineDues.Commands.Delete;

public class DeleteFineDueCommand : IRequest<DeletedFineDueResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, FineDuesOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetFineDues"];

    public class DeleteFineDueCommandHandler : IRequestHandler<DeleteFineDueCommand, DeletedFineDueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFineDueRepository _fineDueRepository;
        private readonly FineDueBusinessRules _fineDueBusinessRules;

        public DeleteFineDueCommandHandler(IMapper mapper, IFineDueRepository fineDueRepository,
                                         FineDueBusinessRules fineDueBusinessRules)
        {
            _mapper = mapper;
            _fineDueRepository = fineDueRepository;
            _fineDueBusinessRules = fineDueBusinessRules;
        }

        public async Task<DeletedFineDueResponse> Handle(DeleteFineDueCommand request, CancellationToken cancellationToken)
        {
            FineDue? fineDue = await _fineDueRepository.GetAsync(predicate: fd => fd.Id == request.Id, cancellationToken: cancellationToken);
            await _fineDueBusinessRules.FineDueShouldExistWhenSelected(fineDue);

            await _fineDueRepository.DeleteAsync(fineDue!);

            DeletedFineDueResponse response = _mapper.Map<DeletedFineDueResponse>(fineDue);
            return response;
        }
    }
}