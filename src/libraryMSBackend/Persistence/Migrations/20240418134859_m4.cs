using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CatalogManagements_CatalogId",
                table: "CatalogManagements");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("aa8a1603-7adf-43a2-8737-87c61a03a43e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("721a838f-587b-4bab-9777-81ddb563d7ba"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 847, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 847, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 847, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 847, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 847, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 847, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 848, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 848, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 848, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 848, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 848, DateTimeKind.Utc).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 849, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 849, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 849, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 849, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 849, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 850, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 850, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 850, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 850, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 852, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 852, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 852, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 852, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 852, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 852, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 852, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 852, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 855, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 855, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 855, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 48, 58, 855, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("c0a247f4-ae86-47eb-a823-6be648421fe5"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 23, 116, 74, 221, 50, 208, 57, 41, 183, 51, 205, 160, 174, 186, 174, 35, 177, 215, 45, 230, 48, 56, 42, 239, 37, 23, 142, 9, 188, 25, 111, 71, 67, 187, 30, 191, 228, 169, 34, 39, 187, 135, 223, 201, 68, 190, 176, 47, 10, 5, 171, 28, 124, 55, 167, 169, 46, 49, 92, 158, 225, 131, 24, 72 }, new byte[] { 72, 242, 70, 52, 124, 191, 51, 244, 175, 123, 45, 68, 57, 2, 30, 204, 20, 241, 11, 155, 6, 218, 195, 149, 52, 141, 224, 52, 120, 119, 199, 252, 27, 247, 43, 125, 180, 195, 110, 12, 146, 128, 71, 109, 51, 148, 214, 213, 178, 5, 23, 220, 183, 173, 149, 23, 30, 159, 179, 165, 57, 250, 95, 33, 202, 146, 144, 229, 3, 110, 168, 59, 180, 102, 251, 26, 192, 174, 166, 75, 109, 245, 54, 195, 107, 57, 252, 141, 207, 1, 238, 207, 79, 145, 241, 171, 12, 186, 157, 252, 111, 76, 165, 243, 76, 88, 113, 96, 185, 111, 17, 107, 68, 226, 157, 121, 131, 200, 168, 210, 54, 128, 181, 20, 91, 110, 112, 148 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("b8d6bb70-4ef5-4cd4-856d-b3884f0a144b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("c0a247f4-ae86-47eb-a823-6be648421fe5") });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_CatalogId",
                table: "CatalogManagements",
                column: "CatalogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CatalogManagements_CatalogId",
                table: "CatalogManagements");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("b8d6bb70-4ef5-4cd4-856d-b3884f0a144b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c0a247f4-ae86-47eb-a823-6be648421fe5"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 292, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 293, DateTimeKind.Utc).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 293, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 293, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 293, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 293, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 295, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 295, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 295, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 295, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 296, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 296, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 296, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 296, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 297, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 297, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 297, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 297, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 300, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 300, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 300, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 13, 44, 14, 300, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("721a838f-587b-4bab-9777-81ddb563d7ba"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 6, 55, 188, 236, 225, 181, 165, 203, 94, 67, 141, 236, 19, 193, 123, 227, 124, 113, 226, 57, 76, 24, 80, 25, 97, 201, 183, 54, 225, 83, 104, 229, 129, 86, 146, 47, 2, 70, 51, 178, 138, 133, 194, 235, 118, 253, 57, 101, 15, 150, 212, 65, 128, 112, 223, 114, 169, 124, 212, 177, 189, 231, 251, 210 }, new byte[] { 105, 117, 13, 202, 146, 141, 132, 66, 203, 249, 235, 183, 85, 104, 63, 0, 247, 215, 228, 194, 137, 208, 36, 28, 124, 76, 51, 98, 29, 72, 85, 33, 235, 185, 149, 115, 15, 171, 225, 229, 239, 245, 239, 244, 194, 104, 229, 187, 229, 215, 177, 255, 48, 41, 242, 68, 46, 209, 163, 109, 164, 158, 194, 202, 225, 254, 174, 117, 138, 116, 79, 168, 44, 246, 50, 34, 152, 56, 235, 139, 220, 155, 14, 103, 202, 96, 249, 18, 149, 169, 60, 208, 231, 152, 250, 45, 134, 47, 133, 156, 85, 7, 221, 145, 76, 93, 16, 153, 35, 69, 161, 23, 64, 39, 195, 111, 158, 208, 154, 241, 78, 128, 165, 27, 153, 214, 231, 5 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("aa8a1603-7adf-43a2-8737-87c61a03a43e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("721a838f-587b-4bab-9777-81ddb563d7ba") });

            migrationBuilder.CreateIndex(
                name: "IX_CatalogManagements_CatalogId",
                table: "CatalogManagements",
                column: "CatalogId",
                unique: true);
        }
    }
}
