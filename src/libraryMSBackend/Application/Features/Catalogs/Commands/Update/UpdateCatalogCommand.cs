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

namespace Application.Features.Catalogs.Commands.Update;

public class UpdateCatalogCommand : IRequest<UpdatedCatalogResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public string[] Roles => [Admin, Write, CatalogsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetCatalogs"];

    public class UpdateCatalogCommandHandler : IRequestHandler<UpdateCatalogCommand, UpdatedCatalogResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICatalogRepository _catalogRepository;
        private readonly CatalogBusinessRules _catalogBusinessRules;

        public UpdateCatalogCommandHandler(IMapper mapper, ICatalogRepository catalogRepository,
                                         CatalogBusinessRules catalogBusinessRules)
        {
            _mapper = mapper;
            _catalogRepository = catalogRepository;
            _catalogBusinessRules = catalogBusinessRules;
        }

        public async Task<UpdatedCatalogResponse> Handle(UpdateCatalogCommand request, CancellationToken cancellationToken)
        {
            Catalog? catalog = await _catalogRepository.GetAsync(predicate: c => c.Id == request.Id, cancellationToken: cancellationToken);
            await _catalogBusinessRules.CatalogShouldExistWhenSelected(catalog);
            catalog = _mapper.Map(request, catalog);

            await _catalogRepository.UpdateAsync(catalog!);

            UpdatedCatalogResponse response = _mapper.Map<UpdatedCatalogResponse>(catalog);
            return response;
        }
    }
}