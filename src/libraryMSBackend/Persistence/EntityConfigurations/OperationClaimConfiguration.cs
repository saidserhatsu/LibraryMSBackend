using Application.Features.Auth.Constants;
using Application.Features.OperationClaims.Constants;
using Application.Features.UserOperationClaims.Constants;
using Application.Features.Users.Constants;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NArchitecture.Core.Security.Constants;
using Application.Features.Authors.Constants;
using Application.Features.Books.Constants;
using Application.Features.BookAuthors.Constants;
using Application.Features.BookIssues.Constants;
using Application.Features.BookReservations.Constants;
using Application.Features.Categories.Constants;
using Application.Features.FineDues.Constants;
using Application.Features.FinePayments.Constants;
using Application.Features.LibraryStaffs.Constants;
using Application.Features.Locations.Constants;
using Application.Features.Members.Constants;
using Application.Features.Publishers.Constants;

namespace Persistence.EntityConfigurations;

public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperationClaims").HasKey(oc => oc.Id);

        builder.Property(oc => oc.Id).HasColumnName("Id").IsRequired();
        builder.Property(oc => oc.Name).HasColumnName("Name").IsRequired();
        builder.Property(oc => oc.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(oc => oc.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(oc => oc.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(oc => !oc.DeletedDate.HasValue);

        builder.HasData(_seeds);

        builder.HasBaseType((string)null!);
    }

    public static int AdminId => 1;
    private IEnumerable<OperationClaim> _seeds
    {
        get
        {
            yield return new() { Id = AdminId, Name = GeneralOperationClaims.Admin };

            IEnumerable<OperationClaim> featureOperationClaims = getFeatureOperationClaims(AdminId);
            foreach (OperationClaim claim in featureOperationClaims)
                yield return claim;
        }
    }

#pragma warning disable S1854 // Unused assignments should be removed
    private IEnumerable<OperationClaim> getFeatureOperationClaims(int initialId)
    {
        int lastId = initialId;
        List<OperationClaim> featureOperationClaims = new();

        #region Auth
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = AuthOperationClaims.Admin },
                new() { Id = ++lastId, Name = AuthOperationClaims.Read },
                new() { Id = ++lastId, Name = AuthOperationClaims.Write },
                new() { Id = ++lastId, Name = AuthOperationClaims.RevokeToken },
            ]
        );
        #endregion

        #region OperationClaims
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Admin },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Read },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Write },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Create },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Update },
                new() { Id = ++lastId, Name = OperationClaimsOperationClaims.Delete },
            ]
        );
        #endregion

        #region UserOperationClaims
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Admin },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Read },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Write },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Create },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Update },
                new() { Id = ++lastId, Name = UserOperationClaimsOperationClaims.Delete },
            ]
        );
        #endregion

        #region Users
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = UsersOperationClaims.Admin },
                new() { Id = ++lastId, Name = UsersOperationClaims.Read },
                new() { Id = ++lastId, Name = UsersOperationClaims.Write },
                new() { Id = ++lastId, Name = UsersOperationClaims.Create },
                new() { Id = ++lastId, Name = UsersOperationClaims.Update },
                new() { Id = ++lastId, Name = UsersOperationClaims.Delete },
            ]
        );
        #endregion

        
        #region Authors
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = AuthorsOperationClaims.Admin },
                new() { Id = ++lastId, Name = AuthorsOperationClaims.Read },
                new() { Id = ++lastId, Name = AuthorsOperationClaims.Write },
                new() { Id = ++lastId, Name = AuthorsOperationClaims.Create },
                new() { Id = ++lastId, Name = AuthorsOperationClaims.Update },
                new() { Id = ++lastId, Name = AuthorsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Books
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = BooksOperationClaims.Admin },
                new() { Id = ++lastId, Name = BooksOperationClaims.Read },
                new() { Id = ++lastId, Name = BooksOperationClaims.Write },
                new() { Id = ++lastId, Name = BooksOperationClaims.Create },
                new() { Id = ++lastId, Name = BooksOperationClaims.Update },
                new() { Id = ++lastId, Name = BooksOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region BookAuthors
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = BookAuthorsOperationClaims.Admin },
                new() { Id = ++lastId, Name = BookAuthorsOperationClaims.Read },
                new() { Id = ++lastId, Name = BookAuthorsOperationClaims.Write },
                new() { Id = ++lastId, Name = BookAuthorsOperationClaims.Create },
                new() { Id = ++lastId, Name = BookAuthorsOperationClaims.Update },
                new() { Id = ++lastId, Name = BookAuthorsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region BookIssues
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = BookIssuesOperationClaims.Admin },
                new() { Id = ++lastId, Name = BookIssuesOperationClaims.Read },
                new() { Id = ++lastId, Name = BookIssuesOperationClaims.Write },
                new() { Id = ++lastId, Name = BookIssuesOperationClaims.Create },
                new() { Id = ++lastId, Name = BookIssuesOperationClaims.Update },
                new() { Id = ++lastId, Name = BookIssuesOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region BookReservations
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = BookReservationsOperationClaims.Admin },
                new() { Id = ++lastId, Name = BookReservationsOperationClaims.Read },
                new() { Id = ++lastId, Name = BookReservationsOperationClaims.Write },
                new() { Id = ++lastId, Name = BookReservationsOperationClaims.Create },
                new() { Id = ++lastId, Name = BookReservationsOperationClaims.Update },
                new() { Id = ++lastId, Name = BookReservationsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Categories
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = CategoriesOperationClaims.Admin },
                new() { Id = ++lastId, Name = CategoriesOperationClaims.Read },
                new() { Id = ++lastId, Name = CategoriesOperationClaims.Write },
                new() { Id = ++lastId, Name = CategoriesOperationClaims.Create },
                new() { Id = ++lastId, Name = CategoriesOperationClaims.Update },
                new() { Id = ++lastId, Name = CategoriesOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region FineDues
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = FineDuesOperationClaims.Admin },
                new() { Id = ++lastId, Name = FineDuesOperationClaims.Read },
                new() { Id = ++lastId, Name = FineDuesOperationClaims.Write },
                new() { Id = ++lastId, Name = FineDuesOperationClaims.Create },
                new() { Id = ++lastId, Name = FineDuesOperationClaims.Update },
                new() { Id = ++lastId, Name = FineDuesOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region FinePayments
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = FinePaymentsOperationClaims.Admin },
                new() { Id = ++lastId, Name = FinePaymentsOperationClaims.Read },
                new() { Id = ++lastId, Name = FinePaymentsOperationClaims.Write },
                new() { Id = ++lastId, Name = FinePaymentsOperationClaims.Create },
                new() { Id = ++lastId, Name = FinePaymentsOperationClaims.Update },
                new() { Id = ++lastId, Name = FinePaymentsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region LibraryStaffs
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = LibraryStaffsOperationClaims.Admin },
                new() { Id = ++lastId, Name = LibraryStaffsOperationClaims.Read },
                new() { Id = ++lastId, Name = LibraryStaffsOperationClaims.Write },
                new() { Id = ++lastId, Name = LibraryStaffsOperationClaims.Create },
                new() { Id = ++lastId, Name = LibraryStaffsOperationClaims.Update },
                new() { Id = ++lastId, Name = LibraryStaffsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Locations
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = LocationsOperationClaims.Admin },
                new() { Id = ++lastId, Name = LocationsOperationClaims.Read },
                new() { Id = ++lastId, Name = LocationsOperationClaims.Write },
                new() { Id = ++lastId, Name = LocationsOperationClaims.Create },
                new() { Id = ++lastId, Name = LocationsOperationClaims.Update },
                new() { Id = ++lastId, Name = LocationsOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Members
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = MembersOperationClaims.Admin },
                new() { Id = ++lastId, Name = MembersOperationClaims.Read },
                new() { Id = ++lastId, Name = MembersOperationClaims.Write },
                new() { Id = ++lastId, Name = MembersOperationClaims.Create },
                new() { Id = ++lastId, Name = MembersOperationClaims.Update },
                new() { Id = ++lastId, Name = MembersOperationClaims.Delete },
            ]
        );
        #endregion
        
        
        #region Publishers
        featureOperationClaims.AddRange(
            [
                new() { Id = ++lastId, Name = PublishersOperationClaims.Admin },
                new() { Id = ++lastId, Name = PublishersOperationClaims.Read },
                new() { Id = ++lastId, Name = PublishersOperationClaims.Write },
                new() { Id = ++lastId, Name = PublishersOperationClaims.Create },
                new() { Id = ++lastId, Name = PublishersOperationClaims.Update },
                new() { Id = ++lastId, Name = PublishersOperationClaims.Delete },
            ]
        );
        #endregion
        
        return featureOperationClaims;
    }
#pragma warning restore S1854 // Unused assignments should be removed
}
