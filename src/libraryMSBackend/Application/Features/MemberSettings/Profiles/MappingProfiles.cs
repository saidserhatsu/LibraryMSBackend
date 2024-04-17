using Application.Features.MemberSettings.Commands.Create;
using Application.Features.MemberSettings.Commands.Delete;
using Application.Features.MemberSettings.Commands.Update;
using Application.Features.MemberSettings.Queries.GetById;
using Application.Features.MemberSettings.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.MemberSettings.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<MemberSetting, CreateMemberSettingCommand>().ReverseMap();
        CreateMap<MemberSetting, CreatedMemberSettingResponse>().ReverseMap();
        CreateMap<MemberSetting, UpdateMemberSettingCommand>().ReverseMap();
        CreateMap<MemberSetting, UpdatedMemberSettingResponse>().ReverseMap();
        CreateMap<MemberSetting, DeleteMemberSettingCommand>().ReverseMap();
        CreateMap<MemberSetting, DeletedMemberSettingResponse>().ReverseMap();
        CreateMap<MemberSetting, GetByIdMemberSettingResponse>().ReverseMap();
        CreateMap<MemberSetting, GetListMemberSettingListItemDto>().ReverseMap();
        CreateMap<IPaginate<MemberSetting>, GetListResponse<GetListMemberSettingListItemDto>>().ReverseMap();
    }
}