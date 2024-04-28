using Application.Features.Members.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Members.Queries.FilterSearch;
public class SearchMembersQuery : IRequest<GetListResponse<GetListMemberListItemDto>>
{
    public SearchCriteria Criteria { get; set; }
    public PageRequest PageRequest { get; set; }

    public SearchMembersQuery(SearchCriteria criteria, PageRequest pageRequest)
    {
        Criteria = criteria;
        PageRequest = pageRequest;
    }
}
public class SearchMembersQueryHandler : IRequestHandler<SearchMembersQuery, GetListResponse<GetListMemberListItemDto>>
{
    private readonly IMemberRepository _memberRepository;
    private readonly IMapper _mapper;

    public SearchMembersQueryHandler(IMemberRepository memberRepository, IMapper mapper)
    {
        _memberRepository = memberRepository;
        _mapper = mapper;
    }

    public async Task<GetListResponse<GetListMemberListItemDto>> Handle(SearchMembersQuery request, CancellationToken cancellationToken)
    {
        var query = _memberRepository.Table;
        query = query.Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.Location)
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.Category)
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.Publisher)
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.BookAuthors).ThenInclude(b => b.Author);

        // E-posta ile arama
        if (!string.IsNullOrEmpty(request.Criteria.MembersEmail))
        {
            query = query.Where(m => m.Email.Contains(request.Criteria.MembersEmail));
        }

        // Sayfalama
        IPaginate<Member> paginatedQuery = await query.ToPaginateAsync(
            request.PageRequest.PageIndex,
            request.PageRequest.PageSize
        );

        // Yanıtı oluşturmak için verileri haritalama
        var response = _mapper.Map<GetListResponse<GetListMemberListItemDto>>(paginatedQuery);
        return response;
    }
}
