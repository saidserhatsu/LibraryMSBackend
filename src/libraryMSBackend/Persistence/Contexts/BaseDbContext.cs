using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Contexts;

public class BaseDbContext : DbContext
{
    protected IConfiguration Configuration { get; set; }
    public DbSet<EmailAuthenticator> EmailAuthenticators { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<OtpAuthenticator> OtpAuthenticators { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<BookIssue> BookIssues { get; set; }
    public DbSet<BookReservation> BookReservations { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<FineDue> FineDues { get; set; }
    public DbSet<FinePayment> FinePayments { get; set; }
    public DbSet<LibraryStaff> LibraryStaffs { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<MaterialAuthor> MaterialAuthors { get; set; }
    public DbSet<Catalog> Catalogs { get; set; }
    public DbSet<EBook> EBooks { get; set; }
    public DbSet<Magazine> Magazines { get; set; }
    public DbSet<MagazineAuthor> MagazineAuthors { get; set; }
    public DbSet<MemberSetting> MemberSettings { get; set; }
    public DbSet<CatalogManagement> CatalogManagements { get; set; }
    public DbSet<SearchCriteria> SearchCriterias { get; set; }
    public DbSet<FavoriteBook> FavoriteBooks { get; set; }
    public DbSet<FeedBack> FeedBacks { get; set; }

    public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration)
        : base(dbContextOptions)
    {
        Configuration = configuration;
    }

    public BaseDbContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
