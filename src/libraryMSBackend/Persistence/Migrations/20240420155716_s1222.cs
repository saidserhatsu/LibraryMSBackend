using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class s1222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("9af52cd0-bf0c-4ff1-90c4-29a784445eb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4149637-5b73-4245-8aa9-ed19baec6e12"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 289, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 289, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 289, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 289, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 289, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 289, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 290, DateTimeKind.Utc).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 290, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 290, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 290, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 290, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 291, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 291, DateTimeKind.Utc).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 291, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 291, DateTimeKind.Utc).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 291, DateTimeKind.Utc).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 292, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 292, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 292, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 292, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 294, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 294, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 294, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 294, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 294, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 294, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 294, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 294, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 15, 57, 16, 295, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 297, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 297, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 297, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 57, 16, 297, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("b2261d4b-6fc0-494a-ab94-644a7fd80a73"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 3, 223, 253, 103, 95, 6, 131, 149, 84, 38, 100, 17, 63, 148, 33, 94, 55, 196, 192, 22, 107, 161, 9, 224, 233, 8, 83, 177, 12, 216, 105, 153, 158, 30, 124, 239, 230, 241, 113, 121, 60, 15, 253, 31, 213, 57, 199, 22, 10, 64, 200, 181, 95, 211, 203, 111, 37, 194, 217, 143, 90, 33, 4, 105 }, new byte[] { 68, 66, 161, 12, 215, 137, 175, 183, 71, 17, 77, 180, 107, 109, 36, 88, 73, 219, 65, 75, 74, 42, 141, 12, 121, 64, 11, 108, 240, 48, 35, 17, 88, 125, 78, 96, 23, 217, 56, 255, 35, 129, 132, 210, 121, 145, 1, 155, 228, 109, 86, 65, 106, 63, 90, 77, 165, 131, 178, 158, 193, 0, 217, 95, 185, 246, 174, 181, 202, 178, 41, 59, 114, 41, 195, 71, 234, 67, 194, 184, 110, 50, 120, 89, 116, 162, 130, 40, 85, 248, 20, 5, 219, 169, 70, 193, 51, 112, 96, 109, 14, 31, 9, 188, 179, 3, 88, 253, 40, 37, 53, 82, 42, 147, 86, 235, 78, 84, 180, 91, 220, 200, 125, 67, 80, 32, 148, 67 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("3e1e70d8-8aff-42ea-9a60-342c00279cb5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("b2261d4b-6fc0-494a-ab94-644a7fd80a73") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3e1e70d8-8aff-42ea-9a60-342c00279cb5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b2261d4b-6fc0-494a-ab94-644a7fd80a73"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 987, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 987, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 987, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 987, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 987, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 987, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 988, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 990, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 990, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 990, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 990, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 992, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 992, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 992, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 992, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 992, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 992, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 992, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 992, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 15, 54, 59, 993, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 995, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 995, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 995, DateTimeKind.Utc).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 54, 59, 995, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("e4149637-5b73-4245-8aa9-ed19baec6e12"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 177, 68, 7, 83, 246, 53, 225, 218, 90, 240, 95, 149, 223, 185, 75, 65, 7, 157, 171, 30, 38, 151, 48, 70, 32, 244, 130, 48, 120, 190, 92, 3, 152, 93, 52, 149, 252, 94, 218, 39, 232, 27, 141, 137, 222, 70, 253, 161, 46, 243, 51, 22, 40, 200, 211, 18, 108, 176, 95, 145, 254, 189, 16, 175 }, new byte[] { 144, 174, 36, 108, 184, 76, 170, 0, 151, 119, 13, 105, 121, 7, 18, 172, 168, 106, 62, 166, 161, 228, 137, 118, 210, 190, 219, 56, 240, 219, 57, 157, 21, 37, 69, 8, 57, 199, 77, 165, 183, 74, 174, 223, 167, 33, 105, 161, 51, 214, 99, 100, 69, 203, 143, 185, 192, 117, 227, 227, 0, 164, 106, 32, 125, 34, 35, 187, 205, 130, 7, 142, 64, 251, 36, 102, 189, 100, 51, 66, 34, 23, 64, 58, 107, 84, 59, 147, 165, 83, 252, 196, 56, 8, 178, 100, 105, 157, 175, 4, 48, 91, 69, 77, 162, 221, 23, 65, 0, 129, 5, 7, 203, 17, 253, 43, 255, 74, 246, 250, 82, 200, 214, 166, 146, 228, 142, 45 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("9af52cd0-bf0c-4ff1-90c4-29a784445eb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("e4149637-5b73-4245-8aa9-ed19baec6e12") });
        }
    }
}
