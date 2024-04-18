using Application.Features.CatalogManagements.Constants;
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

namespace Application.Features.CatalogManagements.Commands.Delete;

public class DeleteCatalogManagementCommand : IRequest<DeletedCatalogManagementResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Write, CatalogManagementsOperationClaims.Delete];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetCatalogManagements"];

    public class DeleteCatalogManagementCommandHandler : IRequestHandler<DeleteCatalogManagementCommand, DeletedCatalogManagementResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICatalogManagementRepository _catalogManagementRepository;
        private readonly CatalogManagementBusinessRules _catalogManagementBusinessRules;

        public DeleteCatalogManagementCommandHandler(IMapper mapper, ICatalogManagementRepository catalogManagementRepository,
                                         CatalogManagementBusinessRules catalogManagementBusinessRules)
        {
            _mapper = mapper;
            _catalogManagementRepository = catalogManagementRepository;
            _catalogManagementBusinessRules = catalogManagementBusinessRules;
        }

        public async Task<DeletedCatalogManagementResponse> Handle(DeleteCatalogManagementCommand request, CancellationToken cancellationToken)
        {
            CatalogManagement? catalogManagement = await _catalogManagementRepository.GetAsync(predicate: cm => cm.Id == request.Id, cancellationToken: cancellationToken);
            await _catalogManagementBusinessRules.CatalogManagementShouldExistWhenSelected(catalogManagement);

            await _catalogManagementRepository.DeleteAsync(catalogManagement!);

            DeletedCatalogManagementResponse response = _mapper.Map<DeletedCatalogManagementResponse>(catalogManagement);
            return response;
        }
    }
}