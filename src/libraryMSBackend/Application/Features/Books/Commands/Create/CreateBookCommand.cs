using Application.Features.Books.Constants;
using Application.Features.Books.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using Domain.Enums;
using static Application.Features.Books.Constants.BooksOperationClaims;
using Application.Services.Categories;
using Application.Services.Locations;
using Application.Services.Publishers;
using Application.Features.Categories.Rules;

namespace Application.Features.Books.Commands.Create;

public class CreateBookCommand : IRequest<CreatedBookResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public BookStatus Status { get; set; }
    public Guid PublisherId { get; set; }
    public int CategoryId { get; set; }
    public Guid LocationId { get; set; }

    public string[] Roles => [Admin, Write, BooksOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBooks"];

    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, CreatedBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;
        private readonly BookBusinessRules _bookBusinessRules;

        public CreateBookCommandHandler(IMapper mapper, IBookRepository bookRepository,
                                         BookBusinessRules bookBusinessRules)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
            _bookBusinessRules = bookBusinessRules;
        }

        public async Task<CreatedBookResponse> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _bookBusinessRules.BookISBNCodeCanNotBeDuplicatedWhenInserted(request.ISBNCode);
            Book book = _mapper.Map<Book>(request);

            await _bookRepository.AddAsync(book);

            CreatedBookResponse response = _mapper.Map<CreatedBookResponse>(book);
            return response;
        }
    }
}