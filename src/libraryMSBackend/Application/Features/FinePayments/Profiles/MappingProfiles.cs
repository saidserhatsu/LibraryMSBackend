using Application.Features.FinePayments.Commands.Create;
using Application.Features.FinePayments.Commands.Delete;
using Application.Features.FinePayments.Commands.Update;
using Application.Features.FinePayments.Queries.GetById;
using Application.Features.FinePayments.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using Application.Features.Categories.Queries.FilterSearch;
using Application.Features.FinePayments.Queries.FilterSearch;

namespace Application.Features.FinePayments.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Düzeltme: FinePayment'ý farklý türlere doðru þekilde eþle
        CreateMap<FinePayment, CreateFinePaymentCommand>().ReverseMap();
        CreateMap<FinePayment, CreatedFinePaymentResponse>().ReverseMap();
        CreateMap<FinePayment, UpdateFinePaymentCommand>().ReverseMap();
        CreateMap<FinePayment, UpdatedFinePaymentResponse>().ReverseMap();
        CreateMap<FinePayment, DeleteFinePaymentCommand>().ReverseMap();
        CreateMap<FinePayment, DeletedFinePaymentResponse>().ReverseMap();
        CreateMap<FinePayment, GetByIdFinePaymentResponse>().ReverseMap();
        CreateMap<FinePayment, GetListFinePaymentListItemDto>().ReverseMap();

        // Düzeltme: SearchFinePaymentResponse için doðru haritalama
        CreateMap<FinePayment, SearchFinePaymentResponse>()
            .ForMember(dest => dest.MemberFirstName, opt => opt.MapFrom(src => src.Member.FirstName))
            .ForMember(dest => dest.MemberLastName, opt => opt.MapFrom(src => src.Member.LastName));

        // Düzeltme: GetListResponse için her tür ile uygun haritalama
        CreateMap<IPaginate<FinePayment>, GetListResponse<GetListFinePaymentListItemDto>>().ReverseMap();
        CreateMap<IPaginate<FinePayment>, GetListResponse<SearchFinePaymentResponse>>().ReverseMap(); // Bu farklý tür için olmalý
    }
}