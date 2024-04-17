using Application.Features.Catalogs.Constants;
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

namespace Application.Features.Catalogs.Commands.Delete;

public class DeleteCatalogCommand : IRequest<DeletedCatalogResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, CatalogsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetCatalogs"];

    public class DeleteCatalogCommandHandler : IRequestHandler<DeleteCatalogCommand, DeletedCatalogResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICatalogRepository _catalogRepository;
        private readonly CatalogBusinessRules _catalogBusinessRules;

        public DeleteCatalogCommandHandler(IMapper mapper, ICatalogRepository catalogRepository,
                                         CatalogBusinessRules catalogBusinessRules)
        {
            _mapper = mapper;
            _catalogRepository = catalogRepository;
            _catalogBusinessRules = catalogBusinessRules;
        }

        public async Task<DeletedCatalogResponse> Handle(DeleteCatalogCommand request, CancellationToken cancellationToken)
        {
            Catalog? catalog = await _catalogRepository.GetAsync(predicate: c => c.Id == request.Id, cancellationToken: cancellationToken);
            await _catalogBusinessRules.CatalogShouldExistWhenSelected(catalog);

            await _catalogRepository.DeleteAsync(catalog!);

            DeletedCatalogResponse response = _mapper.Map<DeletedCatalogResponse>(catalog);
            return response;
        }
    }
}