using Application.Features.SearchCriterias.Commands.Create;
using Application.Features.SearchCriterias.Commands.Delete;
using Application.Features.SearchCriterias.Commands.Update;
using Application.Features.SearchCriterias.Queries.GetById;
using Application.Features.SearchCriterias.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.SearchCriterias.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<SearchCriteria, CreateSearchCriteriaCommand>().ReverseMap();
        CreateMap<SearchCriteria, CreatedSearchCriteriaResponse>().ReverseMap();
        CreateMap<SearchCriteria, UpdateSearchCriteriaCommand>().ReverseMap();
        CreateMap<SearchCriteria, UpdatedSearchCriteriaResponse>().ReverseMap();
        CreateMap<SearchCriteria, DeleteSearchCriteriaCommand>().ReverseMap();
        CreateMap<SearchCriteria, DeletedSearchCriteriaResponse>().ReverseMap();
        CreateMap<SearchCriteria, GetByIdSearchCriteriaResponse>().ReverseMap();
        CreateMap<SearchCriteria, GetListSearchCriteriaListItemDto>().ReverseMap();
        CreateMap<IPaginate<SearchCriteria>, GetListResponse<GetListSearchCriteriaListItemDto>>().ReverseMap();
    }
}