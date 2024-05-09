using Application.Features.CatalogManagements.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.CatalogManagements.Constants.CatalogManagementsOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.CatalogManagements.Queries.GetList;

public class GetListCatalogManagementQuery : IRequest<GetListResponse<GetListCatalogManagementListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListCatalogManagements({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetCatalogManagements";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListCatalogManagementQueryHandler : IRequestHandler<GetListCatalogManagementQuery, GetListResponse<GetListCatalogManagementListItemDto>>
    {
        private readonly ICatalogManagementRepository _catalogManagementRepository;
        private readonly IMapper _mapper;

        public GetListCatalogManagementQueryHandler(ICatalogManagementRepository catalogManagementRepository, IMapper mapper)
        {
            _catalogManagementRepository = catalogManagementRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListCatalogManagementListItemDto>> Handle(GetListCatalogManagementQuery request, CancellationToken cancellationToken)
        {
            IPaginate<CatalogManagement> catalogManagements = await _catalogManagementRepository.GetListAsync(
                include: b => b.Include(b => b.Book).ThenInclude(b => b.BookAuthors).ThenInclude(b => b.Author)
                .Include(b => b.Material).Include(b => b.Magazine).Include(b => b.Catalog).Include(b => b.Book),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListCatalogManagementListItemDto> response = _mapper.Map<GetListResponse<GetListCatalogManagementListItemDto>>(catalogManagements);
            return response;
        }
    }
}