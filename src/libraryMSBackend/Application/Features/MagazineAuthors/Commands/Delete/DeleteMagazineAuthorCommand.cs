using Application.Features.MagazineAuthors.Constants;
using Application.Features.MagazineAuthors.Constants;
using Application.Features.MagazineAuthors.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.MagazineAuthors.Constants.MagazineAuthorsOperationClaims;

namespace Application.Features.MagazineAuthors.Commands.Delete;

public class DeleteMagazineAuthorCommand : IRequest<DeletedMagazineAuthorResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, MagazineAuthorsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetMagazineAuthors"];

    public class DeleteMagazineAuthorCommandHandler : IRequestHandler<DeleteMagazineAuthorCommand, DeletedMagazineAuthorResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMagazineAuthorRepository _magazineAuthorRepository;
        private readonly MagazineAuthorBusinessRules _magazineAuthorBusinessRules;

        public DeleteMagazineAuthorCommandHandler(IMapper mapper, IMagazineAuthorRepository magazineAuthorRepository,
                                         MagazineAuthorBusinessRules magazineAuthorBusinessRules)
        {
            _mapper = mapper;
            _magazineAuthorRepository = magazineAuthorRepository;
            _magazineAuthorBusinessRules = magazineAuthorBusinessRules;
        }

        public async Task<DeletedMagazineAuthorResponse> Handle(DeleteMagazineAuthorCommand request, CancellationToken cancellationToken)
        {
            MagazineAuthor? magazineAuthor = await _magazineAuthorRepository.GetAsync(predicate: ma => ma.Id == request.Id, cancellationToken: cancellationToken);
            await _magazineAuthorBusinessRules.MagazineAuthorShouldExistWhenSelected(magazineAuthor);

            await _magazineAuthorRepository.DeleteAsync(magazineAuthor!);

            DeletedMagazineAuthorResponse response = _mapper.Map<DeletedMagazineAuthorResponse>(magazineAuthor);
            return response;
        }
    }
}