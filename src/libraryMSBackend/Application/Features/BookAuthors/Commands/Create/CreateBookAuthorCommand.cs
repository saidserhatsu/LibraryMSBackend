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

namespace Application.Features.BookAuthors.Commands.Create;

public class CreateBookAuthorCommand : IRequest<CreatedBookAuthorResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid BookId { get; set; }
    public Guid AuthorId { get; set; }

    public string[] Roles => [Admin, Write, BookAuthorsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBookAuthors"];

    public class CreateBookAuthorCommandHandler : IRequestHandler<CreateBookAuthorCommand, CreatedBookAuthorResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookAuthorRepository _bookAuthorRepository;
        private readonly BookAuthorBusinessRules _bookAuthorBusinessRules;

        public CreateBookAuthorCommandHandler(IMapper mapper, IBookAuthorRepository bookAuthorRepository,
                                         BookAuthorBusinessRules bookAuthorBusinessRules)
        {
            _mapper = mapper;
            _bookAuthorRepository = bookAuthorRepository;
            _bookAuthorBusinessRules = bookAuthorBusinessRules;
        }

        public async Task<CreatedBookAuthorResponse> Handle(CreateBookAuthorCommand request, CancellationToken cancellationToken)
        {
            BookAuthor bookAuthor = _mapper.Map<BookAuthor>(request);

            await _bookAuthorRepository.AddAsync(bookAuthor);

            CreatedBookAuthorResponse response = _mapper.Map<CreatedBookAuthorResponse>(bookAuthor);
            return response;
        }
    }
}