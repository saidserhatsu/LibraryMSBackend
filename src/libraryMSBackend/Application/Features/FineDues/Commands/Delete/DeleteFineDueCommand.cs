using System.Threading;
using Application.Features.FineDues.Constants;
using Application.Features.FineDues.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using static Application.Features.FineDues.Constants.FineDuesOperationClaims;

namespace Application.Features.FineDues.Commands.Delete;

public class DeleteFineDueCommand
    : IRequest<DeletedFineDueResponse>,
        ISecuredRequest,
        ICacheRemoverRequest,
        ILoggableRequest,
        ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => new[] { Admin, Write, FineDuesOperationClaims.Delete };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => new[] { "GetFineDues" };

    public class DeleteFineDueCommandHandler : IRequestHandler<DeleteFineDueCommand, DeletedFineDueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFineDueRepository _fineDueRepository;
        private readonly IBookIssueRepository _bookIssueRepository;
        private readonly IBookRepository _bookRepository; // Yeni kitap repository
        private readonly FineDueBusinessRules _fineDueBusinessRules;

        public DeleteFineDueCommandHandler(
            IMapper mapper,
            IFineDueRepository fineDueRepository,
            IBookIssueRepository bookIssueRepository,
            IBookRepository bookRepository, // Constructor'da ekleme
            FineDueBusinessRules fineDueBusinessRules
        )
        {
            _mapper = mapper;
            _fineDueRepository = fineDueRepository;
            _bookIssueRepository = bookIssueRepository;
            _bookRepository = bookRepository; // Constructor'da saklama
            _fineDueBusinessRules = fineDueBusinessRules;
        }

        public async Task<DeletedFineDueResponse> Handle(DeleteFineDueCommand request, CancellationToken cancellationToken)
        {
            // FineDue kayd�n� al�n
            var fineDue = await _fineDueRepository.GetAsync(fd => fd.Id == request.Id, cancellationToken: cancellationToken);

            await _fineDueBusinessRules.FineDueShouldExistWhenSelected(fineDue);

            // �li�kili BookIssue kayd�n� al ve kitab�n durumunu Available yap
            var bookIssue = await _bookIssueRepository.GetAsync(
                bi => bi.Id == fineDue.BookIssueId,
                cancellationToken: cancellationToken
            );

            if (bookIssue != null)
            {
                // �lgili kitab� al�n ve durumunu Available yap�n
                var book = await _bookRepository.GetByIdAsync(bookIssue.BookId);
                if (book != null)
                {
                    book.Status = BookStatus.Available; // Durumu Available yap�n
                    await _bookRepository.UpdateAsync(book); // Kitap durumunu kaydedin
                }

                await _bookIssueRepository.DeleteAsync(bookIssue); // BookIssue'yu silin
            }

            // FineDue'yu silin
            await _fineDueRepository.DeleteAsync(fineDue, cancellationToken: cancellationToken);

            // Cevap olu�tur ve d�nd�r
            var response = _mapper.Map<DeletedFineDueResponse>(fineDue);
            return response;
        }
    }
}