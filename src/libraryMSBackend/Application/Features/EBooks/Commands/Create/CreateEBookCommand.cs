using Application.Features.EBooks.Constants;
using Application.Features.EBooks.Rules;
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
    public string FileUrl { get; set; } // EBook dosyasý URL'si
    public IFormFile? File { get; set; } // Resim dosyasý eklendi

    public string[] Roles => new[] { Admin, Write, EBooksOperationClaims.Create };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => new[] { "GetEBooks" };

    public class CreateEBookCommandHandler : IRequestHandler<CreateEBookCommand, CreatedEBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IEBookRepository _eBookRepository;
        private readonly EBookBusinessRules _eBookBusinessRules;
        private readonly ImageServiceBase _imageService; // Resim hizmeti Constructor'a eklendi

        public CreateEBookCommandHandler(
            IMapper mapper,
            IEBookRepository eBookRepository,
            EBookBusinessRules eBookBusinessRules,
            ImageServiceBase imageService // Constructor'a resim hizmeti eklendi
        )
        {
            _mapper = mapper;
            _eBookRepository = eBookRepository;
            _eBookBusinessRules = eBookBusinessRules;
            _imageService = imageService; // Resim hizmetini saklayýn
        }

        public async Task<CreatedEBookResponse> Handle(CreateEBookCommand request, CancellationToken cancellationToken)
        {
            // EBook'u oluþturun
            var eBook = _mapper.Map<EBook>(request);

            // Resim dosyasý varsa, yükleyin ve EBook'a ekleyin
            if (request.File != null)
            {
                var imageUrl = await _imageService.UploadAsync(request.File); // Resmi yükleyin
                eBook.ImageUrl = imageUrl; // Resim URL'sini ayarlayýn
            }

            await _eBookRepository.AddAsync(eBook);

            var response = _mapper.Map<CreatedEBookResponse>(eBook);
            response.ImageUrl = eBook.ImageUrl; // Yanýta resim URL'sini ekleyin

            return response;
        }
    }
}