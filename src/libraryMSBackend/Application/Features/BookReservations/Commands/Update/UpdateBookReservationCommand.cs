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

namespace Application.Features.BookReservations.Commands.Update;

public class UpdateBookReservationCommand : IRequest<UpdatedBookReservationResponse>, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }
    public DateTime NearestAvailableDate { get; set; }
    public DateTime RequestDate { get; set; }

    public string[] Roles => [Admin, Write, BookReservationsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBookReservations"];

    public class UpdateBookReservationCommandHandler : IRequestHandler<UpdateBookReservationCommand, UpdatedBookReservationResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookReservationRepository _bookReservationRepository;
        private readonly BookReservationBusinessRules _bookReservationBusinessRules;

        public UpdateBookReservationCommandHandler(IMapper mapper, IBookReservationRepository bookReservationRepository,
                                         BookReservationBusinessRules bookReservationBusinessRules)
        {
            _mapper = mapper;
            _bookReservationRepository = bookReservationRepository;
            _bookReservationBusinessRules = bookReservationBusinessRules;
        }

        public async Task<UpdatedBookReservationResponse> Handle(UpdateBookReservationCommand request, CancellationToken cancellationToken)
        {
            BookReservation? bookReservation = await _bookReservationRepository.GetAsync(predicate: br => br.Id == request.Id, cancellationToken: cancellationToken);
            await _bookReservationBusinessRules.BookReservationShouldExistWhenSelected(bookReservation);
            bookReservation = _mapper.Map(request, bookReservation);

            await _bookReservationRepository.UpdateAsync(bookReservation!);

            UpdatedBookReservationResponse response = _mapper.Map<UpdatedBookReservationResponse>(bookReservation);
            return response;
        }
    }
}