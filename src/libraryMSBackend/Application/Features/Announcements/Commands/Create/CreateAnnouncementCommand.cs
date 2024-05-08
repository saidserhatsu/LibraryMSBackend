using Application.Features.Announcements.Constants;
using Application.Features.Announcements.Rules;
using Application.Services.ImageService; // Resim hizmeti
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http; // IFormFile için
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using static Application.Features.Announcements.Constants.AnnouncementsOperationClaims;

namespace Application.Features.Announcements.Commands.Create;

public class CreateAnnouncementCommand
    : IRequest<CreatedAnnouncementResponse>,
        ISecuredRequest,
        ICacheRemoverRequest,
        ILoggableRequest,
        ITransactionalRequest
{
    public string Title { get; set; }
    public string Content { get; set; }
    public AnnouncementTag Tag { get; set; }
    public IFormFile? File { get; set; } // Resim dosyasý eklenmiþ
    public string[] Roles => new[] { Admin, Write, AnnouncementsOperationClaims.Create };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => new[] { "GetAnnouncements" };

    public class CreateAnnouncementCommandHandler : IRequestHandler<CreateAnnouncementCommand, CreatedAnnouncementResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAnnouncementRepository _announcementRepository;
        private readonly AnnouncementBusinessRules _announcementBusinessRules;
        private readonly ImageServiceBase _imageService; // Resim hizmeti eklendi

        public CreateAnnouncementCommandHandler(
            IMapper mapper,
            IAnnouncementRepository announcementRepository,
            AnnouncementBusinessRules announcementBusinessRules,
            ImageServiceBase imageService // Resim hizmeti Constructor'a eklendi
        )
        {
            _mapper = mapper;
            _announcementRepository = announcementRepository;
            _announcementBusinessRules = announcementBusinessRules;
            _imageService = imageService;
        }

        public async Task<CreatedAnnouncementResponse> Handle(
            CreateAnnouncementCommand request,
            CancellationToken cancellationToken
        )
        {
            // Duyuruyu oluþtur
            var announcement = _mapper.Map<Announcement>(request);

            // Resim dosyasý varsa, yükleyin ve duyuruya ekleyin
            if (request.File != null)
            {
                var imageUrl = await _imageService.UploadAsync(request.File); // Resmi yükleyin
                announcement.ImageUrl = imageUrl; // Resim URL'sini duyuruya ekleyin
            }

            // Duyuruyu veritabanýna ekleyin
            await _announcementRepository.AddAsync(announcement);

            // Yanýtý oluþturun ve döndürün
            var response = _mapper.Map<CreatedAnnouncementResponse>(announcement);
            response.ImageUrl = announcement.ImageUrl; // Yanýta resim URL'sini ekleyin
            return response;
        }
    }
}
