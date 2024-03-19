using Application.Features.BookReservations.Commands.Create;
using Application.Features.BookReservations.Commands.Delete;
using Application.Features.BookReservations.Commands.Update;
using Application.Features.BookReservations.Queries.GetById;
using Application.Features.BookReservations.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.BookReservations.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<BookReservation, CreateBookReservationCommand>().ReverseMap();
        CreateMap<BookReservation, CreatedBookReservationResponse>().ReverseMap();
        CreateMap<BookReservation, UpdateBookReservationCommand>().ReverseMap();
        CreateMap<BookReservation, UpdatedBookReservationResponse>().ReverseMap();
        CreateMap<BookReservation, DeleteBookReservationCommand>().ReverseMap();
        CreateMap<BookReservation, DeletedBookReservationResponse>().ReverseMap();
        CreateMap<BookReservation, GetByIdBookReservationResponse>().ReverseMap();
        CreateMap<BookReservation, GetListBookReservationListItemDto>().ReverseMap();
        CreateMap<IPaginate<BookReservation>, GetListResponse<GetListBookReservationListItemDto>>().ReverseMap();
    }
}