using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Catalogs_CatalogId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Magazines_Catalogs_CatalogId",
                table: "Magazines");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Catalogs_CatalogId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_CatalogId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Magazines_CatalogId",
                table: "Magazines");

            migrationBuilder.DropIndex(
                name: "IX_Books_CatalogId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("82fd1d77-1ba3-4c62-9739-017145324819"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b444381a-1d36-49bd-b84b-e16e28fb2845"));

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "Magazines");

            migrationBuilder.DropColumn(
                name: "CatalogId",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "CatalogManagements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MagazineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 63, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 64, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 64, DateTimeKind.Utc).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 64, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 64, DateTimeKind.Utc).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 64, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 66, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 66, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 66, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 66, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 67, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 67, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 67, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 67, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 67, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 67, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 67, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 67, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
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
                    { 281, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Materials.Delete", null }
                });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 70, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 70, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 70, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 27, 58, 70, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("57362124-22dd-4bf2-97ce-ff256e643c3a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 206, 126, 54, 18, 199, 214, 190, 21, 214, 229, 128, 151, 128, 83, 91, 166, 73, 199, 3, 191, 199, 210, 52, 255, 230, 35, 195, 155, 78, 92, 120, 50, 108, 202, 47, 46, 126, 235, 196, 79, 4, 221, 205, 191, 108, 61, 138, 126, 33, 160, 171, 237, 53, 110, 254, 234, 87, 98, 137, 220, 126, 248, 100, 204 }, new byte[] { 208, 138, 215, 157, 222, 17, 119, 106, 27, 53, 45, 196, 13, 130, 56, 42, 153, 39, 41, 140, 246, 171, 103, 140, 188, 231, 242, 118, 168, 52, 210, 132, 120, 36, 35, 192, 22, 132, 170, 231, 50, 130, 189, 93, 197, 175, 181, 116, 4, 110, 54, 112, 130, 227, 204, 104, 207, 112, 88, 97, 242, 20, 197, 217, 143, 221, 122, 78, 218, 185, 204, 58, 129, 211, 248, 104, 243, 79, 155, 180, 65, 176, 229, 62, 243, 84, 170, 248, 58, 157, 89, 145, 60, 234, 187, 208, 79, 207, 160, 4, 127, 184, 32, 61, 90, 253, 196, 116, 23, 108, 26, 70, 171, 192, 187, 233, 97, 67, 35, 172, 37, 99, 227, 29, 132, 140, 164, 145 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("9ec68cec-5cbc-4e1d-8f5f-f1662f44db36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("57362124-22dd-4bf2-97ce-ff256e643c3a") });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_BookId",
                table: "CatalogManagements",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_CatalogId",
                table: "CatalogManagements",
                column: "CatalogId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_MagazineId",
                table: "CatalogManagements",
                column: "MagazineId");

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_MaterialId",
                table: "CatalogManagements",
                column: "MaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogManagements");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9ec68cec-5cbc-4e1d-8f5f-f1662f44db36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("57362124-22dd-4bf2-97ce-ff256e643c3a"));

            migrationBuilder.AddColumn<Guid>(
                name: "CatalogId",
                table: "Materials",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CatalogId",
                table: "Magazines",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CatalogId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 379, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                columns: new[] { "CatalogId", "CreatedDate" },
                values: new object[] { null, new DateTime(2024, 4, 18, 9, 36, 35, 380, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                columns: new[] { "CatalogId", "CreatedDate" },
                values: new object[] { null, new DateTime(2024, 4, 18, 9, 36, 35, 380, DateTimeKind.Utc).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                columns: new[] { "CatalogId", "CreatedDate" },
                values: new object[] { null, new DateTime(2024, 4, 18, 9, 36, 35, 380, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                columns: new[] { "CatalogId", "CreatedDate" },
                values: new object[] { null, new DateTime(2024, 4, 18, 9, 36, 35, 380, DateTimeKind.Utc).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                columns: new[] { "CatalogId", "CreatedDate" },
                values: new object[] { null, new DateTime(2024, 4, 18, 9, 36, 35, 380, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 381, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 381, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 381, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 381, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 382, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 382, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 382, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 382, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 382, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 382, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 382, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 382, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 386, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 386, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 386, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 36, 35, 386, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("b444381a-1d36-49bd-b84b-e16e28fb2845"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 26, 178, 63, 92, 247, 197, 116, 191, 149, 62, 91, 70, 61, 200, 208, 132, 174, 207, 12, 19, 79, 174, 51, 151, 209, 42, 57, 240, 10, 37, 12, 88, 38, 162, 202, 140, 14, 245, 83, 150, 92, 36, 90, 157, 176, 46, 101, 243, 113, 9, 172, 121, 8, 153, 39, 133, 27, 110, 179, 60, 184, 11, 200, 249 }, new byte[] { 94, 27, 33, 28, 148, 135, 115, 82, 157, 173, 243, 9, 244, 97, 92, 122, 60, 3, 56, 142, 69, 112, 55, 138, 242, 204, 28, 140, 121, 32, 70, 99, 81, 137, 252, 165, 186, 13, 255, 69, 7, 70, 166, 202, 175, 27, 100, 30, 188, 58, 136, 135, 79, 171, 200, 98, 244, 243, 29, 86, 154, 176, 159, 113, 102, 108, 5, 123, 39, 251, 22, 14, 89, 237, 115, 44, 86, 6, 70, 227, 164, 73, 168, 45, 65, 156, 74, 192, 244, 191, 94, 148, 83, 248, 40, 241, 103, 164, 197, 92, 116, 84, 121, 4, 39, 103, 39, 174, 133, 170, 39, 181, 132, 227, 98, 136, 208, 87, 175, 252, 160, 228, 248, 219, 212, 218, 51, 204 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("82fd1d77-1ba3-4c62-9739-017145324819"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("b444381a-1d36-49bd-b84b-e16e28fb2845") });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CatalogId",
                table: "Materials",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Magazines_CatalogId",
                table: "Magazines",
                column: "CatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CatalogId",
                table: "Books",
                column: "CatalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Catalogs_CatalogId",
                table: "Books",
                column: "CatalogId",
                principalTable: "Catalogs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Magazines_Catalogs_CatalogId",
                table: "Magazines",
                column: "CatalogId",
                principalTable: "Catalogs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Catalogs_CatalogId",
                table: "Materials",
                column: "CatalogId",
                principalTable: "Catalogs",
                principalColumn: "Id");
        }
    }
}
