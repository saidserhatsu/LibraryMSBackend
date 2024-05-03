using Application.Features.BookAuthors.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.BookAuthors.Constants.BookAuthorsOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.BookAuthors.Queries.GetList;

public class GetListBookAuthorQuery : IRequest<GetListResponse<GetListBookAuthorListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListBookAuthors({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetBookAuthors";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListBookAuthorQueryHandler : IRequestHandler<GetListBookAuthorQuery, GetListResponse<GetListBookAuthorListItemDto>>
    {
        private readonly IBookAuthorRepository _bookAuthorRepository;
        private readonly IMapper _mapper;

        public GetListBookAuthorQueryHandler(IBookAuthorRepository bookAuthorRepository, IMapper mapper)
        {
            _bookAuthorRepository = bookAuthorRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListBookAuthorListItemDto>> Handle(GetListBookAuthorQuery request, CancellationToken cancellationToken)
        {
            IPaginate<BookAuthor> bookAuthors = await _bookAuthorRepository.GetListAsync(
                include:ba=>ba.Include(ba=>ba.Author).Include(ba=>ba.Book),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListBookAuthorListItemDto> response = _mapper.Map<GetListResponse<GetListBookAuthorListItemDto>>(bookAuthors);
            return response;
        }
    }
}