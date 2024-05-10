using Application.Features.Announcements.Commands.Create;
using Application.Features.Announcements.Commands.Delete;
using Application.Features.Announcements.Commands.Update;
using Application.Features.Announcements.Queries.GetById;
using Application.Features.Announcements.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Authors.Queries.FilterSearch;
using Application.Features.Announcements.Queries.FilterSearchh;

namespace Application.Features.Announcements.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Announcement, CreateAnnouncementCommand>().ReverseMap();
        CreateMap<Announcement, CreatedAnnouncementResponse>().ReverseMap();
        CreateMap<Announcement, UpdateAnnouncementCommand>().ReverseMap();
        CreateMap<Announcement, UpdatedAnnouncementResponse>().ReverseMap();
        CreateMap<Announcement, DeleteAnnouncementCommand>().ReverseMap();
        CreateMap<Announcement, DeletedAnnouncementResponse>().ReverseMap();
        CreateMap<Announcement, GetByIdAnnouncementResponse>().ReverseMap();
        CreateMap<Announcement, GetListAnnouncementListItemDto>().ReverseMap();
        CreateMap<Announcement, SearchAnnouncementsResponse>()
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title));
        CreateMap<IPaginate<Announcement>, GetListResponse<GetListAnnouncementListItemDto>>().ReverseMap();
    }
}