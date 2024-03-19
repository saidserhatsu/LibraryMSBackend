using Application.Features.FinePayments.Commands.Create;
using Application.Features.FinePayments.Commands.Delete;
using Application.Features.FinePayments.Commands.Update;
using Application.Features.FinePayments.Queries.GetById;
using Application.Features.FinePayments.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.FinePayments.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<FinePayment, CreateFinePaymentCommand>().ReverseMap();
        CreateMap<FinePayment, CreatedFinePaymentResponse>().ReverseMap();
        CreateMap<FinePayment, UpdateFinePaymentCommand>().ReverseMap();
        CreateMap<FinePayment, UpdatedFinePaymentResponse>().ReverseMap();
        CreateMap<FinePayment, DeleteFinePaymentCommand>().ReverseMap();
        CreateMap<FinePayment, DeletedFinePaymentResponse>().ReverseMap();
        CreateMap<FinePayment, GetByIdFinePaymentResponse>().ReverseMap();
        CreateMap<FinePayment, GetListFinePaymentListItemDto>().ReverseMap();
        CreateMap<IPaginate<FinePayment>, GetListResponse<GetListFinePaymentListItemDto>>().ReverseMap();
    }
}