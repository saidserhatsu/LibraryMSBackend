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
    public string FileUrl { get; set; }
    public IFormFile? File { get; set; } // Resim dosyas� eklendi

    public string[] Roles => new[] { Admin, Write, EBooksOperationClaims.Update };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => new[] { "GetEBooks" };

    public class UpdateEBookCommandHandler : IRequestHandler<UpdateEBookCommand, UpdatedEBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IEBookRepository _eBookRepository;
        private readonly EBookBusinessRules _eBookBusinessRules;
        private readonly ImageServiceBase _imageService; // Resim hizmeti eklendi

        public UpdateEBookCommandHandler(
            IMapper mapper,
            IEBookRepository eBookRepository,
            EBookBusinessRules eBookBusinessRules,
            ImageServiceBase imageService // Resim hizmeti Constructor'a eklendi
        )
        {
            _mapper = mapper;
            _eBookRepository = eBookRepository;
            _eBookBusinessRules = eBookBusinessRules;
            _imageService = imageService; // Resim hizmetini saklay�n
        }

        public async Task<UpdatedEBookResponse> Handle(UpdateEBookCommand request, CancellationToken cancellationToken)
        {
            // EBook'u bulun
            var eBook = await _eBookRepository.GetAsync(
                eb => eb.Id == request.Id,
                cancellationToken: cancellationToken
            );
            await _eBookBusinessRules.EBookShouldExistWhenSelected(eBook);

            // Yeni resim dosyas� varsa, eski resmi silip yeni resmi y�kleyin
            if (request.File != null)
            {
                string newImageUrl = await _imageService.UploadAsync(request.File); // Yeni resmi y�kleyin

                // Eski bir resim varsa, silin
                if (!string.IsNullOrEmpty(eBook.ImageUrl))
                {
                    await _imageService.DeleteAsync(eBook.ImageUrl); // Eski resmi silin
                }

                // Yeni resim URL'sini ayarlay�n
                eBook.ImageUrl = newImageUrl;
            }

            // EBook'u g�ncelleyin
            _mapper.Map(request, eBook);
            await _eBookRepository.UpdateAsync(eBook!);

            // Yan�t� olu�turup d�nd�r�n
            var response = _mapper.Map<UpdatedEBookResponse>(eBook);
            response.ImageUrl = eBook.ImageUrl; // Yan�ta resim URL'sini ekleyin

            return response;
        }
    }
}