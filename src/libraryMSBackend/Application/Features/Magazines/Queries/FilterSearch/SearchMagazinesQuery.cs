using Application.Features.Books.Queries.GetList;
using Application.Features.Magazines.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;



public class SearchMagazinesQuery : IRequest<GetListResponse<GetListMagazineListItemDto>>
{
    public SearchCriteria Criteria { get; set; }
    public PageRequest PageRequest { get; set; }

    public SearchMagazinesQuery(SearchCriteria criteria, PageRequest pageRequest)
    {
        Criteria = criteria;
        PageRequest = pageRequest;
    }
}

public class SearchMagazinesQueryHandler : IRequestHandler<SearchMagazinesQuery, GetListResponse<GetListMagazineListItemDto>>
{
    private readonly IMagazineRepository _magazineRepository;
    private readonly IMapper _mapper;

    public SearchMagazinesQueryHandler(IMagazineRepository magazineRepository, IMapper mapper)
    {
        _magazineRepository = magazineRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListMagazineListItemDto>> Handle(SearchMagazinesQuery request, CancellationToken cancellationToken)
    {
        var query = _magazineRepository.Table;

        //ilişkili varlıkları dahil etme 
        query = query.Include(b => b.Publisher).Include(b=>b.Category);


        // Magazine Title
        if (!string.IsNullOrEmpty(request.Criteria.MagazineTitle))
        {
            query = query.Where(b => b.MagazineTitle.Contains(request.Criteria.MagazineTitle));
        }
        //Magazine ISSN Code
        if (!string.IsNullOrEmpty(request.Criteria.MagazineISSNCode))
        {
            query = query.Where(b => b.ISSNCode.Contains(request.Criteria.MagazineISSNCode));
        }
     
       
        // Sorguyu sayfalama
        IPaginate<Magazine> paginatedQuery = await query.ToPaginateAsync(
            
            request.PageRequest.PageIndex,
            request.PageRequest.PageSize
        );

        // Mapleme ve yanıt oluşturma
        GetListResponse<GetListMagazineListItemDto> response = _mapper.Map<GetListResponse<GetListMagazineListItemDto>>(paginatedQuery);
        return response;
    }
}

