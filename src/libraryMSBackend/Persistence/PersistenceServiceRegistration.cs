using Application.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NArchitecture.Core.Persistence.DependencyInjection;
using Persistence.Contexts;
using Persistence.Repositories;

namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BaseDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("BaseDb")));
        services.AddDbMigrationApplier(buildServices => buildServices.GetRequiredService<BaseDbContext>());

        services.AddScoped<IEmailAuthenticatorRepository, EmailAuthenticatorRepository>();
        services.AddScoped<IOperationClaimRepository, OperationClaimRepository>();
        services.AddScoped<IOtpAuthenticatorRepository, OtpAuthenticatorRepository>();
        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserOperationClaimRepository, UserOperationClaimRepository>();
        services.AddScoped<IMemberRepository, MemberRepository>();
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        services.AddScoped<IBookAuthorRepository, BookAuthorRepository>();
        services.AddScoped<IBookIssueRepository, BookIssueRepository>();
        services.AddScoped<IBookReservationRepository, BookReservationRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IFineDueRepository, FineDueRepository>();
        services.AddScoped<IFinePaymentRepository, FinePaymentRepository>();
        services.AddScoped<ILibraryStaffRepository, LibraryStaffRepository>();
        services.AddScoped<ILocationRepository, LocationRepository>();
        services.AddScoped<IPublisherRepository, PublisherRepository>();
        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
        services.AddScoped<IEBookRepository, EBookRepository>();
        services.AddScoped<IMagazineAuthorRepository, MagazineAuthorRepository>();
        services.AddScoped<IMaterialAuthorRepository, MaterialAuthorRepository>();
        services.AddScoped<IMemberSettingRepository, MemberSettingRepository>();
        services.AddScoped<ICatalogRepository, CatalogRepository>();
        services.AddScoped<ICatalogManagementRepository, CatalogManagementRepository>();
        services.AddScoped<IMagazineRepository, MagazineRepository>();
        services.AddScoped<IMaterialRepository, MaterialRepository>();
        services.AddScoped<ISearchCriteriaRepository, SearchCriteriaRepository>();
        return services;
    }
}
