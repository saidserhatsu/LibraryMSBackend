using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAnnouncementsSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f1b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f2b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f3b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f5b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f6b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("a4df495a-c378-4163-aa5a-4dbb12fe316f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa3e222f-f7e7-48f4-897d-ea7658677e00"));

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "Content", "CreatedDate", "DeletedDate", "Tag", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"), "Content 1", new DateTime(2024, 3, 26, 12, 39, 36, 751, DateTimeKind.Utc).AddTicks(3691), null, 0, "Kütüphane Üyelikleri", null },
                    { new Guid("7085aa16-5230-42ca-941b-6d73c692053b"), "Content 6", new DateTime(2024, 3, 26, 12, 39, 36, 751, DateTimeKind.Utc).AddTicks(3712), null, 0, "Kütüphane Açılış Saatleri", null },
                    { new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"), "Content 5", new DateTime(2024, 3, 26, 12, 39, 36, 751, DateTimeKind.Utc).AddTicks(3708), null, 1, "Bayramlaşma", null },
                    { new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"), "Content 4", new DateTime(2024, 3, 26, 12, 39, 36, 751, DateTimeKind.Utc).AddTicks(3705), null, 1, "Yeni Yıl Etkinliği", null },
                    { new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"), "Content 2", new DateTime(2024, 3, 26, 12, 39, 36, 751, DateTimeKind.Utc).AddTicks(3697), null, 1, "Hıdırellez Yarışması", null },
                    { new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"), "Content 3", new DateTime(2024, 3, 26, 12, 39, 36, 751, DateTimeKind.Utc).AddTicks(3702), null, 2, "Yeni Kitaplar", null }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 752, DateTimeKind.Utc).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 752, DateTimeKind.Utc).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 752, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 752, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 752, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "BookIssues",
                keyColumn: "Id",
                keyValue: new Guid("0f5ab2b8-1e2a-4380-94c6-5ea6524c4a84"),
                columns: new[] { "CreatedDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 39, 36, 755, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 3, 26, 12, 39, 36, 755, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "BookIssues",
                keyColumn: "Id",
                keyValue: new Guid("d36b9b6d-86bf-4dc0-b1d3-b6a1aadd0d11"),
                columns: new[] { "CreatedDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 39, 36, 755, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 3, 26, 12, 39, 36, 755, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "BookIssues",
                keyColumn: "Id",
                keyValue: new Guid("e902bad2-62ea-4273-8e0b-9667e9ec0566"),
                columns: new[] { "CreatedDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 3, 26, 12, 39, 36, 755, DateTimeKind.Utc).AddTicks(4564), new DateTime(2024, 3, 26, 12, 39, 36, 755, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 754, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 754, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 754, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 754, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 754, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 757, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 757, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 757, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 757, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 760, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 760, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 760, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 760, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 761, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 761, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 761, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 761, DateTimeKind.Utc).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("10f30ed6-aa0d-4cc5-8155-63e13cc50cd9"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 762, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("2d7e8997-68c0-4a84-846f-ded3e8a3d6ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 762, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("3e754b13-3554-4f20-805f-29ba737d96cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 762, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("e8676014-fff7-4c43-8baa-ae40263b0069"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 762, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 764, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 764, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 764, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 12, 39, 36, 764, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("c7741500-5503-4a5a-8941-3881c2d5b206"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 133, 80, 89, 254, 122, 243, 154, 68, 13, 68, 151, 181, 186, 57, 187, 67, 53, 21, 144, 223, 249, 126, 199, 75, 18, 130, 180, 234, 40, 112, 14, 221, 143, 4, 222, 29, 84, 136, 233, 39, 184, 226, 226, 232, 110, 196, 0, 117, 98, 249, 28, 26, 143, 175, 145, 210, 99, 164, 215, 213, 231, 204, 39, 18 }, new byte[] { 101, 228, 85, 74, 118, 95, 22, 171, 244, 203, 33, 212, 192, 192, 194, 29, 51, 66, 76, 25, 241, 32, 52, 134, 43, 200, 73, 187, 116, 29, 155, 212, 145, 118, 229, 126, 145, 190, 149, 181, 165, 7, 174, 179, 81, 237, 232, 97, 20, 220, 122, 211, 55, 250, 235, 81, 202, 0, 142, 197, 187, 33, 3, 54, 239, 63, 196, 246, 220, 27, 159, 171, 4, 38, 189, 145, 219, 61, 87, 220, 148, 29, 15, 62, 220, 103, 180, 181, 96, 85, 231, 126, 213, 241, 230, 55, 149, 117, 110, 0, 153, 237, 196, 196, 174, 115, 203, 0, 240, 226, 250, 76, 243, 168, 247, 65, 157, 248, 222, 33, 114, 190, 69, 167, 228, 23, 161, 116 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("7c8b0f29-44ab-4704-8d2c-cf2ada093fb3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("c7741500-5503-4a5a-8941-3881c2d5b206") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"));

            migrationBuilder.DeleteData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7c8b0f29-44ab-4704-8d2c-cf2ada093fb3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7741500-5503-4a5a-8941-3881c2d5b206"));

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "Content", "CreatedDate", "DeletedDate", "Tag", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("f1b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"), "Content 1", new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(1919), null, 0, "Kütüphane Üyelikleri", null },
                    { new Guid("f2b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"), "Content 2", new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(1924), null, 1, "Hıdırellez Yarışması", null },
                    { new Guid("f3b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"), "Content 3", new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(1926), null, 2, "Yeni Kitaplar", null },
                    { new Guid("f4b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"), "Content 4", new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(1928), null, 1, "Yeni Yıl Etkinliği", null },
                    { new Guid("f5b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"), "Content 5", new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(1930), null, 1, "Bayramlaşma", null },
                    { new Guid("f6b3b3b4-1b3b-4b3b-8b3b-1b3b3b3b3b3b"), "Content 6", new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(1931), null, 0, "Kütüphane Açılış Saatleri", null }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 953, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "BookIssues",
                keyColumn: "Id",
                keyValue: new Guid("0f5ab2b8-1e2a-4380-94c6-5ea6524c4a84"),
                columns: new[] { "CreatedDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(8775), new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "BookIssues",
                keyColumn: "Id",
                keyValue: new Guid("d36b9b6d-86bf-4dc0-b1d3-b6a1aadd0d11"),
                columns: new[] { "CreatedDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(8780), new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "BookIssues",
                keyColumn: "Id",
                keyValue: new Guid("e902bad2-62ea-4273-8e0b-9667e9ec0566"),
                columns: new[] { "CreatedDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(8771), new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(8769) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 955, DateTimeKind.Utc).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 957, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 957, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 957, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 957, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(2217));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("10f30ed6-aa0d-4cc5-8155-63e13cc50cd9"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("2d7e8997-68c0-4a84-846f-ded3e8a3d6ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("3e754b13-3554-4f20-805f-29ba737d96cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("e8676014-fff7-4c43-8baa-ae40263b0069"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 959, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 960, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 960, DateTimeKind.Utc).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 960, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 11, 47, 59, 960, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("aa3e222f-f7e7-48f4-897d-ea7658677e00"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 41, 212, 73, 90, 124, 5, 152, 78, 155, 226, 112, 35, 165, 86, 78, 185, 159, 245, 171, 148, 131, 202, 33, 40, 0, 207, 53, 139, 90, 18, 158, 210, 25, 128, 96, 60, 36, 44, 76, 92, 213, 89, 153, 40, 241, 3, 160, 24, 44, 2, 217, 4, 132, 31, 61, 166, 220, 133, 149, 232, 210, 250, 126, 60 }, new byte[] { 158, 95, 247, 16, 190, 26, 116, 33, 146, 36, 27, 0, 67, 231, 148, 245, 115, 38, 199, 208, 147, 195, 8, 147, 68, 249, 224, 101, 90, 14, 162, 250, 93, 253, 45, 183, 184, 28, 0, 243, 212, 59, 141, 75, 79, 181, 156, 243, 188, 219, 13, 84, 113, 34, 66, 144, 0, 249, 181, 252, 190, 84, 171, 88, 227, 102, 5, 246, 243, 245, 195, 30, 253, 53, 155, 185, 166, 42, 84, 219, 143, 72, 109, 218, 206, 79, 192, 100, 226, 153, 44, 182, 223, 193, 149, 44, 105, 209, 142, 105, 207, 219, 131, 70, 89, 224, 127, 235, 123, 4, 55, 118, 196, 150, 38, 188, 106, 14, 113, 11, 31, 128, 238, 14, 249, 30, 178, 30 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("a4df495a-c378-4163-aa5a-4dbb12fe316f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("aa3e222f-f7e7-48f4-897d-ea7658677e00") });
        }
    }
}
