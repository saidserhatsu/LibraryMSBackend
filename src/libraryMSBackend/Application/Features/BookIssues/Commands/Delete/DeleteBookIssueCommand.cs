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
            // �d�n� verme kayd�n� al�n
            BookIssue? bookIssue = await _bookIssueRepository.GetAsync(predicate: bi => bi.Id == request.Id, cancellationToken: cancellationToken);
            await _bookIssueBusinessRules.BookIssueShouldExistWhenSelected(bookIssue);

            // Kitab� al�n ve durumunu Available olarak g�ncelleyin
            var book = await _bookRepository.GetByIdAsync(bookIssue!.BookId);
            if (book.Status == BookStatus.Borrowed)
            {
                book.Status = BookStatus.Available; // Durumu Available yap�n
                await _bookRepository.UpdateAsync(book); // Kitap durumunu kaydedin
            }
            

            // �d�n� verme kayd�n� silin
            await _bookIssueRepository.DeleteAsync(bookIssue);

            // Silme yan�t�n� d�nd�r�n
            DeletedBookIssueResponse response = _mapper.Map<DeletedBookIssueResponse>(bookIssue);
            return response;
        }
    }
}