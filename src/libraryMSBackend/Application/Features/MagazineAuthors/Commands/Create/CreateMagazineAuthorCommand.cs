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

namespace Application.Features.MagazineAuthors.Commands.Create;

public class CreateMagazineAuthorCommand : IRequest<CreatedMagazineAuthorResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid MagazineId { get; set; }
    public Guid AuthorId { get; set; }

    public string[] Roles => [Admin, Write, MagazineAuthorsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetMagazineAuthors"];

    public class CreateMagazineAuthorCommandHandler : IRequestHandler<CreateMagazineAuthorCommand, CreatedMagazineAuthorResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMagazineAuthorRepository _magazineAuthorRepository;
        private readonly MagazineAuthorBusinessRules _magazineAuthorBusinessRules;

        public CreateMagazineAuthorCommandHandler(IMapper mapper, IMagazineAuthorRepository magazineAuthorRepository,
                                         MagazineAuthorBusinessRules magazineAuthorBusinessRules)
        {
            _mapper = mapper;
            _magazineAuthorRepository = magazineAuthorRepository;
            _magazineAuthorBusinessRules = magazineAuthorBusinessRules;
        }

        public async Task<CreatedMagazineAuthorResponse> Handle(CreateMagazineAuthorCommand request, CancellationToken cancellationToken)
        {
            MagazineAuthor magazineAuthor = _mapper.Map<MagazineAuthor>(request);

            await _magazineAuthorRepository.AddAsync(magazineAuthor);

            CreatedMagazineAuthorResponse response = _mapper.Map<CreatedMagazineAuthorResponse>(magazineAuthor);
            return response;
        }
    }
}