using Application.Features.CatalogManagements.Constants;
using Application.Features.CatalogManagements.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using MediatR;
using static Application.Features.CatalogManagements.Constants.CatalogManagementsOperationClaims;

namespace Application.Features.CatalogManagements.Commands.Create;

public class CreateCatalogManagementCommand : IRequest<CreatedCatalogManagementResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid? MaterialId { get; set; }
    public Guid? BookId { get; set; }
    public Guid? MagazineId { get; set; }
    public Guid CatalogId { get; set; }

    public string[] Roles => [Admin, Write, CatalogManagementsOperationClaims.Create];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetCatalogManagements"];

    public class CreateCatalogManagementCommandHandler : IRequestHandler<CreateCatalogManagementCommand, CreatedCatalogManagementResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICatalogManagementRepository _catalogManagementRepository;
        private readonly CatalogManagementBusinessRules _catalogManagementBusinessRules;

        public CreateCatalogManagementCommandHandler(IMapper mapper, ICatalogManagementRepository catalogManagementRepository,
                                         CatalogManagementBusinessRules catalogManagementBusinessRules)
        {
            _mapper = mapper;
            _catalogManagementRepository = catalogManagementRepository;
            _catalogManagementBusinessRules = catalogManagementBusinessRules;
        }

        public async Task<CreatedCatalogManagementResponse> Handle(CreateCatalogManagementCommand request, CancellationToken cancellationToken)
        {
            CatalogManagement catalogManagement = _mapper.Map<CatalogManagement>(request);

            await _catalogManagementRepository.AddAsync(catalogManagement);

            CreatedCatalogManagementResponse response = _mapper.Map<CreatedCatalogManagementResponse>(catalogManagement);
            return response;
        }
    }
}