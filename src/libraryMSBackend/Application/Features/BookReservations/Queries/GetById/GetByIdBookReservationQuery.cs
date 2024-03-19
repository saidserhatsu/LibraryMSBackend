using Application.Features.BookReservations.Constants;
using Application.Features.BookReservations.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.BookReservations.Constants.BookReservationsOperationClaims;

namespace Application.Features.BookReservations.Queries.GetById;

public class GetByIdBookReservationQuery : IRequest<GetByIdBookReservationResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdBookReservationQueryHandler : IRequestHandler<GetByIdBookReservationQuery, GetByIdBookReservationResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookReservationRepository _bookReservationRepository;
        private readonly BookReservationBusinessRules _bookReservationBusinessRules;

        public GetByIdBookReservationQueryHandler(IMapper mapper, IBookReservationRepository bookReservationRepository, BookReservationBusinessRules bookReservationBusinessRules)
        {
            _mapper = mapper;
            _bookReservationRepository = bookReservationRepository;
            _bookReservationBusinessRules = bookReservationBusinessRules;
        }

        public async Task<GetByIdBookReservationResponse> Handle(GetByIdBookReservationQuery request, CancellationToken cancellationToken)
        {
            BookReservation? bookReservation = await _bookReservationRepository.GetAsync(predicate: br => br.Id == request.Id, cancellationToken: cancellationToken);
            await _bookReservationBusinessRules.BookReservationShouldExistWhenSelected(bookReservation);

            GetByIdBookReservationResponse response = _mapper.Map<GetByIdBookReservationResponse>(bookReservation);
            return response;
        }
    }
}