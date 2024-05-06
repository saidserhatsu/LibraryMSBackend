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

namespace Application.Features.BookIssues.Commands.Delete;

public class DeleteBookIssueCommand : IRequest<DeletedBookIssueResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => new[] { Admin, Write, BookIssuesOperationClaims.Delete };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => new[] { "GetBookIssues" };

    public class DeleteBookIssueCommandHandler : IRequestHandler<DeleteBookIssueCommand, DeletedBookIssueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookIssueRepository _bookIssueRepository;
        private readonly BookIssueBusinessRules _bookIssueBusinessRules;
        private readonly IBookRepository _bookRepository;

        public DeleteBookIssueCommandHandler(
            IMapper mapper,
            IBookIssueRepository bookIssueRepository,
            BookIssueBusinessRules bookIssueBusinessRules,
            IBookRepository bookRepository)
        {
            _mapper = mapper;
            _bookIssueRepository = bookIssueRepository;
            _bookIssueBusinessRules = bookIssueBusinessRules;
            _bookRepository = bookRepository;
        }

        public async Task<DeletedBookIssueResponse> Handle(DeleteBookIssueCommand request, CancellationToken cancellationToken)
        {
            // Ödünç verme kaydýný alýn
            BookIssue? bookIssue = await _bookIssueRepository.GetAsync(predicate: bi => bi.Id == request.Id, cancellationToken: cancellationToken);
            await _bookIssueBusinessRules.BookIssueShouldExistWhenSelected(bookIssue);

            // Kitabý alýn ve durumunu Available olarak güncelleyin
            var book = await _bookRepository.GetByIdAsync(bookIssue!.BookId);
            if (book.Status == BookStatus.Borrowed)
            {
                book.Status = BookStatus.Available; // Durumu Available yapýn
                await _bookRepository.UpdateAsync(book); // Kitap durumunu kaydedin
            }
            

            // Ödünç verme kaydýný silin
            await _bookIssueRepository.DeleteAsync(bookIssue);

            // Silme yanýtýný döndürün
            DeletedBookIssueResponse response = _mapper.Map<DeletedBookIssueResponse>(bookIssue);
            return response;
        }
    }
}