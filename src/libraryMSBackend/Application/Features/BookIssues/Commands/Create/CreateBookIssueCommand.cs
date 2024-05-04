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
using Domain.Enums;

namespace Application.Features.BookIssues.Commands.Create;

public class CreateBookIssueCommand : IRequest<CreatedBookIssueResponse> , ISecuredRequest,  ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
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
        private readonly IBookRepository _bookRepository;

        public CreateBookIssueCommandHandler(IMapper mapper, IBookIssueRepository bookIssueRepository,
                                         BookIssueBusinessRules bookIssueBusinessRules,IBookRepository bookRepository)
        {
            _mapper = mapper;
            _bookIssueRepository = bookIssueRepository;
            _bookIssueBusinessRules = bookIssueBusinessRules;
            _bookRepository = bookRepository;
        }

        public async Task<CreatedBookIssueResponse> Handle(CreateBookIssueCommand request, CancellationToken cancellationToken)
        {
            await _bookIssueBusinessRules.CheckIfMemberHasExceededBookLimit(request.MemberId);

            await _bookIssueBusinessRules.EnsureBookIsAvailable(request.BookId);

            BookIssue bookIssue = _mapper.Map<BookIssue>(request);

            // Book is being issued, so set the status to Borrowed
            var book = await _bookRepository.GetByIdAsync(request.BookId);
            if (book.Status==BookStatus.Available)
            {
            book.Status = BookStatus.Borrowed; // Change the status to Borrowed
            await _bookRepository.UpdateAsync(book); // Save the status change
            }
            else
            {
                throw new Exception("Bu kitap rezerve edilmiþ");
            }

            await _bookIssueRepository.AddAsync(bookIssue);

            CreatedBookIssueResponse response = _mapper.Map<CreatedBookIssueResponse>(bookIssue);
            return response;
        }
    }
}