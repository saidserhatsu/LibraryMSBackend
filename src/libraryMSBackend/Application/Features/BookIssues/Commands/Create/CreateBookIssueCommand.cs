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

namespace Application.Features.BookIssues.Commands.Create;

public class CreateBookIssueCommand : IRequest<CreatedBookIssueResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public Guid LibraryStaffId { get; set; }
    public DateTime ReturnDate { get; set; }

    public string[] Roles => [Admin, Write, BookIssuesOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBookIssues"];

    public class CreateBookIssueCommandHandler : IRequestHandler<CreateBookIssueCommand, CreatedBookIssueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookIssueRepository _bookIssueRepository;
        private readonly BookIssueBusinessRules _bookIssueBusinessRules;

        public CreateBookIssueCommandHandler(IMapper mapper, IBookIssueRepository bookIssueRepository,
                                         BookIssueBusinessRules bookIssueBusinessRules)
        {
            _mapper = mapper;
            _bookIssueRepository = bookIssueRepository;
            _bookIssueBusinessRules = bookIssueBusinessRules;
        }

        public async Task<CreatedBookIssueResponse> Handle(CreateBookIssueCommand request, CancellationToken cancellationToken)
        {
            BookIssue bookIssue = _mapper.Map<BookIssue>(request);

            await _bookIssueRepository.AddAsync(bookIssue);

            CreatedBookIssueResponse response = _mapper.Map<CreatedBookIssueResponse>(bookIssue);
            return response;
        }
    }
}