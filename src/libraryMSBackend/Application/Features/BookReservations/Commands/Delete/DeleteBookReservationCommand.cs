using Application.Features.BookReservations.Constants;
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

namespace Application.Features.BookReservations.Commands.Delete;

public class DeleteBookReservationCommand : IRequest<DeletedBookReservationResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, BookReservationsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetBookReservations"];

    public class DeleteBookReservationCommandHandler : IRequestHandler<DeleteBookReservationCommand, DeletedBookReservationResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookReservationRepository _bookReservationRepository;
        private readonly BookReservationBusinessRules _bookReservationBusinessRules;

        public DeleteBookReservationCommandHandler(IMapper mapper, IBookReservationRepository bookReservationRepository,
                                         BookReservationBusinessRules bookReservationBusinessRules)
        {
            _mapper = mapper;
            _bookReservationRepository = bookReservationRepository;
            _bookReservationBusinessRules = bookReservationBusinessRules;
        }

        public async Task<DeletedBookReservationResponse> Handle(DeleteBookReservationCommand request, CancellationToken cancellationToken)
        {
            BookReservation? bookReservation = await _bookReservationRepository.GetAsync(predicate: br => br.Id == request.Id, cancellationToken: cancellationToken);
            await _bookReservationBusinessRules.BookReservationShouldExistWhenSelected(bookReservation);

            await _bookReservationRepository.DeleteAsync(bookReservation!);

            DeletedBookReservationResponse response = _mapper.Map<DeletedBookReservationResponse>(bookReservation);
            return response;
        }
    }
}