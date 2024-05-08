using Application.Features.BookIssues.Queries.GetList;
using Application.Features.BookReservations.Queries.GetList;
using Application.Features.Books.Queries.GetList;
using Application.Features.FavoriteBooks.Queries.GetList;
using Application.Features.FineDues.Queries.GetList;
using Application.Features.FinePayments.Queries.GetList;
using Application.Features.MemberSettings.Queries.GetList;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Members.Queries.GetById;

public class GetByIdMemberResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ImageUrl { get; set; }
    public bool Subscribe { get; set; }

    public GetListMemberSettingListItemDto MemberSetting { get; set; }
    public List<GetListBookListItemDto> Books { get; set; }
    public List<GetListFavoriteBookListItemDto> FavoriteBooks { get; set; }
    public List<GetListBookIssueListItemDto> Bookýssues { get; set; }
    public List<GetListBookReservationListItemDto> Reservations { get; set; }
    public List<GetListFineDueListItemDto> FineDues { get; set; }

    public List<GetListFinePaymentListItemDto> FinePayments { get; set; }

}