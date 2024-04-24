using Application.Features.FavoriteBooks.Constants;
using Application.Features.FavoriteBooks.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.FavoriteBooks.Constants.FavoriteBooksOperationClaims;

namespace Application.Features.FavoriteBooks.Commands.Update;

public class UpdateFavoriteBookCommand : IRequest<UpdatedFavoriteBookResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }

    public string[] Roles => [Admin, Write, FavoriteBooksOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetFavoriteBooks"];

    public class UpdateFavoriteBookCommandHandler : IRequestHandler<UpdateFavoriteBookCommand, UpdatedFavoriteBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFavoriteBookRepository _favoriteBookRepository;
        private readonly FavoriteBookBusinessRules _favoriteBookBusinessRules;

        public UpdateFavoriteBookCommandHandler(IMapper mapper, IFavoriteBookRepository favoriteBookRepository,
                                         FavoriteBookBusinessRules favoriteBookBusinessRules)
        {
            _mapper = mapper;
            _favoriteBookRepository = favoriteBookRepository;
            _favoriteBookBusinessRules = favoriteBookBusinessRules;
        }

        public async Task<UpdatedFavoriteBookResponse> Handle(UpdateFavoriteBookCommand request, CancellationToken cancellationToken)
        {
            FavoriteBook? favoriteBook = await _favoriteBookRepository.GetAsync(predicate: fb => fb.Id == request.Id, cancellationToken: cancellationToken);
            await _favoriteBookBusinessRules.FavoriteBookShouldExistWhenSelected(favoriteBook);
            favoriteBook = _mapper.Map(request, favoriteBook);

            await _favoriteBookRepository.UpdateAsync(favoriteBook!);

            UpdatedFavoriteBookResponse response = _mapper.Map<UpdatedFavoriteBookResponse>(favoriteBook);
            return response;
        }
    }
}