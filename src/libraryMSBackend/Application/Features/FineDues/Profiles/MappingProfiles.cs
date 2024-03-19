using Application.Features.FineDues.Commands.Create;
using Application.Features.FineDues.Commands.Delete;
using Application.Features.FineDues.Commands.Update;
using Application.Features.FineDues.Queries.GetById;
using Application.Features.FineDues.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.FineDues.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<FineDue, CreateFineDueCommand>().ReverseMap();
        CreateMap<FineDue, CreatedFineDueResponse>().ReverseMap();
        CreateMap<FineDue, UpdateFineDueCommand>().ReverseMap();
        CreateMap<FineDue, UpdatedFineDueResponse>().ReverseMap();
        CreateMap<FineDue, DeleteFineDueCommand>().ReverseMap();
        CreateMap<FineDue, DeletedFineDueResponse>().ReverseMap();
        CreateMap<FineDue, GetByIdFineDueResponse>().ReverseMap();
        CreateMap<FineDue, GetListFineDueListItemDto>().ReverseMap();
        CreateMap<IPaginate<FineDue>, GetListResponse<GetListFineDueListItemDto>>().ReverseMap();
    }
}