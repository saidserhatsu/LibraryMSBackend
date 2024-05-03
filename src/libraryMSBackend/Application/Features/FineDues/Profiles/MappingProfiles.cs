using Application.Features.FineDues.Commands.Create;
using Application.Features.FineDues.Commands.Delete;
using Application.Features.FineDues.Commands.Update;
using Application.Features.FineDues.Queries.GetById;
using Application.Features.FineDues.Queries.GetList;
using Application.Features.FineDues.Queries.FilterSearch;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.FineDues.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // FineDue ile ilgili komutlar için haritalama
        CreateMap<FineDue, CreateFineDueCommand>().ReverseMap();
        CreateMap<FineDue, CreatedFineDueResponse>().ReverseMap();
        CreateMap<FineDue, UpdateFineDueCommand>().ReverseMap();
        CreateMap<FineDue, UpdatedFineDueResponse>().ReverseMap();
        CreateMap<FineDue, DeleteFineDueCommand>().ReverseMap();
        CreateMap<FineDue, DeletedFineDueResponse>().ReverseMap();

        // Sorgular için haritalama
        CreateMap<FineDue, GetByIdFineDueResponse>().ReverseMap();
        CreateMap<FineDue, GetListFineDueListItemDto>().ReverseMap();

        // Sayfalama (Pagination) için haritalama
        CreateMap<IPaginate<FineDue>, GetListResponse<GetListFineDueListItemDto>>().ReverseMap();

        // FilterSearch için haritalama
        CreateMap<FineDue, SearchFineDueResponse>()
            .ForMember(dest => dest.BookIssueMemberFirstName, opt => opt.MapFrom(src => src.BookIssue.Member.FirstName))
            .ForMember(dest => dest.BookIssueMemberLastName, opt => opt.MapFrom(src => src.BookIssue.Member.LastName)); // Ýlgili üyelerin bilgileri

        CreateMap<IPaginate<FineDue>, GetListResponse<SearchFineDueResponse>>().ReverseMap();
    }
}