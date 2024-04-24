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

namespace Application.Features.FavoriteBooks.Commands.Create;

public class CreateFavoriteBookCommand : IRequest<CreatedFavoriteBookResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid BookId { get; set; }
    public Guid MemberId { get; set; }

    public string[] Roles => [Admin, Write, FavoriteBooksOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetFavoriteBooks"];

    public class CreateFavoriteBookCommandHandler : IRequestHandler<CreateFavoriteBookCommand, CreatedFavoriteBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFavoriteBookRepository _favoriteBookRepository;
        private readonly FavoriteBookBusinessRules _favoriteBookBusinessRules;

        public CreateFavoriteBookCommandHandler(IMapper mapper, IFavoriteBookRepository favoriteBookRepository,
                                         FavoriteBookBusinessRules favoriteBookBusinessRules)
        {
            _mapper = mapper;
            _favoriteBookRepository = favoriteBookRepository;
            _favoriteBookBusinessRules = favoriteBookBusinessRules;
        }

        public async Task<CreatedFavoriteBookResponse> Handle(CreateFavoriteBookCommand request, CancellationToken cancellationToken)
        {
            FavoriteBook favoriteBook = _mapper.Map<FavoriteBook>(request);

            await _favoriteBookRepository.AddAsync(favoriteBook);

            CreatedFavoriteBookResponse response = _mapper.Map<CreatedFavoriteBookResponse>(favoriteBook);
            return response;
        }
    }
}