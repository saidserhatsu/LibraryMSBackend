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
    public IFormFile? File { get; set; } // Resim dosyasý eklendi

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
            _imageService = imageService; // Resim hizmetini saklayýn
        }

        public async Task<UpdatedEBookResponse> Handle(UpdateEBookCommand request, CancellationToken cancellationToken)
        {
            // EBook'u bulun
            var eBook = await _eBookRepository.GetAsync(
                eb => eb.Id == request.Id,
                cancellationToken: cancellationToken
            );
            await _eBookBusinessRules.EBookShouldExistWhenSelected(eBook);

            // Yeni resim dosyasý varsa, eski resmi silip yeni resmi yükleyin
            if (request.File != null)
            {
                string newImageUrl = await _imageService.UploadAsync(request.File); // Yeni resmi yükleyin

                // Eski bir resim varsa, silin
                if (!string.IsNullOrEmpty(eBook.ImageUrl))
                {
                    await _imageService.DeleteAsync(eBook.ImageUrl); // Eski resmi silin
                }

                // Yeni resim URL'sini ayarlayýn
                eBook.ImageUrl = newImageUrl;
            }

            // EBook'u güncelleyin
            _mapper.Map(request, eBook);
            await _eBookRepository.UpdateAsync(eBook!);

            // Yanýtý oluþturup döndürün
            var response = _mapper.Map<UpdatedEBookResponse>(eBook);
            response.ImageUrl = eBook.ImageUrl; // Yanýta resim URL'sini ekleyin

            return response;
        }
    }
}