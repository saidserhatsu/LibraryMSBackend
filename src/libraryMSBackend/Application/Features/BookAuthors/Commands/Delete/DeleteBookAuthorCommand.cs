using Application.Features.BookAuthors.Constants;
using Application.Features.BookAuthors.Constants;
using Application.Features.BookAuthors.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.BookAuthors.Constants.BookAuthorsOperationClaims;

namespace Application.Features.BookAuthors.Commands.Delete;

public class DeleteBookAuthorCommand : IRequest<DeletedBookAuthorResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, BookAuthorsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBookAuthors"];

    public class DeleteBookAuthorCommandHandler : IRequestHandler<DeleteBookAuthorCommand, DeletedBookAuthorResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookAuthorRepository _bookAuthorRepository;
        private readonly BookAuthorBusinessRules _bookAuthorBusinessRules;

        public DeleteBookAuthorCommandHandler(IMapper mapper, IBookAuthorRepository bookAuthorRepository,
                                         BookAuthorBusinessRules bookAuthorBusinessRules)
        {
            _mapper = mapper;
            _bookAuthorRepository = bookAuthorRepository;
            _bookAuthorBusinessRules = bookAuthorBusinessRules;
        }

        public async Task<DeletedBookAuthorResponse> Handle(DeleteBookAuthorCommand request, CancellationToken cancellationToken)
        {
            BookAuthor? bookAuthor = await _bookAuthorRepository.GetAsync(predicate: ba => ba.Id == request.Id, cancellationToken: cancellationToken);
            await _bookAuthorBusinessRules.BookAuthorShouldExistWhenSelected(bookAuthor);

            await _bookAuthorRepository.DeleteAsync(bookAuthor!);

            DeletedBookAuthorResponse response = _mapper.Map<DeletedBookAuthorResponse>(bookAuthor);
            return response;
        }
    }
}