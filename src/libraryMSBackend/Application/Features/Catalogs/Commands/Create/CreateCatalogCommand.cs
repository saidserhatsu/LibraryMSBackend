using Application.Features.Catalogs.Constants;
using Application.Features.Catalogs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.Catalogs.Constants.CatalogsOperationClaims;

namespace Application.Features.Catalogs.Commands.Create;

public class CreateCatalogCommand : IRequest<CreatedCatalogResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string Name { get; set; }

    public string[] Roles => [Admin, Write, CatalogsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetCatalogs"];

    public class CreateCatalogCommandHandler : IRequestHandler<CreateCatalogCommand, CreatedCatalogResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICatalogRepository _catalogRepository;
        private readonly CatalogBusinessRules _catalogBusinessRules;

        public CreateCatalogCommandHandler(IMapper mapper, ICatalogRepository catalogRepository,
                                         CatalogBusinessRules catalogBusinessRules)
        {
            _mapper = mapper;
            _catalogRepository = catalogRepository;
            _catalogBusinessRules = catalogBusinessRules;
        }

        public async Task<CreatedCatalogResponse> Handle(CreateCatalogCommand request, CancellationToken cancellationToken)
        {
            Catalog catalog = _mapper.Map<Catalog>(request);

            await _catalogRepository.AddAsync(catalog);

            CreatedCatalogResponse response = _mapper.Map<CreatedCatalogResponse>(catalog);
            return response;
        }
    }
}