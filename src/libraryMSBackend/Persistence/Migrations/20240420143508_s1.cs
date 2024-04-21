using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class s1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("edf08791-de2e-4854-8a9f-fdc87c710411"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e31de8e2-4f46-46d8-a688-aaaff44439b8"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 688, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 688, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 688, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 688, DateTimeKind.Utc).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 688, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 688, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 689, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 689, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 689, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 689, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 689, DateTimeKind.Utc).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 690, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 690, DateTimeKind.Utc).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 690, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 690, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 690, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 691, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 691, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 691, DateTimeKind.Utc).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 691, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 693, DateTimeKind.Utc).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 693, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 693, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 693, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 693, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 693, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 693, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 693, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 14, 35, 7, 694, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 696, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 696, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 696, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 35, 7, 696, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("75bc5b3a-d4fb-40fc-aa92-96a8401ce225"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 0, 89, 96, 132, 247, 62, 54, 106, 25, 49, 13, 176, 121, 237, 48, 79, 121, 251, 25, 55, 75, 231, 106, 197, 53, 243, 28, 10, 98, 134, 148, 106, 138, 137, 35, 60, 185, 56, 144, 182, 177, 252, 48, 5, 46, 244, 158, 78, 12, 64, 131, 120, 47, 201, 116, 124, 69, 86, 47, 100, 22, 94, 54, 97 }, new byte[] { 230, 139, 79, 171, 88, 101, 192, 192, 223, 56, 181, 93, 206, 208, 97, 179, 148, 209, 17, 250, 245, 99, 154, 128, 238, 8, 27, 208, 209, 199, 7, 158, 235, 225, 209, 223, 107, 200, 48, 105, 99, 241, 36, 159, 208, 13, 84, 210, 120, 246, 60, 124, 18, 198, 189, 174, 65, 227, 135, 210, 119, 240, 183, 92, 170, 205, 43, 169, 162, 69, 36, 52, 29, 172, 77, 175, 223, 87, 47, 22, 35, 200, 235, 117, 44, 66, 2, 0, 94, 189, 213, 87, 0, 32, 47, 11, 244, 74, 99, 246, 124, 192, 182, 98, 145, 183, 103, 105, 12, 68, 51, 177, 192, 131, 83, 136, 114, 62, 70, 206, 88, 3, 153, 100, 16, 68, 61, 38 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1ff5d311-ecb5-4052-a064-edb74bd52097"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("75bc5b3a-d4fb-40fc-aa92-96a8401ce225") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1ff5d311-ecb5-4052-a064-edb74bd52097"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("75bc5b3a-d4fb-40fc-aa92-96a8401ce225"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 870, DateTimeKind.Utc).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 871, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 871, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 871, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 871, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 871, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 873, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 873, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 873, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 873, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 874, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 874, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 874, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 874, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 874, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 874, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 874, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 874, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 14, 34, 29, 875, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 878, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 878, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 878, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 34, 29, 878, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("e31de8e2-4f46-46d8-a688-aaaff44439b8"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 61, 119, 111, 34, 130, 124, 220, 201, 170, 163, 155, 124, 120, 27, 88, 120, 20, 114, 59, 3, 126, 203, 166, 36, 116, 159, 177, 124, 250, 196, 218, 41, 26, 189, 137, 80, 128, 233, 158, 123, 176, 50, 75, 78, 1, 57, 210, 202, 183, 52, 211, 172, 232, 194, 210, 208, 154, 87, 55, 55, 126, 0, 1, 209 }, new byte[] { 117, 129, 48, 168, 167, 31, 202, 78, 35, 161, 154, 41, 156, 200, 230, 191, 74, 226, 22, 48, 110, 18, 236, 222, 149, 145, 83, 230, 253, 219, 184, 127, 234, 114, 35, 108, 97, 69, 160, 163, 168, 232, 95, 175, 73, 1, 146, 8, 149, 110, 119, 107, 56, 87, 32, 21, 222, 159, 79, 237, 101, 43, 218, 200, 112, 86, 105, 191, 105, 161, 98, 112, 213, 2, 134, 34, 55, 138, 3, 18, 234, 236, 183, 153, 68, 18, 179, 27, 46, 104, 101, 41, 22, 220, 101, 175, 161, 65, 222, 205, 201, 148, 70, 176, 248, 160, 79, 95, 52, 139, 136, 131, 58, 151, 34, 183, 43, 61, 175, 247, 121, 150, 14, 20, 81, 190, 228, 6 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("edf08791-de2e-4854-8a9f-fdc87c710411"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("e31de8e2-4f46-46d8-a688-aaaff44439b8") });
        }
    }
}
