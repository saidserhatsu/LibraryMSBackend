using Application.Features.BookIssues.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.BookIssues.Constants.BookIssuesOperationClaims;

namespace Application.Features.BookIssues.Queries.GetList;

public class GetListBookIssueQuery : IRequest<GetListResponse<GetListBookIssueListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListBookIssues({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetBookIssues";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListBookIssueQueryHandler : IRequestHandler<GetListBookIssueQuery, GetListResponse<GetListBookIssueListItemDto>>
    {
        private readonly IBookIssueRepository _bookIssueRepository;
        private readonly IMapper _mapper;

        public GetListBookIssueQueryHandler(IBookIssueRepository bookIssueRepository, IMapper mapper)
        {
            _bookIssueRepository = bookIssueRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListBookIssueListItemDto>> Handle(GetListBookIssueQuery request, CancellationToken cancellationToken)
        {
            IPaginate<BookIssue> bookIssues = await _bookIssueRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListBookIssueListItemDto> response = _mapper.Map<GetListResponse<GetListBookIssueListItemDto>>(bookIssues);
            return response;
        }
    }
}