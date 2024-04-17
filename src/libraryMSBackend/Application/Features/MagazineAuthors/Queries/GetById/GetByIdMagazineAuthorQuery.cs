using Application.Features.MagazineAuthors.Constants;
using Application.Features.MagazineAuthors.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.MagazineAuthors.Constants.MagazineAuthorsOperationClaims;

namespace Application.Features.MagazineAuthors.Queries.GetById;

public class GetByIdMagazineAuthorQuery : IRequest<GetByIdMagazineAuthorResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdMagazineAuthorQueryHandler : IRequestHandler<GetByIdMagazineAuthorQuery, GetByIdMagazineAuthorResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMagazineAuthorRepository _magazineAuthorRepository;
        private readonly MagazineAuthorBusinessRules _magazineAuthorBusinessRules;

        public GetByIdMagazineAuthorQueryHandler(IMapper mapper, IMagazineAuthorRepository magazineAuthorRepository, MagazineAuthorBusinessRules magazineAuthorBusinessRules)
        {
            _mapper = mapper;
            _magazineAuthorRepository = magazineAuthorRepository;
            _magazineAuthorBusinessRules = magazineAuthorBusinessRules;
        }

        public async Task<GetByIdMagazineAuthorResponse> Handle(GetByIdMagazineAuthorQuery request, CancellationToken cancellationToken)
        {
            MagazineAuthor? magazineAuthor = await _magazineAuthorRepository.GetAsync(predicate: ma => ma.Id == request.Id, cancellationToken: cancellationToken);
            await _magazineAuthorBusinessRules.MagazineAuthorShouldExistWhenSelected(magazineAuthor);

            GetByIdMagazineAuthorResponse response = _mapper.Map<GetByIdMagazineAuthorResponse>(magazineAuthor);
            return response;
        }
    }
}