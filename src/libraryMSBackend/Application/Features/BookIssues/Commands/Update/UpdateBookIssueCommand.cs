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

namespace Application.Features.BookIssues.Commands.Update;

public class UpdateBookIssueCommand : IRequest<UpdatedBookIssueResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public Guid LibraryStaffId { get; set; }
    public DateTime ReturnDate { get; set; }

    public string[] Roles => [Admin, Write, BookIssuesOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBookIssues"];

    public class UpdateBookIssueCommandHandler : IRequestHandler<UpdateBookIssueCommand, UpdatedBookIssueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookIssueRepository _bookIssueRepository;
        private readonly BookIssueBusinessRules _bookIssueBusinessRules;

        public UpdateBookIssueCommandHandler(IMapper mapper, IBookIssueRepository bookIssueRepository,
                                         BookIssueBusinessRules bookIssueBusinessRules)
        {
            _mapper = mapper;
            _bookIssueRepository = bookIssueRepository;
            _bookIssueBusinessRules = bookIssueBusinessRules;
        }

        public async Task<UpdatedBookIssueResponse> Handle(UpdateBookIssueCommand request, CancellationToken cancellationToken)
        {
            BookIssue? bookIssue = await _bookIssueRepository.GetAsync(predicate: bi => bi.Id == request.Id, cancellationToken: cancellationToken);
            await _bookIssueBusinessRules.BookIssueShouldExistWhenSelected(bookIssue);
            bookIssue = _mapper.Map(request, bookIssue);

            await _bookIssueRepository.UpdateAsync(bookIssue!);

            UpdatedBookIssueResponse response = _mapper.Map<UpdatedBookIssueResponse>(bookIssue);
            return response;
        }
    }
}