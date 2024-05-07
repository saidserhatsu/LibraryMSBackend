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
using Microsoft.AspNetCore.Http; // IFormFile i�in
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
    public IFormFile? PdfFile { get; set; } // PDF dosyas� i�in
    public IFormFile? ImageFile { get; set; } // Resim dosyas� i�in

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
        _pdfService = pdfService; // PDF hizmeti Constructor'da saklan�yor
        _imageService = imageService; // Resim hizmeti Constructor'da saklan�yor
    }

    public async Task<UpdatedEBookResponse> Handle(UpdateEBookCommand request, CancellationToken cancellationToken)
    {
        var eBook = await _eBookRepository.GetAsync(
            eb => eb.Id == request.Id,
            cancellationToken: cancellationToken
        );

        await _eBookBusinessRules.EBookShouldExistWhenSelected(eBook);
        // Yeni �mage  varsa y�kleyin ve gerekirse eski dosyay� sil
        if (request.ImageFile != null) // �mage dosyas� i�in kontrol
        {
            // Yeni resmi y�kle ve URL'sini al
            string newImageUrl = await _imageService.UploadAsync(request.ImageFile);

            // Eski resmi sil (varsa)
            if (!string.IsNullOrEmpty(eBook.ImageUrl))
            {
                await _imageService.DeleteAsync(eBook.ImageUrl);
            }

            // Yeni resim URL'sini ayarla
            eBook.ImageUrl = newImageUrl;
        }

        // Yeni PDF dosyas� varsa, y�kleyin ve gerekirse eski dosyay� sil
        if (request.PdfFile != null) // PDF dosyas� i�in kontrol
        {
            var newPdfUrl = await _pdfService.UploadAsync(request.PdfFile); // Yeni PDF dosyas�n� y�kleyin

            if (!string.IsNullOrEmpty(eBook.FileUrl)) // E�er eski PDF URL'si varsa
            {
                await _pdfService.DeleteAsync(eBook.FileUrl); // Eski PDF'yi silin
            }

            eBook.FileUrl = newPdfUrl; // Yeni PDF URL'sini ayarlay�n
        }

        // G�ncellenen EBook
        _mapper.Map(request, eBook); // Di�er alanlar� g�ncelleyin
        await _eBookRepository.UpdateAsync(eBook); // EBook'u g�ncelleyin

        var response = _mapper.Map<UpdatedEBookResponse>(eBook); // Yan�t� olu�turun
        response.FileUrl = eBook.FileUrl; // PDF URL'sini yan�ta ekleyin
        response.ImageUrl = eBook.ImageUrl; // Resim URL'sini yan�ta ekleyin

        return response; // Yan�t� d�nd�r�n
    }
}