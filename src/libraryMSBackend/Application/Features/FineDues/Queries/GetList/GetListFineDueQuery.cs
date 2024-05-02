using Application.Features.FineDues.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.FineDues.Constants.FineDuesOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.FineDues.Queries.GetList;

public class GetListFineDueQuery : IRequest<GetListResponse<GetListFineDueListItemDto>>,  ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListFineDues({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetFineDues";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListFineDueQueryHandler : IRequestHandler<GetListFineDueQuery, GetListResponse<GetListFineDueListItemDto>>
    {
        private readonly IFineDueRepository _fineDueRepository;
        private readonly IMapper _mapper;

        public GetListFineDueQueryHandler(IFineDueRepository fineDueRepository, IMapper mapper)
        {
            _fineDueRepository = fineDueRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListFineDueListItemDto>> Handle(GetListFineDueQuery request, CancellationToken cancellationToken)
        {
            IPaginate<FineDue> fineDues = await _fineDueRepository.GetListAsync(
                include: bi => bi.Include(bi => bi.BookIssue).ThenInclude(bi=>bi.Book)
                 .Include(bi => bi.BookIssue).ThenInclude(bi => bi.Member),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListFineDueListItemDto> response = _mapper.Map<GetListResponse<GetListFineDueListItemDto>>(fineDues);
            return response;
        }
    }
}