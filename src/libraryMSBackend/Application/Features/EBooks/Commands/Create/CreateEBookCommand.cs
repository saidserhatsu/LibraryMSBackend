using Application.Features.EBooks.Constants;
using Application.Features.EBooks.Rules;
using Application.Services.Repositories;
using Application.Services.PDFService; // PDF hizmeti eklendi
using Application.Services.ImageService; // Resim hizmeti eklendi
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using Microsoft.AspNetCore.Http; // IFormFile için
using static Application.Features.EBooks.Constants.EBooksOperationClaims;

namespace Application.Features.EBooks.Commands.Create;

public class CreateEBookCommand : IRequest<CreatedEBookResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string ISBNCode { get; set; }
    public string EBookTitle { get; set; }
    public string AuthorName { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public int CategoryId { get; set; }
    public IFormFile? File { get; set; } // PDF dosyasý için
    public IFormFile? ImageFile { get; set; } // Resim dosyasý için

    public string[] Roles => new[] { Admin, Write, EBooksOperationClaims.Create };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => new[] { "GetEBooks" };

    public class CreateEBookCommandHandler : IRequestHandler<CreateEBookCommand, CreatedEBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IEBookRepository _eBookRepository;
        private readonly EBookBusinessRules _eBookBusinessRules;
        private readonly PDFServiceBase _pdfService; // PDF hizmeti Constructor'a eklendi
        private readonly ImageServiceBase _imageService; // Resim hizmeti Constructor'a eklendi

        public CreateEBookCommandHandler(
            IMapper mapper,
            IEBookRepository eBookRepository,
            EBookBusinessRules _eBookBusinessRules,
            PDFServiceBase pdfService, // PDF hizmetini saklayýn
            ImageServiceBase imageService // Resim hizmetini saklayýn
        )
        {
            _mapper = mapper;
            _eBookRepository = eBookRepository;
            _eBookBusinessRules = _eBookBusinessRules;
            _pdfService = pdfService; // PDF hizmetini saklayýn
            _imageService = imageService; // Resim hizmetini saklayýn
        }

        public async Task<CreatedEBookResponse> Handle(CreateEBookCommand request, CancellationToken cancellationToken)
        {
            // EBook'u oluþturun
            var eBook = _mapper.Map<EBook>(request);

            // PDF dosyasý varsa, yükleyin ve EBook'a ekleyin
            if (request.File != null)
            {
                var pdfUrl = await _pdfService.UploadAsync(request.File); // PDF dosyasýný yükleyin
                eBook.FileUrl = pdfUrl; // PDF URL'sini ayarlayýn
            }

            // Resim dosyasý varsa, yükleyin ve EBook'a ekleyin
            if (request.ImageFile != null)
            {
                var imageUrl = await _imageService.UploadAsync(request.ImageFile); // Resmi yükleyin
                eBook.ImageUrl = imageUrl; // Resim URL'sini ayarlayýn
            }

            await _eBookRepository.AddAsync(eBook);

            var response = _mapper.Map<CreatedEBookResponse>(eBook);
            response.FileUrl = eBook.FileUrl; // Yanýta PDF URL'sini ekleyin
            response.ImageUrl = eBook.ImageUrl; // Yanýta resim URL'sini ekleyin

            return response;
        }
    }
}