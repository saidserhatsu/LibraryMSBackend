using Application.Features.Members.Constants;
using Application.Features.Members.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Members.Constants.MembersOperationClaims;
using Microsoft.AspNetCore.Http;
using Application.Services.ImageService;

namespace Application.Features.Members.Commands.Update;

public class UpdateMemberCommand : IRequest<UpdatedMemberResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public IFormFile? File { get; set; } // Resim dosyasý için
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool Subscribe { get; set; }


    public string[] Roles => [Admin, Write, MembersOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetMembers"];

    public class UpdateMemberCommandHandler : IRequestHandler<UpdateMemberCommand, UpdatedMemberResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMemberRepository _memberRepository;
        private readonly MemberBusinessRules _memberBusinessRules;
        private readonly ImageServiceBase _imageService; // Resim hizmeti eklendi


        public UpdateMemberCommandHandler(IMapper mapper, IMemberRepository memberRepository,
                                         MemberBusinessRules memberBusinessRules,ImageServiceBase imageService)
        {
            _mapper = mapper;
            _memberRepository = memberRepository;
            _memberBusinessRules = memberBusinessRules;
            _imageService = imageService;
        }

        public async Task<UpdatedMemberResponse> Handle(UpdateMemberCommand request, CancellationToken cancellationToken)
        {
            Member? member = await _memberRepository.GetAsync(predicate: m => m.Id == request.Id, cancellationToken: cancellationToken);
            await _memberBusinessRules.MemberShouldExistWhenSelected(member);
            if (request.File != null)
            {
                // Yeni resim yükleme
                string newImageUrl = await _imageService.UploadAsync(request.File);

                // Eski resim silme
                if (!string.IsNullOrEmpty(member.ImageUrl))
                {
                    await _imageService.DeleteAsync(member.ImageUrl);
                }

                // Yeni resim URL'sini güncelle
                member.ImageUrl = newImageUrl;
            }

            // Diðer bilgileri güncelle
            member = _mapper.Map(request, member);

            await _memberRepository.UpdateAsync(member!);
            await _memberBusinessRules.MemberNumberCanNotBeDuplicatedWhenUpdated(member);

            UpdatedMemberResponse response = _mapper.Map<UpdatedMemberResponse>(member);
            response.ImageUrl = member.ImageUrl; // Resim URL'sini yanýt olarak ekle
            return response;
        }
    }
}