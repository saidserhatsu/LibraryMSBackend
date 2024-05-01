using Application.Features.Books.Constants;
using Application.Features.Books.Rules;
using Application.Services.Repositories;
using Application.Services.ImageService; // Resim hizmeti eklendi
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using Microsoft.AspNetCore.Http; // IFormFile için
using Domain.Enums;
using static Application.Features.Books.Constants.BooksOperationClaims;

namespace Application.Features.Books.Commands.Create;

public class CreateBookCommand : IRequest<CreatedBookResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public BookStatus Status { get; set; }
    public Guid PublisherId { get; set; }
    public int CategoryId { get; set; }
    public Guid LocationId { get; set; }
    public IFormFile? File { get; set; } // Resim dosyasý eklendi

    public string[] Roles => [Admin, Write, BooksOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBooks"];

    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, CreatedBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;
        private readonly BookBusinessRules _bookBusinessRules;
        private readonly ImageServiceBase _imageService; // Resim hizmeti eklendi

        public CreateBookCommandHandler(
            IMapper mapper,
            IBookRepository bookRepository,
            BookBusinessRules bookBusinessRules,
            ImageServiceBase imageService // Resim hizmeti eklendi
        )
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
            _bookBusinessRules = bookBusinessRules;
            _imageService = imageService;
        }

        public async Task<CreatedBookResponse> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            await _bookBusinessRules.BookISBNCodeCanNotBeDuplicatedWhenInserted(request.ISBNCode);

            // Kitabý oluþtur
            Book book = _mapper.Map<Book>(request);

            // Eðer resim dosyasý varsa, yükleyin
            if (request.File != null)
            {
                string imageUrl = await _imageService.UploadAsync(request.File);
                book.ImageUrl = imageUrl; // Resim URL'sini ayarla
            }

            await _bookRepository.AddAsync(book);

            CreatedBookResponse response = _mapper.Map<CreatedBookResponse>(book);
            response.ImageUrl = book.ImageUrl; // Yanýt olarak resim URL'sini ekle

            return response;
        }
    }
}