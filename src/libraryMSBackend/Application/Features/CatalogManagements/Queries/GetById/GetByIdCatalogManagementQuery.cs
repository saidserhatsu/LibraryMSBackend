using Application.Features.CatalogManagements.Constants;
using Application.Features.CatalogManagements.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.CatalogManagements.Constants.CatalogManagementsOperationClaims;

namespace Application.Features.CatalogManagements.Queries.GetById;

public class GetByIdCatalogManagementQuery : IRequest<GetByIdCatalogManagementResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdCatalogManagementQueryHandler : IRequestHandler<GetByIdCatalogManagementQuery, GetByIdCatalogManagementResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICatalogManagementRepository _catalogManagementRepository;
        private readonly CatalogManagementBusinessRules _catalogManagementBusinessRules;

        public GetByIdCatalogManagementQueryHandler(IMapper mapper, ICatalogManagementRepository catalogManagementRepository, CatalogManagementBusinessRules catalogManagementBusinessRules)
        {
            _mapper = mapper;
            _catalogManagementRepository = catalogManagementRepository;
            _catalogManagementBusinessRules = catalogManagementBusinessRules;
        }

        public async Task<GetByIdCatalogManagementResponse> Handle(GetByIdCatalogManagementQuery request, CancellationToken cancellationToken)
        {
            CatalogManagement? catalogManagement = await _catalogManagementRepository.GetAsync(predicate: cm => cm.Id == request.Id, cancellationToken: cancellationToken);
            await _catalogManagementBusinessRules.CatalogManagementShouldExistWhenSelected(catalogManagement);

            GetByIdCatalogManagementResponse response = _mapper.Map<GetByIdCatalogManagementResponse>(catalogManagement);
            return response;
        }
    }
}