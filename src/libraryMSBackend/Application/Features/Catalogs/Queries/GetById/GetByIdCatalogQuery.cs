using Application.Features.Catalogs.Constants;
using Application.Features.Catalogs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Catalogs.Constants.CatalogsOperationClaims;

namespace Application.Features.Catalogs.Queries.GetById;

public class GetByIdCatalogQuery : IRequest<GetByIdCatalogResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdCatalogQueryHandler : IRequestHandler<GetByIdCatalogQuery, GetByIdCatalogResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICatalogRepository _catalogRepository;
        private readonly CatalogBusinessRules _catalogBusinessRules;

        public GetByIdCatalogQueryHandler(IMapper mapper, ICatalogRepository catalogRepository, CatalogBusinessRules catalogBusinessRules)
        {
            _mapper = mapper;
            _catalogRepository = catalogRepository;
            _catalogBusinessRules = catalogBusinessRules;
        }

        public async Task<GetByIdCatalogResponse> Handle(GetByIdCatalogQuery request, CancellationToken cancellationToken)
        {
            Catalog? catalog = await _catalogRepository.GetAsync(predicate: c => c.Id == request.Id, cancellationToken: cancellationToken);
            await _catalogBusinessRules.CatalogShouldExistWhenSelected(catalog);

            GetByIdCatalogResponse response = _mapper.Map<GetByIdCatalogResponse>(catalog);
            return response;
        }
    }
}