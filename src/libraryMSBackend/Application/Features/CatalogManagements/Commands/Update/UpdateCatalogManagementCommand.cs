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

namespace Application.Features.CatalogManagements.Commands.Update;

public class UpdateCatalogManagementCommand : IRequest<UpdatedCatalogManagementResponse>, ISecuredRequest, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public Guid Id { get; set; }
    public Guid? MaterialId { get; set; }
    public Guid? BookId { get; set; }
    public Guid? MagazineId { get; set; }
    public Guid? EBookId { get; set; }
    public Guid CatalogId { get; set; }

    public string[] Roles => [Admin, Write, CatalogManagementsOperationClaims.Update];

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetCatalogManagements"];

    public class UpdateCatalogManagementCommandHandler : IRequestHandler<UpdateCatalogManagementCommand, UpdatedCatalogManagementResponse>
    {
        private readonly IMapper _mapper;
        private readonly ICatalogManagementRepository _catalogManagementRepository;
        private readonly CatalogManagementBusinessRules _catalogManagementBusinessRules;

        public UpdateCatalogManagementCommandHandler(IMapper mapper, ICatalogManagementRepository catalogManagementRepository,
                                         CatalogManagementBusinessRules catalogManagementBusinessRules)
        {
            _mapper = mapper;
            _catalogManagementRepository = catalogManagementRepository;
            _catalogManagementBusinessRules = catalogManagementBusinessRules;
        }

        public async Task<UpdatedCatalogManagementResponse> Handle(UpdateCatalogManagementCommand request, CancellationToken cancellationToken)
        {
            CatalogManagement? catalogManagement = await _catalogManagementRepository.GetAsync(predicate: cm => cm.Id == request.Id, cancellationToken: cancellationToken);
            await _catalogManagementBusinessRules.CatalogManagementShouldExistWhenSelected(catalogManagement);
            catalogManagement = _mapper.Map(request, catalogManagement);

            await _catalogManagementRepository.UpdateAsync(catalogManagement!);

            UpdatedCatalogManagementResponse response = _mapper.Map<UpdatedCatalogManagementResponse>(catalogManagement);
            return response;
        }
    }
}