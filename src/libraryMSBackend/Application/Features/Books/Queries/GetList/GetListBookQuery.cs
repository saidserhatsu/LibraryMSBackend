using Application.Features.Books.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.Books.Constants.BooksOperationClaims;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain.Enums;
using Application.Features.Locations.Queries.GetById;

namespace Application.Features.Books.Queries.GetList;

public class GetListBookQuery : IRequest<GetListResponse<GetListBookListItemDto>>, ISecuredRequest, ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListBooks({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetBooks";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListBookQueryHandler : IRequestHandler<GetListBookQuery, GetListResponse<GetListBookListItemDto>>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public GetListBookQueryHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListBookListItemDto>> Handle(GetListBookQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Book> books = await _bookRepository.GetListAsync(
                include: b => b.Include(b => b.Category).Include(b => b.Location).Include(b => b.Publisher)
                .Include(b=>b.BookAuthors).ThenInclude(b => b.Author),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListBookListItemDto> response = _mapper.Map<GetListResponse<GetListBookListItemDto>>(books);
            //var response = new GetListResponse<GetListBookListItemDto>
            //{
            //    Items = books.Items.Select(book =>
            //    {
            //        return new GetListBookListItemDto
            //        {
            //            Id = book.Id,
            //            ISBNCode = book.ISBNCode,
            //            BookTitle = book.BookTitle,
            //            BookEdition = book.BookEdition,
            //            ReleaseDate = book.ReleaseDate,
            //            Status = book.Status.ToString(),
            //            CategoryName = book.Category?.Name,
            //            PublisherName = book.Publisher?.Name,

            //            Location = new GetByIdLocationResponse
            //            {
            //                Id = book.Location?.Id ?? Guid.Empty,
            //                Name = book.Location?.Name,
            //                ShelfName = book.Location?.ShelfName
            //            },

            //        };
            //    }).ToList()
            //};
            return response;
        }
    }
}