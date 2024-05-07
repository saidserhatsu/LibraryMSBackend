using Application.Features.EBooks.Constants;
using Application.Features.EBooks.Rules;
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
using static Application.Features.EBooks.Constants.EBooksOperationClaims;
using Application.Services.PDFService;

namespace Application.Features.EBooks.Commands.Update;

public class UpdateEBookCommand : IRequest<UpdatedEBookResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public string ISBNCode { get; set; }
    public string EBookTitle { get; set; }
    public string AuthorName { get; set; }
    public int ReleaseDate { get; set; }
    public int PageCount { get; set; }
    public int CategoryId { get; set; }
    public IFormFile? PdfFile { get; set; } // PDF dosyasý için
    public IFormFile? ImageFile { get; set; } // Resim dosyasý için

    public string[] Roles => new[] { "Admin", "Write", "EBooksOperationClaims.Update" };
    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => new[] { "GetEBooks" };
}


public class UpdateEBookCommandHandler : IRequestHandler<UpdateEBookCommand, UpdatedEBookResponse>
{
    private readonly IMapper _mapper;
    private readonly IEBookRepository _eBookRepository;
    private readonly EBookBusinessRules _eBookBusinessRules;
    private readonly PDFServiceBase _pdfService; // PDF hizmeti eklendi
    private readonly ImageServiceBase _imageService; // Resim hizmeti de var

    public UpdateEBookCommandHandler(
        IMapper mapper,
        IEBookRepository eBookRepository,
        EBookBusinessRules eBookBusinessRules,
        PDFServiceBase pdfService, // PDF hizmeti Constructor'a eklendi
        ImageServiceBase imageService // Resim hizmeti Constructor'a eklendi
    )
    {
        _mapper = mapper;
        _eBookRepository = eBookRepository;
        _eBookBusinessRules = eBookBusinessRules;
        _pdfService = pdfService; // PDF hizmeti Constructor'da saklanýyor
        _imageService = imageService; // Resim hizmeti Constructor'da saklanýyor
    }

    public async Task<UpdatedEBookResponse> Handle(UpdateEBookCommand request, CancellationToken cancellationToken)
    {
        var eBook = await _eBookRepository.GetAsync(
            eb => eb.Id == request.Id,
            cancellationToken: cancellationToken
        );

        await _eBookBusinessRules.EBookShouldExistWhenSelected(eBook);
        // Yeni Ýmage  varsa yükleyin ve gerekirse eski dosyayý sil
        if (request.ImageFile != null) // Ýmage dosyasý için kontrol
        {
            // Yeni resmi yükle ve URL'sini al
            string newImageUrl = await _imageService.UploadAsync(request.ImageFile);

            // Eski resmi sil (varsa)
            if (!string.IsNullOrEmpty(eBook.ImageUrl))
            {
                await _imageService.DeleteAsync(eBook.ImageUrl);
            }

            // Yeni resim URL'sini ayarla
            eBook.ImageUrl = newImageUrl;
        }

        // Yeni PDF dosyasý varsa, yükleyin ve gerekirse eski dosyayý sil
        if (request.PdfFile != null) // PDF dosyasý için kontrol
        {
            var newPdfUrl = await _pdfService.UploadAsync(request.PdfFile); // Yeni PDF dosyasýný yükleyin

            if (!string.IsNullOrEmpty(eBook.FileUrl)) // Eðer eski PDF URL'si varsa
            {
                await _pdfService.DeleteAsync(eBook.FileUrl); // Eski PDF'yi silin
            }

            eBook.FileUrl = newPdfUrl; // Yeni PDF URL'sini ayarlayýn
        }

        // Güncellenen EBook
        _mapper.Map(request, eBook); // Diðer alanlarý güncelleyin
        await _eBookRepository.UpdateAsync(eBook); // EBook'u güncelleyin

        var response = _mapper.Map<UpdatedEBookResponse>(eBook); // Yanýtý oluþturun
        response.FileUrl = eBook.FileUrl; // PDF URL'sini yanýta ekleyin
        response.ImageUrl = eBook.ImageUrl; // Resim URL'sini yanýta ekleyin

        return response; // Yanýtý döndürün
    }
}