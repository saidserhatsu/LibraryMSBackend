using Application.Features.FavoriteBooks.Constants;
using Application.Features.FavoriteBooks.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using static Application.Features.FavoriteBooks.Constants.FavoriteBooksOperationClaims;

namespace Application.Features.FavoriteBooks.Commands.Delete;

public class DeleteFavoriteBookCommand : IRequest<DeletedFavoriteBookResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, FavoriteBooksOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetFavoriteBooks"];

    public class DeleteFavoriteBookCommandHandler : IRequestHandler<DeleteFavoriteBookCommand, DeletedFavoriteBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFavoriteBookRepository _favoriteBookRepository;
        private readonly FavoriteBookBusinessRules _favoriteBookBusinessRules;

        public DeleteFavoriteBookCommandHandler(IMapper mapper, IFavoriteBookRepository favoriteBookRepository,
                                         FavoriteBookBusinessRules favoriteBookBusinessRules)
        {
            _mapper = mapper;
            _favoriteBookRepository = favoriteBookRepository;
            _favoriteBookBusinessRules = favoriteBookBusinessRules;
        }

        public async Task<DeletedFavoriteBookResponse> Handle(DeleteFavoriteBookCommand request, CancellationToken cancellationToken)
        {
            FavoriteBook? favoriteBook = await _favoriteBookRepository.GetAsync(predicate: fb => fb.Id == request.Id, cancellationToken: cancellationToken);
            await _favoriteBookBusinessRules.FavoriteBookShouldExistWhenSelected(favoriteBook);

            await _favoriteBookRepository.DeleteAsync(favoriteBook!, true);

            DeletedFavoriteBookResponse response = _mapper.Map<DeletedFavoriteBookResponse>(favoriteBook);
            return response;
        }
    }
}