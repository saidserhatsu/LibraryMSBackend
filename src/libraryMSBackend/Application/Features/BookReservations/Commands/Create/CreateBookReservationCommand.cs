using Application.Features.BookReservations.Constants;
using Application.Features.BookReservations.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.BookReservations.Constants.BookReservationsOperationClaims;

namespace Application.Features.BookReservations.Commands.Create;

public class CreateBookReservationCommand : IRequest<CreatedBookReservationResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public DateTime NearestAvailableDate { get; set; }
    public DateTime RequestDate { get; set; }

    public string[] Roles => [Admin, Write, BookReservationsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBookReservations"];

    public class CreateBookReservationCommandHandler : IRequestHandler<CreateBookReservationCommand, CreatedBookReservationResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookReservationRepository _bookReservationRepository;
        private readonly BookReservationBusinessRules _bookReservationBusinessRules;

        public CreateBookReservationCommandHandler(IMapper mapper, IBookReservationRepository bookReservationRepository,
                                         BookReservationBusinessRules bookReservationBusinessRules)
        {
            _mapper = mapper;
            _bookReservationRepository = bookReservationRepository;
            _bookReservationBusinessRules = bookReservationBusinessRules;
        }

        public async Task<CreatedBookReservationResponse> Handle(CreateBookReservationCommand request, CancellationToken cancellationToken)
        {
            BookReservation bookReservation = _mapper.Map<BookReservation>(request);

            await _bookReservationRepository.AddAsync(bookReservation);

            CreatedBookReservationResponse response = _mapper.Map<CreatedBookReservationResponse>(bookReservation);
            return response;
        }
    }
}