using Application.Features.BookIssues.Commands.Create;
using Application.Features.BookIssues.Commands.Delete;
using Application.Features.BookIssues.Commands.Update;
using Application.Features.BookIssues.Queries.GetById;
using Application.Features.BookIssues.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Authors.Queries.GetList;
using Application.Features.Books.Queries.GetList;
using Application.Features.Locations.Queries.GetList;
using Application.Features.FineDues.Queries.GetList;

namespace Application.Features.BookIssues.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<BookIssue, CreateBookIssueCommand>().ReverseMap();
        CreateMap<BookIssue, CreatedBookIssueResponse>().ReverseMap();
        CreateMap<BookIssue, UpdateBookIssueCommand>().ReverseMap();
        CreateMap<BookIssue, UpdatedBookIssueResponse>().ReverseMap();
        CreateMap<BookIssue, DeleteBookIssueCommand>().ReverseMap();
        CreateMap<BookIssue, DeletedBookIssueResponse>().ReverseMap();
        CreateMap<BookIssue, GetByIdBookIssueResponse>()
            .ForMember(dest => dest.FineDues, opt => opt.MapFrom(src => src.FineDues.Select(m => new GetListFineDueListItemDto
            {
                 Id = m.Id,
                 BookIssueId = m.BookIssueId,
                 FineDate = m.FineDate,
                 FineTotal = m.FineTotal
            }))); 
        CreateMap<BookIssue, GetListBookIssueListItemDto>();  
        CreateMap<IPaginate<BookIssue>, GetListResponse<GetListBookIssueListItemDto>>().ReverseMap();
    }
}