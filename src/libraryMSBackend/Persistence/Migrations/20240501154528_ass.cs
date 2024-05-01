using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShelfNo = table.Column<int>(type: "int", nullable: false),
                    FloorNo = table.Column<int>(type: "int", nullable: false),
                    ShelfName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SearchCriterias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MagazineISSNCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookISBNCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationsShelfName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembersEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchCriterias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AuthenticatorType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ISBNCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EBookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EBooks_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ISBNCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookEdition = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Magazines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ISSNCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MagazineTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Magazines_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Magazines_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialType = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Materials_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailAuthenticators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivationKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAuthenticators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAuthenticators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LibraryStaffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryStaffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryStaffs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Subscribe = table.Column<bool>(type: "bit", nullable: false),
                    MemberSettingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_Users_MemberSettingId",
                        column: x => x.MemberSettingId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtpAuthenticators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SecretKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpAuthenticators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OtpAuthenticators_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiresDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RevokedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RevokedByIp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonRevoked = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MagazineAuthors",
                columns: table => new
                {
                    MagazineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagazineAuthors", x => new { x.AuthorId, x.MagazineId });
                    table.ForeignKey(
                        name: "FK_MagazineAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MagazineAuthors_Magazines_MagazineId",
                        column: x => x.MagazineId,
                        principalTable: "Magazines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatalogManagements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MagazineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CatalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatalogManagements_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CatalogManagements_Catalogs_CatalogId",
                        column: x => x.CatalogId,
                        principalTable: "Catalogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatalogManagements_EBooks_EBookId",
                        column: x => x.EBookId,
                        principalTable: "EBooks",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CatalogManagements_Magazines_MagazineId",
                        column: x => x.MagazineId,
                        principalTable: "Magazines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CatalogManagements_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MaterialAuthors",
                columns: table => new
                {
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialAuthors", x => new { x.AuthorId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_MaterialAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialAuthors_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookIssues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LibraryStaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookIssues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookIssues_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookIssues_LibraryStaffs_LibraryStaffId",
                        column: x => x.LibraryStaffId,
                        principalTable: "LibraryStaffs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookIssues_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BookReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NearestAvailableDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookReservations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookReservations_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinePayments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinePayments_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UiTheme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberSettings_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FineDues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FineTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookIssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FineDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FineDues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FineDues_BookIssues_BookIssueId",
                        column: x => x.BookIssueId,
                        principalTable: "BookIssues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "Content", "CreatedDate", "DeletedDate", "Tag", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"), "Content 1", new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(2451), null, 0, "Kütüphane Üyelikleri", null },
                    { new Guid("7085aa16-5230-42ca-941b-6d73c692053b"), "Content 6", new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(2464), null, 0, "Kütüphane Açılış Saatleri", null },
                    { new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"), "Content 5", new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(2463), null, 1, "Bayramlaşma", null },
                    { new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"), "Content 4", new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(2461), null, 1, "Yeni Yıl Etkinliği", null },
                    { new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"), "Content 2", new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(2459), null, 1, "Hıdırellez Yarışması", null },
                    { new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"), "Content 3", new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(2460), null, 2, "Yeni Kitaplar", null }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4879), null, "Burak", "Turna", null },
                    { new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4873), null, "Fyodor", "Dostoyevski", null },
                    { new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4883), null, "Oğuz", "Atay", null },
                    { new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4887), null, "Vedat", "Türkali", null },
                    { new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4901), null, "Aziz", "Nesin", null },
                    { new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4889), null, "Jack", "London", null },
                    { new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4881), null, "Sabahattin", "Ali", null },
                    { new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4899), null, "Ahmet Hamdi", "Tanpınar", null },
                    { new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4870), null, "Mustafa Kemal", "Atatürk", null },
                    { new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4885), null, "Yusuf", "Atılgan", null },
                    { new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4891), null, "Reşat Nuri", "Güntekin", null },
                    { new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4878), null, "Orkun", "Uçar", null },
                    { new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4893), null, "Yaşar", "Kemal", null },
                    { new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4898), null, "Grigory", "Petrov", null },
                    { new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4894), null, "Emrah", "Serbes", null },
                    { new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"), new DateTime(2024, 5, 1, 15, 45, 28, 227, DateTimeKind.Utc).AddTicks(4876), null, "Sun", "Tzu", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4909), null, "Edebiyat", null },
                    { 2, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4912), null, "Tarih", null },
                    { 3, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4913), null, "Roman", null },
                    { 4, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4915), null, "Psikoloji", null },
                    { 5, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4916), null, "Felsefe", null },
                    { 6, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4917), null, "Bilim Kurgu", null },
                    { 7, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4919), null, "Fantastik", null },
                    { 8, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4949), null, "Polisiye", null },
                    { 9, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4950), null, "Macera", null },
                    { 10, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4952), null, "Aşk", null },
                    { 11, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4953), null, "Çocuk", null },
                    { 12, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4955), null, "Biyografi", null },
                    { 13, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4956), null, "Otobiyografi", null },
                    { 14, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4957), null, "Gezi", null },
                    { 15, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4959), null, "Sanat", null },
                    { 16, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4960), null, "Mimari", null },
                    { 17, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4962), null, "Müzik", null },
                    { 18, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4963), null, "Tiyatro", null },
                    { 19, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4965), null, "Dans", null },
                    { 20, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4966), null, "Sinema", null },
                    { 21, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4967), null, "Şiir", null },
                    { 22, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4969), null, "Antoloji", null },
                    { 23, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4970), null, "Yemek", null },
                    { 24, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4972), null, "Sağlık", null },
                    { 25, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4973), null, "Tıp", null },
                    { 26, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4974), null, "Eğitim", null },
                    { 27, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4976), null, "Ekonomi", null },
                    { 28, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4977), null, "İş Dünyası", null },
                    { 29, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(4978), null, "Hukuk", null },
                    { 30, new DateTime(2024, 5, 1, 15, 45, 28, 230, DateTimeKind.Utc).AddTicks(5029), null, "Politika", null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FloorNo", "Name", "ShelfName", "ShelfNo", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3180), null, 3, "Merkez Kütüphane", "Sanat ve Tasarım Kitapları", 5, null },
                    { new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3170), null, 2, "Merkez Kütüphane", "Felsefe Kitapları", 4, null },
                    { new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3162), null, 1, "Merkez Kütüphane", "Roman Kitapları", 4, null },
                    { new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3172), null, 2, "Merkez Kütüphane", "İşletme Kitapları", 5, null },
                    { new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3138), null, 1, "Merkez Kütüphane", "Psikoloji Kitapları", 2, null },
                    { new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3135), null, 1, "Merkez Kütüphane", "Tarih Kitapları", 1, null },
                    { new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3140), null, 1, "Merkez Kütüphane", "Edebiyat Kitapları", 3, null },
                    { new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3175), null, 3, "Merkez Kütüphane", "Hukuk Kitapları", 2, null },
                    { new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3178), null, 3, "Merkez Kütüphane", "Müzik Kitapları", 4, null },
                    { new Guid("9466485b-9c11-433a-b384-7d6382333193"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3165), null, 2, "Merkez Kütüphane", "Mimarlık Kitapları", 1, null },
                    { new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3167), null, 2, "Merkez Kütüphane", "Bilim Kitapları", 2, null },
                    { new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3173), null, 3, "Merkez Kütüphane", "Ekonomi Kitapları", 1, null },
                    { new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3169), null, 2, "Merkez Kütüphane", "Teknoloji Kitapları", 3, null },
                    { new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3177), null, 3, "Merkez Kütüphane", "Medya ve İletişim Kitapları", 3, null },
                    { new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"), new DateTime(2024, 5, 1, 15, 45, 28, 232, DateTimeKind.Utc).AddTicks(3163), null, 1, "Merkez Kütüphane", "Sanat Kitapları", 5, null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auth.Admin", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auth.Read", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auth.Write", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Auth.RevokeToken", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OperationClaims.Admin", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OperationClaims.Read", null },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OperationClaims.Write", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OperationClaims.Create", null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OperationClaims.Update", null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "OperationClaims.Delete", null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "UserOperationClaims.Admin", null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "UserOperationClaims.Read", null },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "UserOperationClaims.Write", null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "UserOperationClaims.Create", null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "UserOperationClaims.Update", null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "UserOperationClaims.Delete", null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Users.Admin", null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Users.Read", null },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Users.Write", null },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Users.Create", null },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Users.Update", null },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Users.Delete", null },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Admin", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Read", null },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Write", null },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Create", null },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Update", null },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Authors.Delete", null },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Admin", null },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Read", null },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Write", null },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Create", null },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Update", null },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Delete", null },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookAuthors.Admin", null },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookAuthors.Read", null },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookAuthors.Write", null },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookAuthors.Create", null },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookAuthors.Update", null },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookAuthors.Delete", null },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookIssues.Admin", null },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookIssues.Read", null },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookIssues.Write", null },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookIssues.Create", null },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookIssues.Update", null },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookIssues.Delete", null },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookReservations.Admin", null },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookReservations.Read", null },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookReservations.Write", null },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookReservations.Create", null },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookReservations.Update", null },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BookReservations.Delete", null },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Admin", null },
                    { 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Read", null },
                    { 56, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Write", null },
                    { 57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Create", null },
                    { 58, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Update", null },
                    { 59, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Delete", null },
                    { 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FineDues.Admin", null },
                    { 61, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FineDues.Read", null },
                    { 62, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FineDues.Write", null },
                    { 63, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FineDues.Create", null },
                    { 64, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FineDues.Update", null },
                    { 65, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FineDues.Delete", null },
                    { 66, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FinePayments.Admin", null },
                    { 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FinePayments.Read", null },
                    { 68, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FinePayments.Write", null },
                    { 69, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FinePayments.Create", null },
                    { 70, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FinePayments.Update", null },
                    { 71, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FinePayments.Delete", null },
                    { 72, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LibraryStaffs.Admin", null },
                    { 73, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LibraryStaffs.Read", null },
                    { 74, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LibraryStaffs.Write", null },
                    { 75, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LibraryStaffs.Create", null },
                    { 76, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LibraryStaffs.Update", null },
                    { 77, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LibraryStaffs.Delete", null },
                    { 78, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Admin", null },
                    { 79, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Read", null },
                    { 80, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Write", null },
                    { 81, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Create", null },
                    { 82, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Update", null },
                    { 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Delete", null },
                    { 84, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Admin", null },
                    { 85, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Read", null },
                    { 86, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Write", null },
                    { 87, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Create", null },
                    { 88, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Update", null },
                    { 89, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Members.Delete", null },
                    { 90, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Admin", null },
                    { 91, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Read", null },
                    { 92, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Write", null },
                    { 93, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Create", null },
                    { 94, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Update", null },
                    { 95, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Publishers.Delete", null },
                    { 96, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Admin", null },
                    { 97, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Read", null },
                    { 98, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Write", null },
                    { 99, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Create", null },
                    { 100, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Update", null },
                    { 101, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Delete", null },
                    { 102, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Admin", null },
                    { 103, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Read", null },
                    { 104, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Write", null },
                    { 105, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Create", null },
                    { 106, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Update", null },
                    { 107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Delete", null },
                    { 108, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Admin", null },
                    { 109, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Read", null },
                    { 110, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Write", null },
                    { 111, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Create", null },
                    { 112, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Update", null },
                    { 113, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Delete", null },
                    { 114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Admin", null },
                    { 115, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Read", null },
                    { 116, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Write", null },
                    { 117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Create", null },
                    { 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Update", null },
                    { 119, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Delete", null },
                    { 120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Admin", null },
                    { 121, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Read", null },
                    { 122, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Write", null },
                    { 123, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Create", null },
                    { 124, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Update", null },
                    { 125, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Announcements.Delete", null },
                    { 126, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Admin", null },
                    { 127, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Read", null },
                    { 128, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Write", null },
                    { 129, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Create", null },
                    { 130, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Update", null },
                    { 131, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Delete", null },
                    { 132, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Admin", null },
                    { 133, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Read", null },
                    { 134, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Write", null },
                    { 135, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Create", null },
                    { 136, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Update", null },
                    { 137, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Delete", null },
                    { 138, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Admin", null },
                    { 139, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Read", null },
                    { 140, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Write", null },
                    { 141, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Create", null },
                    { 142, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Update", null },
                    { 143, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Delete", null },
                    { 144, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Admin", null },
                    { 145, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Read", null },
                    { 146, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Write", null },
                    { 147, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Create", null },
                    { 148, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Update", null },
                    { 149, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Delete", null },
                    { 150, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Admin", null },
                    { 151, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Read", null },
                    { 152, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Write", null },
                    { 153, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Create", null },
                    { 154, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Update", null },
                    { 155, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Delete", null },
                    { 156, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Admin", null },
                    { 157, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Read", null },
                    { 158, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Write", null },
                    { 159, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Create", null },
                    { 160, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Update", null },
                    { 161, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Books.Delete", null },
                    { 162, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Admin", null },
                    { 163, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Read", null },
                    { 164, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Write", null },
                    { 165, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Create", null },
                    { 166, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Update", null },
                    { 167, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Delete", null },
                    { 168, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Admin", null },
                    { 169, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Read", null },
                    { 170, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Write", null },
                    { 171, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Create", null },
                    { 172, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Update", null },
                    { 173, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Delete", null },
                    { 174, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Admin", null },
                    { 175, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Read", null },
                    { 176, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Write", null },
                    { 177, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Create", null },
                    { 178, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Update", null },
                    { 179, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Delete", null },
                    { 180, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Admin", null },
                    { 181, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Read", null },
                    { 182, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Write", null },
                    { 183, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Create", null },
                    { 184, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Update", null },
                    { 185, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Delete", null },
                    { 186, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Admin", null },
                    { 187, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Read", null },
                    { 188, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Write", null },
                    { 189, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Create", null },
                    { 190, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Update", null },
                    { 191, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Delete", null },
                    { 192, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Admin", null },
                    { 193, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Read", null },
                    { 194, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Write", null },
                    { 195, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Create", null },
                    { 196, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Update", null },
                    { 197, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Delete", null },
                    { 198, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Admin", null },
                    { 199, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Read", null },
                    { 200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Write", null },
                    { 201, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Create", null },
                    { 202, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Update", null },
                    { 203, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Delete", null },
                    { 204, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Admin", null },
                    { 205, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Read", null },
                    { 206, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Write", null },
                    { 207, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Create", null },
                    { 208, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Update", null },
                    { 209, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Delete", null },
                    { 210, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Admin", null },
                    { 211, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Read", null },
                    { 212, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Write", null },
                    { 213, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Create", null },
                    { 214, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Update", null },
                    { 215, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Categories.Delete", null },
                    { 216, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Admin", null },
                    { 217, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Read", null },
                    { 218, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Write", null },
                    { 219, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Create", null },
                    { 220, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Update", null },
                    { 221, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Delete", null },
                    { 222, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Admin", null },
                    { 223, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Read", null },
                    { 224, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Write", null },
                    { 225, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Create", null },
                    { 226, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Update", null },
                    { 227, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Delete", null },
                    { 228, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Admin", null },
                    { 229, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Read", null },
                    { 230, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Write", null },
                    { 231, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Create", null },
                    { 232, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Update", null },
                    { 233, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MagazineAuthors.Delete", null },
                    { 234, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Admin", null },
                    { 235, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Read", null },
                    { 236, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Write", null },
                    { 237, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Create", null },
                    { 238, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Update", null },
                    { 239, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Delete", null },
                    { 240, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Admin", null },
                    { 241, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Read", null },
                    { 242, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Write", null },
                    { 243, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Create", null },
                    { 244, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Update", null },
                    { 245, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MaterialAuthors.Delete", null },
                    { 246, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Admin", null },
                    { 247, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Read", null },
                    { 248, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Write", null },
                    { 249, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Create", null },
                    { 250, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Update", null },
                    { 251, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Delete", null },
                    { 252, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Admin", null },
                    { 253, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Read", null },
                    { 254, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Write", null },
                    { 255, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Create", null },
                    { 256, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Update", null },
                    { 257, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MemberSettings.Delete", null },
                    { 258, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Admin", null },
                    { 259, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Read", null },
                    { 260, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Write", null },
                    { 261, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Create", null },
                    { 262, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Update", null },
                    { 263, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Catalogs.Delete", null },
                    { 264, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Admin", null },
                    { 265, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Read", null },
                    { 266, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Write", null },
                    { 267, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Create", null },
                    { 268, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Update", null },
                    { 269, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Delete", null },
                    { 270, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Admin", null },
                    { 271, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Read", null },
                    { 272, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Write", null },
                    { 273, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Create", null },
                    { 274, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Update", null },
                    { 275, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Delete", null },
                    { 276, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Admin", null },
                    { 277, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Read", null },
                    { 278, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Write", null },
                    { 279, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Create", null },
                    { 280, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Update", null },
                    { 281, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Delete", null },
                    { 282, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Admin", null },
                    { 283, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Read", null },
                    { 284, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Write", null },
                    { 285, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Create", null },
                    { 286, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Update", null },
                    { 287, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Magazines.Delete", null },
                    { 288, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SearchCriterias.Admin", null },
                    { 289, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SearchCriterias.Read", null },
                    { 290, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SearchCriterias.Write", null },
                    { 291, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SearchCriterias.Create", null },
                    { 292, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SearchCriterias.Update", null },
                    { 293, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "SearchCriterias.Delete", null },
                    { 294, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Admin", null },
                    { 295, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Read", null },
                    { 296, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Write", null },
                    { 297, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Create", null },
                    { 298, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Update", null },
                    { 299, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Delete", null },
                    { 300, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Admin", null },
                    { 301, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Read", null },
                    { 302, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Write", null },
                    { 303, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Create", null },
                    { 304, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Update", null },
                    { 305, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Delete", null },
                    { 306, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Admin", null },
                    { 307, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Read", null },
                    { 308, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Write", null },
                    { 309, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Create", null },
                    { 310, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Update", null },
                    { 311, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CatalogManagements.Delete", null },
                    { 312, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Admin", null },
                    { 313, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Read", null },
                    { 314, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Write", null },
                    { 315, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Create", null },
                    { 316, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Update", null },
                    { 317, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "EBooks.Delete", null },
                    { 318, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FavoriteBooks.Admin", null },
                    { 319, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FavoriteBooks.Read", null },
                    { 320, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FavoriteBooks.Write", null },
                    { 321, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FavoriteBooks.Create", null },
                    { 322, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FavoriteBooks.Update", null },
                    { 323, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FavoriteBooks.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Language", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("124589ea-4803-490c-9c86-dd68e59b8825"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7652), null, "TR", "İletişim Yayınları", null },
                    { new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7670), null, "TR", "Epsilon Yayınları", null },
                    { new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7664), null, "TR", "Martı Yayınları", null },
                    { new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7667), null, "TR", "Artemis Yayınları", null },
                    { new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7668), null, "TR", "Pegasus Yayınları", null },
                    { new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7655), null, "TR", "Doğan Kitap", null },
                    { new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7659), null, "TR", "Everest Yayınları", null },
                    { new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7663), null, "TR", "Remzi Kitabevi", null },
                    { new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7643), null, "TR", "Kapra Yayıncılık", null },
                    { new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7662), null, "TR", "Koridor Yayıncılık", null },
                    { new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7660), null, "TR", "Destek Yayınları", null },
                    { new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7672), null, "TR", "İş Bankası Kültür Yayınları", null },
                    { new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7657), null, "TR", "Altın Kitaplar", null },
                    { new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7646), null, "TR", "Alfa Yayınları", null },
                    { new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7648), null, "TR", "Timaş Yayınları", null },
                    { new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7656), null, "TR", "Bilgi Yayınevi", null },
                    { new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7633), null, "TR", "Can Yayınları", null },
                    { new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7650), null, "TR", "YKY - Yapı Kredi Yayınları", null },
                    { new Guid("d72f299e-e695-49c5-94fb-79e382710b91"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7666), null, "TR", "İthaki Yayınları", null },
                    { new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"), new DateTime(2024, 5, 1, 15, 45, 28, 235, DateTimeKind.Utc).AddTicks(7671), null, "TR", "Altın Nokta Yayınevi", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("e221c928-db9e-4777-8b24-85f45c7cfe4d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 236, 62, 250, 49, 94, 224, 218, 50, 121, 67, 82, 21, 78, 253, 30, 134, 152, 40, 71, 189, 164, 145, 132, 138, 26, 244, 149, 3, 122, 67, 143, 29, 105, 233, 38, 155, 158, 156, 33, 27, 67, 233, 214, 168, 73, 231, 253, 88, 236, 131, 152, 243, 16, 179, 84, 7, 107, 37, 219, 86, 170, 110, 114, 162 }, new byte[] { 27, 38, 155, 198, 26, 47, 227, 203, 14, 94, 117, 12, 65, 180, 161, 115, 216, 8, 105, 174, 4, 30, 248, 54, 241, 150, 64, 55, 224, 214, 46, 119, 33, 96, 19, 46, 39, 85, 21, 117, 61, 112, 155, 187, 32, 202, 232, 131, 254, 162, 94, 73, 234, 227, 225, 194, 4, 223, 58, 202, 119, 60, 207, 116, 253, 150, 124, 15, 30, 118, 151, 180, 8, 108, 72, 12, 162, 227, 57, 49, 129, 32, 167, 191, 181, 121, 14, 9, 163, 35, 75, 130, 174, 31, 102, 189, 197, 146, 146, 158, 139, 124, 83, 145, 186, 128, 249, 250, 127, 117, 102, 17, 206, 192, 27, 193, 35, 9, 207, 119, 230, 34, 64, 206, 197, 66, 197, 246 }, null });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookEdition", "BookTitle", "CategoryId", "CreatedDate", "DeletedDate", "ISBNCode", "ImageUrl", "LocationId", "PageCount", "PublisherId", "ReleaseDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"), 1, "Çalıkuşu", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4242), null, "9786051414315", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 280, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 1922, 1, null },
                    { new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"), 1, "Nutuk", 2, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4187), null, "9789944888349", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"), 343, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), 1977, 1, null },
                    { new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"), 1, "İnce Memed", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4246), null, "9789754709117", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 440, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 1955, 1, null },
                    { new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"), 1, "Aylak Adam", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4232), null, "9789750805158", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 176, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), 1959, 1, null },
                    { new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"), 1, "Beyaz Diş", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4239), null, "9786052954018", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 240, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 1906, 1, null },
                    { new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"), 1, "Yaşar Ne Yaşar Ne Yaşamaz", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4180), null, "9789759038472", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 343, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), 1977, 1, null },
                    { new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"), 1, "Bir Gün Tek Başına", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4235), null, "9789750736056", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 424, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), 1974, 1, null },
                    { new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"), 1, "Kürk Mantolu Madonna", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4194), null, "9789754700114", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 168, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), 1943, 1, null },
                    { new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"), 1, "Tutunamayanlar", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4228), null, "9789750812705", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 712, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), 1972, 1, null },
                    { new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"), 1, "Beyaz Zambaklar Ülkesinde", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4252), null, "9786050954201", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 216, new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"), 1928, 1, null },
                    { new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"), 1, "Gülşah", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4249), null, "9789750718352", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 360, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 1985, 1, null },
                    { new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"), 1, "Saatleri Ayarlama Enstitüsü", 3, new DateTime(2024, 5, 1, 15, 45, 28, 228, DateTimeKind.Utc).AddTicks(4191), null, "9786051414315", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714568273/ekcesgl02ump0lq0mcoj.png", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 420, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), 1961, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Magazines",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "ISSNCode", "MagazineTitle", "Number", "PublisherId", "ReleaseDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"), 2, new DateTime(2024, 4, 6, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1524), null, "ISSN8888-9999", "Foodie Finds", 5, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"), 1, new DateTime(2024, 4, 11, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1514), null, "ISSN9876-5432", "Health & Wellness", 2, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"), 1, new DateTime(2024, 4, 21, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1521), null, "ISSN7777-4321", "Travel Trends", 4, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("44519209-e844-4908-9d92-75db10400dcc"), 1, new DateTime(2024, 4, 26, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1527), null, "ISSN4444-3333", "Artistic Expressions", 6, new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"), new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"), 2, new DateTime(2024, 4, 19, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1530), null, "ISSN2222-1111", "Fashion Forward", 7, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"), 2, new DateTime(2024, 4, 1, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1506), null, "ISSN1234-5678", "Tech Insights", 1, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"), 1, new DateTime(2024, 4, 23, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1533), null, "ISSN9999-8888", "Sports Spectacle", 8, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"), 3, new DateTime(2024, 4, 28, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1535), null, "ISSN3333-4444", "Science Scopes", 9, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"), 3, new DateTime(2024, 4, 16, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1518), null, "ISSN5555-1234", "Finance Focus", 3, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"), 2, new DateTime(2024, 4, 30, 15, 45, 28, 233, DateTimeKind.Utc).AddTicks(1538), null, "ISSN6666-5555", "Music Monthly", 10, new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("5c2c3328-7397-46c8-9de4-16fa87356af9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("e221c928-db9e-4777-8b24-85f45c7cfe4d") });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId", "CreatedDate", "DeletedDate", "Id", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"), new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"), new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"), new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"), new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"), new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"), new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"), new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"), new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"), new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"), new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"), new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"), new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssues_BookId",
                table: "BookIssues",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssues_LibraryStaffId",
                table: "BookIssues",
                column: "LibraryStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_BookIssues_MemberId",
                table: "BookIssues",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReservations_BookId",
                table: "BookReservations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReservations_MemberId",
                table: "BookReservations",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LocationId",
                table: "Books",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_BookId",
                table: "CatalogManagements",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_CatalogId",
                table: "CatalogManagements",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_EBookId",
                table: "CatalogManagements",
                column: "EBookId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_MagazineId",
                table: "CatalogManagements",
                column: "MagazineId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_MaterialId",
                table: "CatalogManagements",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_CategoryId",
                table: "EBooks",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAuthenticators_UserId",
                table: "EmailAuthenticators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_BookId",
                table: "FavoriteBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_MemberId",
                table: "FavoriteBooks",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_FineDues_BookIssueId",
                table: "FineDues",
                column: "BookIssueId");

            migrationBuilder.CreateIndex(
                name: "IX_FinePayments_MemberId",
                table: "FinePayments",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "LibraryStaff_UserID_UK",
                table: "LibraryStaffs",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MagazineAuthors_MagazineId",
                table: "MagazineAuthors",
                column: "MagazineId");

            migrationBuilder.CreateIndex(
                name: "IX_Magazines_CategoryId",
                table: "Magazines",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Magazines_PublisherId",
                table: "Magazines",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialAuthors_MaterialId",
                table: "MaterialAuthors",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CategoryId",
                table: "Materials",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_PublisherId",
                table: "Materials",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "Member_UserID_UK",
                table: "Members",
                column: "MemberSettingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_MemberSettings_MemberId",
                table: "MemberSettings",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OtpAuthenticators_UserId",
                table: "OtpAuthenticators",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_UserId",
                table: "UserOperationClaims",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookReservations");

            migrationBuilder.DropTable(
                name: "CatalogManagements");

            migrationBuilder.DropTable(
                name: "EmailAuthenticators");

            migrationBuilder.DropTable(
                name: "FavoriteBooks");

            migrationBuilder.DropTable(
                name: "FineDues");

            migrationBuilder.DropTable(
                name: "FinePayments");

            migrationBuilder.DropTable(
                name: "MagazineAuthors");

            migrationBuilder.DropTable(
                name: "MaterialAuthors");

            migrationBuilder.DropTable(
                name: "MemberSettings");

            migrationBuilder.DropTable(
                name: "OtpAuthenticators");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "SearchCriterias");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "EBooks");

            migrationBuilder.DropTable(
                name: "BookIssues");

            migrationBuilder.DropTable(
                name: "Magazines");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "LibraryStaffs");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
