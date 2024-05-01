using Application.Features.Books.Constants;
using Application.Features.Books.Rules;
using Application.Services.Repositories;
using Application.Services.ImageService; // Resim servisi eklendi
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

namespace Application.Features.Books.Commands.Update;

public class UpdateBookCommand : IRequest<UpdatedBookResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string BookTitle { get; set; }
    public int BookEdition { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public BookStatus Status { get; set; }
    public Guid PublisherId { get; set; }
    public int CategoryId { get; set; }
    public Guid LocationId { get; set; }
    public IFormFile? File { get; set; } // Resim dosyasý

    public string[] Roles => [Admin, Write, BooksOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBooks"];

    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, UpdatedBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;
        private readonly BookBusinessRules _bookBusinessRules;
        private readonly ImageServiceBase _imageService; // Resim hizmeti eklendi

        public UpdateBookCommandHandler(
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

        public async Task<UpdatedBookResponse> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            Book? book = await _bookRepository.GetAsync(b => b.Id == request.Id, cancellationToken: cancellationToken);
            await _bookBusinessRules.BookShouldExistWhenSelected(book);

            if (request.File != null)
            {
                // Yeni resmi yükle ve URL'sini al
                string newImageUrl = await _imageService.UploadAsync(request.File);

                // Eski resmi sil (varsa)
                if (!string.IsNullOrEmpty(book.ImageUrl))
                {
                    await _imageService.DeleteAsync(book.ImageUrl);
                }

                // Yeni resim URL'sini ayarla
                book.ImageUrl = newImageUrl;
            }

            // Diðer bilgileri güncelle
            _mapper.Map(request, book);
            await _bookRepository.UpdateAsync(book);

            UpdatedBookResponse response = _mapper.Map<UpdatedBookResponse>(book);
            response.ImageUrl = book.ImageUrl; // Yanýt için resim URL'sini ekle

            return response;
        }
    }
}