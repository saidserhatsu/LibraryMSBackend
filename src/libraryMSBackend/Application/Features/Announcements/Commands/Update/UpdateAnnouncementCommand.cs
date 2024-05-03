using Application.Features.Announcements.Constants;
using Application.Features.Announcements.Rules;
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
using static Application.Features.Announcements.Constants.AnnouncementsOperationClaims;
using Domain.Enums;

namespace Application.Features.Announcements.Commands.Update;

public class UpdateAnnouncementCommand : IRequest<UpdatedAnnouncementResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public AnnouncementTag Tag { get; set; }
    public IFormFile? File { get; set; } // Resim dosyas� eklendi

    public string[] Roles => new[] { Admin, Write, AnnouncementsOperationClaims.Update };

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => new[] { "GetAnnouncements" };

    public class UpdateAnnouncementCommandHandler : IRequestHandler<UpdateAnnouncementCommand, UpdatedAnnouncementResponse>
    {
        private readonly IMapper _mapper;
        private readonly IAnnouncementRepository _announcementRepository;
        private readonly AnnouncementBusinessRules _announcementBusinessRules;
        private readonly ImageServiceBase _imageService; // Resim hizmeti eklendi

        public UpdateAnnouncementCommandHandler(
            IMapper mapper,
            IAnnouncementRepository announcementRepository,
            AnnouncementBusinessRules announcementBusinessRules,
            ImageServiceBase imageService // Resim servisi eklendi
        )
        {
            _mapper = mapper;
            _announcementRepository = announcementRepository;
            _announcementBusinessRules = announcementBusinessRules;
            _imageService = imageService; // Constructor'a ekleme
        }

        public async Task<UpdatedAnnouncementResponse> Handle(UpdateAnnouncementCommand request, CancellationToken cancellationToken)
        {
            // Duyuruyu bulun
            var announcement = await _announcementRepository.GetAsync(
                a => a.Id == request.Id,
                cancellationToken: cancellationToken
            );
            await _announcementBusinessRules.AnnouncementShouldExistWhenSelected(announcement);

            // Yeni resim dosyas� varsa, eski resmi silip yeni resmi y�kleyin
            if (request.File != null)
            {
                string newImageUrl = await _imageService.UploadAsync(request.File); // Yeni resmi y�kleyin

                // E�er eski bir resim varsa, silin
                if (!string.IsNullOrEmpty(announcement.ImageUrl))
                {
                    await _imageService.DeleteAsync(announcement.ImageUrl); // Eski resmi silin
                }

                announcement.ImageUrl = newImageUrl; // Yeni resim URL'sini ayarlay�n
            }

            // Duyuruyu g�ncelleyin
            _mapper.Map(request, announcement);
            await _announcementRepository.UpdateAsync(announcement!);

            // Yan�t� olu�turup d�nd�r�n
            var response = _mapper.Map<UpdatedAnnouncementResponse>(announcement);
            response.ImageUrl = announcement.ImageUrl; // Yan�ta resim URL'sini ekleyin

            return response;
        }
    }
}