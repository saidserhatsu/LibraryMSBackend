using Application.Features.FavoriteBooks.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.FavoriteBooks.Constants.FavoriteBooksOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.FavoriteBooks.Queries.GetList;

public class GetListFavoriteBookQuery : IRequest<GetListResponse<GetListFavoriteBookListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListFavoriteBooks({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetFavoriteBooks";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListFavoriteBookQueryHandler : IRequestHandler<GetListFavoriteBookQuery, GetListResponse<GetListFavoriteBookListItemDto>>
    {
        private readonly IFavoriteBookRepository _favoriteBookRepository;
        private readonly IMapper _mapper;

        public GetListFavoriteBookQueryHandler(IFavoriteBookRepository favoriteBookRepository, IMapper mapper)
        {
            _favoriteBookRepository = favoriteBookRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListFavoriteBookListItemDto>> Handle(GetListFavoriteBookQuery request, CancellationToken cancellationToken)
        {
            IPaginate<FavoriteBook> favoriteBooks = await _favoriteBookRepository.GetListAsync(
                include:fb=>fb.Include(fb=>fb.Book).Include(fb=>fb.Member),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListFavoriteBookListItemDto> response = _mapper.Map<GetListResponse<GetListFavoriteBookListItemDto>>(favoriteBooks);
            return response;
        }
    }
}