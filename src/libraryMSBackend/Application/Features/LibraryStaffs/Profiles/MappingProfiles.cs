using Application.Features.LibraryStaffs.Commands.Create;
using Application.Features.LibraryStaffs.Commands.Delete;
using Application.Features.LibraryStaffs.Commands.Update;
using Application.Features.LibraryStaffs.Queries.GetById;
using Application.Features.LibraryStaffs.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.LibraryStaffs.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<LibraryStaff, CreateLibraryStaffCommand>().ReverseMap();
        CreateMap<LibraryStaff, CreatedLibraryStaffResponse>().ReverseMap();
        CreateMap<LibraryStaff, UpdateLibraryStaffCommand>().ReverseMap();
        CreateMap<LibraryStaff, UpdatedLibraryStaffResponse>().ReverseMap();
        CreateMap<LibraryStaff, DeleteLibraryStaffCommand>().ReverseMap();
        CreateMap<LibraryStaff, DeletedLibraryStaffResponse>().ReverseMap();
        CreateMap<LibraryStaff, GetByIdLibraryStaffResponse>().ReverseMap();
        CreateMap<LibraryStaff, GetListLibraryStaffListItemDto>().ReverseMap();
        CreateMap<IPaginate<LibraryStaff>, GetListResponse<GetListLibraryStaffListItemDto>>().ReverseMap();
    }
}