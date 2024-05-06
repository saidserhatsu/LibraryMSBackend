using Application.Features.BookReservations.Constants;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using MediatR;
using static Application.Features.BookReservations.Constants.BookReservationsOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.BookReservations.Queries.GetList;

public class GetListBookReservationQuery : IRequest<GetListResponse<GetListBookReservationListItemDto>>,  ICachableRequest
{
    public PageRequest PageRequest { get; set; }

    public string[] Roles => [Admin, Read];

    public bool BypassCache { get; }
    public string? CacheKey => $"GetListBookReservations({PageRequest.PageIndex},{PageRequest.PageSize})";
    public string? CacheGroupKey => "GetBookReservations";
    public TimeSpan? SlidingExpiration { get; }

    public class GetListBookReservationQueryHandler : IRequestHandler<GetListBookReservationQuery, GetListResponse<GetListBookReservationListItemDto>>
    {
        private readonly IBookReservationRepository _bookReservationRepository;
        private readonly IMapper _mapper;

        public GetListBookReservationQueryHandler(IBookReservationRepository bookReservationRepository, IMapper mapper)
        {
            _bookReservationRepository = bookReservationRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListBookReservationListItemDto>> Handle(GetListBookReservationQuery request, CancellationToken cancellationToken)
        {
            IPaginate<BookReservation> bookReservations = await _bookReservationRepository.GetListAsync(
                include: bi => bi.Include(bi=>bi.Book).Include(bi=>bi.Member),
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize, 
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListBookReservationListItemDto> response = _mapper.Map<GetListResponse<GetListBookReservationListItemDto>>(bookReservations);
            return response;
        }
    }
}