using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig213 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("fd793128-8af7-4570-aa08-7443c867a94b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6f63b3a-7dff-4caf-b7b6-c37d52cd7e82"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 435, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 437, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 437, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 437, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 437, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 437, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 439, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 439, DateTimeKind.Utc).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 439, DateTimeKind.Utc).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 439, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 441, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 441, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 441, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 441, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 442, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 442, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 442, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 442, DateTimeKind.Utc).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 443, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 443, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 443, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 33, 54, 443, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("d3d30219-7d81-423b-81eb-0d7aaf6c9fc7"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 237, 13, 250, 20, 199, 181, 144, 172, 28, 117, 217, 28, 156, 34, 190, 201, 238, 12, 140, 199, 68, 130, 178, 46, 100, 220, 83, 105, 200, 125, 114, 67, 230, 226, 37, 209, 125, 217, 249, 41, 23, 112, 61, 115, 250, 244, 104, 155, 113, 34, 15, 218, 157, 31, 64, 116, 236, 128, 188, 122, 179, 26, 222, 63 }, new byte[] { 48, 21, 59, 103, 168, 179, 94, 112, 245, 49, 71, 62, 224, 245, 99, 89, 78, 107, 64, 97, 181, 208, 160, 53, 231, 104, 218, 163, 217, 92, 179, 245, 82, 133, 49, 159, 123, 186, 132, 36, 135, 237, 128, 233, 134, 145, 75, 90, 16, 236, 197, 181, 82, 44, 113, 201, 249, 52, 66, 19, 41, 81, 126, 143, 195, 60, 126, 250, 120, 104, 7, 249, 178, 97, 128, 31, 27, 235, 51, 245, 156, 249, 225, 32, 58, 35, 28, 17, 147, 1, 167, 247, 221, 213, 4, 56, 108, 40, 31, 193, 148, 121, 47, 111, 166, 172, 210, 1, 165, 52, 86, 194, 184, 250, 254, 206, 65, 249, 224, 180, 64, 110, 102, 56, 253, 223, 13, 177 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("d2d1f4ec-0c55-4ec9-8f25-f40ab50e152c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("d3d30219-7d81-423b-81eb-0d7aaf6c9fc7") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("d2d1f4ec-0c55-4ec9-8f25-f40ab50e152c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d3d30219-7d81-423b-81eb-0d7aaf6c9fc7"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 555, DateTimeKind.Utc).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 556, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 556, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 556, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 556, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 556, DateTimeKind.Utc).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 557, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 557, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 557, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 557, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 559, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 559, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 559, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 559, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 559, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 559, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 559, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 559, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 560, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 560, DateTimeKind.Utc).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 560, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 14, 28, 49, 560, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("b6f63b3a-7dff-4caf-b7b6-c37d52cd7e82"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 220, 55, 163, 10, 193, 247, 242, 42, 24, 209, 19, 232, 194, 123, 246, 226, 180, 39, 115, 211, 72, 167, 194, 146, 237, 15, 240, 111, 197, 235, 3, 164, 150, 23, 231, 197, 73, 159, 130, 240, 254, 12, 109, 85, 96, 69, 203, 50, 158, 243, 32, 218, 25, 53, 122, 205, 35, 181, 61, 18, 219, 255, 228, 225 }, new byte[] { 3, 147, 90, 145, 146, 103, 200, 115, 224, 195, 114, 104, 193, 53, 206, 75, 80, 192, 224, 224, 182, 81, 36, 242, 246, 109, 231, 236, 198, 81, 180, 164, 243, 15, 40, 214, 31, 198, 81, 73, 109, 236, 7, 53, 100, 255, 52, 247, 167, 5, 78, 192, 22, 146, 125, 46, 81, 5, 243, 179, 245, 51, 154, 255, 115, 157, 7, 52, 230, 123, 65, 207, 223, 228, 29, 29, 169, 229, 89, 250, 182, 73, 246, 189, 222, 80, 50, 53, 108, 205, 105, 101, 226, 9, 146, 92, 51, 110, 127, 58, 156, 69, 72, 26, 201, 136, 37, 166, 30, 149, 211, 97, 198, 108, 196, 133, 175, 126, 8, 151, 223, 231, 6, 72, 127, 58, 29, 176 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("fd793128-8af7-4570-aa08-7443c867a94b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("b6f63b3a-7dff-4caf-b7b6-c37d52cd7e82") });
        }
    }
}
