using Application.Features.BookIssues.Constants;
using Application.Features.BookIssues.Constants;
using Application.Features.BookIssues.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.BookIssues.Constants.BookIssuesOperationClaims;

namespace Application.Features.BookIssues.Commands.Delete;

public class DeleteBookIssueCommand : IRequest<DeletedBookIssueResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, BookIssuesOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBookIssues"];

    public class DeleteBookIssueCommandHandler : IRequestHandler<DeleteBookIssueCommand, DeletedBookIssueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookIssueRepository _bookIssueRepository;
        private readonly BookIssueBusinessRules _bookIssueBusinessRules;
        

        public DeleteBookIssueCommandHandler(IMapper mapper, IBookIssueRepository bookIssueRepository,
                                         BookIssueBusinessRules bookIssueBusinessRules)
        {
            _mapper = mapper;
            _bookIssueRepository = bookIssueRepository;
            _bookIssueBusinessRules = bookIssueBusinessRules;
        }

        public async Task<DeletedBookIssueResponse> Handle(DeleteBookIssueCommand request, CancellationToken cancellationToken)
        {
            BookIssue? bookIssue = await _bookIssueRepository.GetAsync(predicate: bi => bi.Id == request.Id, cancellationToken: cancellationToken);
            await _bookIssueBusinessRules.BookIssueShouldExistWhenSelected(bookIssue);

            await _bookIssueRepository.DeleteAsync(bookIssue!);

            DeletedBookIssueResponse response = _mapper.Map<DeletedBookIssueResponse>(bookIssue);
            return response;
        }
    }
}