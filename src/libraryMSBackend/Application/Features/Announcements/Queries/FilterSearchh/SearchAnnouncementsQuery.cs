using Application.Features.Announcements.Queries.FilterSearchh;
using Application.Features.Announcements.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Announcements.Queries.FilterSearch
{
    public class SearchAnnouncementsQuery : IRequest<GetListResponse<GetListAnnouncementListItemDto>>
    {
        public SearchCriteria Criteria { get; set; }
        public PageRequest PageRequest { get; set; }

        public SearchAnnouncementsQuery(SearchCriteria criteria, PageRequest pageRequest)
        {
            Criteria = criteria;
            PageRequest = pageRequest;
        }
    }

    public class SearchAnnouncementsQueryHandler : IRequestHandler<SearchAnnouncementsQuery, GetListResponse<GetListAnnouncementListItemDto>>
    {
        private readonly IAnnouncementRepository _announcementRepository;
        private readonly IMapper _mapper;

        public SearchAnnouncementsQueryHandler(IAnnouncementRepository announcementRepository, IMapper mapper)
        {
            _announcementRepository = announcementRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListAnnouncementListItemDto>> Handle(SearchAnnouncementsQuery request, CancellationToken cancellationToken)
        {
            var query = _announcementRepository.Table;

            // Announcement Title'a göre arama
            if (!string.IsNullOrEmpty(request.Criteria.AnnouncementTitle))
            {
                query = query.Where(a => a.Title.Contains(request.Criteria.AnnouncementTitle));
            }

            // Sayfalama uygulama
            IPaginate<Announcement> paginatedQuery = await query.ToPaginateAsync(
                request.PageRequest.PageIndex,
                request.PageRequest.PageSize
            );

            // Yanıtı oluşturmak için verileri haritalama
            GetListResponse<GetListAnnouncementListItemDto> response = _mapper.Map<GetListResponse<GetListAnnouncementListItemDto>>(paginatedQuery);
            return response;
        }
    }
}