using Application.Features.BookIssues.Commands.Create;
using Application.Features.BookIssues.Commands.Delete;
using Application.Features.BookIssues.Commands.Update;
using Application.Features.BookIssues.Queries.GetById;
using Application.Features.BookIssues.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

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
        CreateMap<BookIssue, GetByIdBookIssueResponse>().ReverseMap();
        CreateMap<BookIssue, GetListBookIssueListItemDto>();  
        CreateMap<IPaginate<BookIssue>, GetListResponse<GetListBookIssueListItemDto>>().ReverseMap();
    }
}