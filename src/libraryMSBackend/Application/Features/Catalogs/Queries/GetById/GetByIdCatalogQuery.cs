using Application.Features.Catalogs.Constants;
using Application.Features.Catalogs.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.Catalogs.Constants.CatalogsOperationClaims;
using Microsoft.EntityFrameworkCore;

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
            Catalog? catalog = await _catalogRepository.GetAsync(
                include: cm => cm.Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Book).ThenInclude(cm => cm.BookAuthors).ThenInclude(cm => cm.Author)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Magazine)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Material)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Book).ThenInclude(cm => cm.Category)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Book).ThenInclude(cm => cm.Publisher)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.EBook)
                .Include(cm => cm.CatalogManagements).ThenInclude(cm => cm.Book).ThenInclude(cm => cm.Location),
                predicate: c => c.Id == request.Id, cancellationToken: cancellationToken
                );
            await _catalogBusinessRules.CatalogShouldExistWhenSelected(catalog);

            GetByIdCatalogResponse response = _mapper.Map<GetByIdCatalogResponse>(catalog);
            return response;
        }
    }
}