using Application.Features.FavoriteBooks.Constants;
using Application.Features.FavoriteBooks.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.FavoriteBooks.Constants.FavoriteBooksOperationClaims;

namespace Application.Features.FavoriteBooks.Queries.GetById;

public class GetByIdFavoriteBookQuery : IRequest<GetByIdFavoriteBookResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdFavoriteBookQueryHandler : IRequestHandler<GetByIdFavoriteBookQuery, GetByIdFavoriteBookResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFavoriteBookRepository _favoriteBookRepository;
        private readonly FavoriteBookBusinessRules _favoriteBookBusinessRules;

        public GetByIdFavoriteBookQueryHandler(IMapper mapper, IFavoriteBookRepository favoriteBookRepository, FavoriteBookBusinessRules favoriteBookBusinessRules)
        {
            _mapper = mapper;
            _favoriteBookRepository = favoriteBookRepository;
            _favoriteBookBusinessRules = favoriteBookBusinessRules;
        }

        public async Task<GetByIdFavoriteBookResponse> Handle(GetByIdFavoriteBookQuery request, CancellationToken cancellationToken)
        {
            FavoriteBook? favoriteBook = await _favoriteBookRepository.GetAsync(predicate: fb => fb.Id == request.Id, cancellationToken: cancellationToken);
            await _favoriteBookBusinessRules.FavoriteBookShouldExistWhenSelected(favoriteBook);

            GetByIdFavoriteBookResponse response = _mapper.Map<GetByIdFavoriteBookResponse>(favoriteBook);
            return response;
        }
    }
}