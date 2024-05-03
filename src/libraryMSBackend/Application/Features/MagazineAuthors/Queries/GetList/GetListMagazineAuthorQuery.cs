using Application.Features.MagazineAuthors.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.MagazineAuthors.Constants.MagazineAuthorsOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.MagazineAuthors.Queries.GetList;

public class GetListMagazineAuthorQuery : IRequest<GetListResponse<GetListMagazineAuthorListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListMagazineAuthors({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetMagazineAuthors";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListMagazineAuthorQueryHandler : IRequestHandler<GetListMagazineAuthorQuery, GetListResponse<GetListMagazineAuthorListItemDto>>
    {
        private readonly IMagazineAuthorRepository _magazineAuthorRepository;
        private readonly IMapper _mapper;

        public GetListMagazineAuthorQueryHandler(IMagazineAuthorRepository magazineAuthorRepository, IMapper mapper)
        {
            _magazineAuthorRepository = magazineAuthorRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListMagazineAuthorListItemDto>> Handle(GetListMagazineAuthorQuery request, CancellationToken cancellationToken)
        {
            IPaginate<MagazineAuthor> magazineAuthors = await _magazineAuthorRepository.GetListAsync(
                include:ma=>ma.Include(ma=>ma.Author).Include(ma=>ma.Magazine),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListMagazineAuthorListItemDto> response = _mapper.Map<GetListResponse<GetListMagazineAuthorListItemDto>>(magazineAuthors);
            return response;
        }
    }
}