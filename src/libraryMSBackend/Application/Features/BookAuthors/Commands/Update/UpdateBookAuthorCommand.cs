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

namespace Application.Features.BookAuthors.Commands.Update;

public class UpdateBookAuthorCommand : IRequest<UpdatedBookAuthorResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid AuthorId { get; set; }

    public string[] Roles => [Admin, Write, BookAuthorsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBookAuthors"];

    public class UpdateBookAuthorCommandHandler : IRequestHandler<UpdateBookAuthorCommand, UpdatedBookAuthorResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookAuthorRepository _bookAuthorRepository;
        private readonly BookAuthorBusinessRules _bookAuthorBusinessRules;

        public UpdateBookAuthorCommandHandler(IMapper mapper, IBookAuthorRepository bookAuthorRepository,
                                         BookAuthorBusinessRules bookAuthorBusinessRules)
        {
            _mapper = mapper;
            _bookAuthorRepository = bookAuthorRepository;
            _bookAuthorBusinessRules = bookAuthorBusinessRules;
        }

        public async Task<UpdatedBookAuthorResponse> Handle(UpdateBookAuthorCommand request, CancellationToken cancellationToken)
        {
            BookAuthor? bookAuthor = await _bookAuthorRepository.GetAsync(predicate: ba => ba.Id == request.Id, cancellationToken: cancellationToken);
            await _bookAuthorBusinessRules.BookAuthorShouldExistWhenSelected(bookAuthor);
            bookAuthor = _mapper.Map(request, bookAuthor);

            await _bookAuthorRepository.UpdateAsync(bookAuthor!);

            UpdatedBookAuthorResponse response = _mapper.Map<UpdatedBookAuthorResponse>(bookAuthor);
            return response;
        }
    }
}