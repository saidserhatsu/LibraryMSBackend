using Application.Services.Announcements;
using Application.Services.AuthenticatorService;
using Application.Services.Authors;
using Application.Services.AuthService;
using Application.Services.BookAuthors;
using Application.Services.BookIssues;
using Application.Services.BookReservations;
using Application.Services.Books;
using Application.Services.CatalogManagements;
using Application.Services.Catalogs;
using Application.Services.Categories;
using Application.Services.EBooks;
using Application.Services.FavoriteBooks;
using Application.Services.FineDues;
using Application.Services.FinePayments;
using Application.Services.LibraryStaffs;
using Application.Services.Locations;
using Application.Services.MagazineAuthors;
using Application.Services.Magazines;
using Application.Services.MaterialAuthors;
using Application.Services.Materials;
using Application.Services.Members;
using Application.Services.MemberSettings;
using Application.Services.OperationClaims;
using Application.Services.Publishers;
using Application.Services.SearchCriterias;
using Application.Services.UserOperationClaims;
using Application.Services.UsersService;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using NArchitecture.Core.Application.Pipelines.Validation;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Logging.Abstraction;
using NArchitecture.Core.CrossCuttingConcerns.Logging.Configurations;
using NArchitecture.Core.CrossCuttingConcerns.Logging.Serilog.File;
using NArchitecture.Core.ElasticSearch;
using NArchitecture.Core.ElasticSearch.Models;
using NArchitecture.Core.Localization.Resource.Yaml.DependencyInjection;
using NArchitecture.Core.Mailing;
using NArchitecture.Core.Mailing.MailKit;
using NArchitecture.Core.Security.DependencyInjection;
using NArchitecture.Core.Security.JWT;
using System.Reflection;
using Application.Services.FeedBacks;

namespace Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services,
        MailSettings mailSettings,
        FileLogConfiguration fileLogConfiguration,
        ElasticSearchConfig elasticSearchConfig,
        TokenOptions tokenOptions
    )
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            configuration.AddOpenBehavior(typeof(AuthorizationBehavior<,>));
            configuration.AddOpenBehavior(typeof(CachingBehavior<,>));
            configuration.AddOpenBehavior(typeof(CacheRemovingBehavior<,>));
            configuration.AddOpenBehavior(typeof(LoggingBehavior<,>));
            configuration.AddOpenBehavior(typeof(RequestValidationBehavior<,>));
            configuration.AddOpenBehavior(typeof(TransactionScopeBehavior<,>));
        });

        services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddSingleton<IMailService, MailKitMailService>(_ => new MailKitMailService(mailSettings));
        services.AddSingleton<ILogger, SerilogFileLogger>(_ => new SerilogFileLogger(fileLogConfiguration));
        services.AddSingleton<IElasticSearch, ElasticSearchManager>(_ => new ElasticSearchManager(elasticSearchConfig));

        services.AddScoped<IAuthService, AuthManager>();
        services.AddScoped<IAuthenticatorService, AuthenticatorManager>();
        services.AddScoped<IUserService, UserManager>();

        services.AddYamlResourceLocalization();

        //services.AddSecurityServices<Guid, int>();
        services.AddSecurityServices<Guid, int, Guid>(tokenOptions);

        //services.AddSecurityServices

        services.AddScoped<IAuthorService, AuthorManager>();
        services.AddScoped<IBookService, BookManager>();
        services.AddScoped<IBookAuthorService, BookAuthorManager>();
        services.AddScoped<IBookIssueService, BookIssueManager>();
        services.AddScoped<IBookReservationService, BookReservationManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<IFineDueService, FineDueManager>();
        services.AddScoped<IFinePaymentService, FinePaymentManager>();
        services.AddScoped<ILibraryStaffService, LibraryStaffManager>();
        services.AddScoped<ILocationService, LocationManager>();
        services.AddScoped<IMemberService, MemberManager>();
        services.AddScoped<IPublisherService, PublisherManager>();
        services.AddScoped<IAnnouncementService, AnnouncementManager>();
        services.AddScoped<IOperationClaimService, OperationClaimManager>();
        services.AddScoped<IUserOperationClaimService, UserUserOperationClaimManager>();
        services.AddScoped<ICatalogService, CatalogManager>();
        services.AddScoped<IEBookService, EBookManager>();
        services.AddScoped<IMagazineService, MagazineManager>();
        services.AddScoped<IMaterialService, MaterialManager>();
        services.AddScoped<IMagazineAuthorService, MagazineAuthorManager>();
        services.AddScoped<IMaterialAuthorService, MaterialAuthorManager>();
        services.AddScoped<IMemberSettingService, MemberSettingManager>();
        services.AddScoped<ICatalogManagementService, CatalogManagementManager>();

        services.AddScoped<ISearchCriteriaService, SearchCriteriaManager>();
        services.AddScoped<IEBookService, EBookManager>();
        services.AddScoped<ICatalogManagementService, CatalogManagementManager>();
        services.AddScoped<ICatalogManagementService, CatalogManagementManager>();
        services.AddScoped<IEBookService, EBookManager>();
        services.AddScoped<IFavoriteBookService, FavoriteBookManager>();
        services.AddScoped<IFeedBackService, FeedBackManager>();
        services.AddScoped<IFeedBackService, FeedBackManager>();
        return services;
    }

    public static IServiceCollection AddSubClassesOfType(
        this IServiceCollection services,
        Assembly assembly,
        Type type,
        Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null
    )
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
        foreach (Type? item in types)
            if (addWithLifeCycle == null)
                services.AddScoped(item);
            else
                addWithLifeCycle(services, type);
        return services;
    }
}
