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

namespace Application.Features.MagazineAuthors.Commands.Update;

public class UpdateMagazineAuthorCommand : IRequest<UpdatedMagazineAuthorResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid MagazineId { get; set; }
    public Guid AuthorId { get; set; }

    public string[] Roles => [Admin, Write, MagazineAuthorsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetMagazineAuthors"];

    public class UpdateMagazineAuthorCommandHandler : IRequestHandler<UpdateMagazineAuthorCommand, UpdatedMagazineAuthorResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMagazineAuthorRepository _magazineAuthorRepository;
        private readonly MagazineAuthorBusinessRules _magazineAuthorBusinessRules;

        public UpdateMagazineAuthorCommandHandler(IMapper mapper, IMagazineAuthorRepository magazineAuthorRepository,
                                         MagazineAuthorBusinessRules magazineAuthorBusinessRules)
        {
            _mapper = mapper;
            _magazineAuthorRepository = magazineAuthorRepository;
            _magazineAuthorBusinessRules = magazineAuthorBusinessRules;
        }

        public async Task<UpdatedMagazineAuthorResponse> Handle(UpdateMagazineAuthorCommand request, CancellationToken cancellationToken)
        {
            MagazineAuthor? magazineAuthor = await _magazineAuthorRepository.GetAsync(predicate: ma => ma.Id == request.Id, cancellationToken: cancellationToken);
            await _magazineAuthorBusinessRules.MagazineAuthorShouldExistWhenSelected(magazineAuthor);
            magazineAuthor = _mapper.Map(request, magazineAuthor);

            await _magazineAuthorRepository.UpdateAsync(magazineAuthor!);

            UpdatedMagazineAuthorResponse response = _mapper.Map<UpdatedMagazineAuthorResponse>(magazineAuthor);
            return response;
        }
    }
}