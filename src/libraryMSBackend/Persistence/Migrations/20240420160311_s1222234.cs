using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class s1222234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("47275be9-c33a-4952-9817-4a931845f160"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e3df641b-ea5f-4b1d-8a84-3c608e5cbabd"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 521, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 522, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 522, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 522, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 521, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 522, DateTimeKind.Utc).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 522, DateTimeKind.Utc).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 522, DateTimeKind.Utc).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 522, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 522, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 522, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 523, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 523, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 523, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 523, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 523, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 524, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 524, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 524, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 524, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 526, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 526, DateTimeKind.Utc).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 526, DateTimeKind.Utc).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 526, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 526, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 526, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 526, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 526, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 16, 3, 10, 527, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 529, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 529, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 529, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 3, 10, 529, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("cc810f19-c3a1-4bca-be95-e814df26dbd7"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 13, 123, 154, 226, 42, 83, 39, 124, 162, 49, 103, 26, 134, 224, 83, 17, 205, 228, 224, 167, 67, 111, 68, 231, 106, 173, 139, 106, 155, 249, 230, 45, 73, 160, 147, 37, 39, 117, 165, 84, 121, 167, 54, 203, 113, 13, 220, 132, 46, 116, 125, 209, 10, 255, 180, 0, 223, 141, 55, 198, 177, 0, 144, 234 }, new byte[] { 147, 35, 120, 169, 218, 80, 80, 230, 227, 138, 36, 238, 37, 37, 8, 174, 211, 145, 159, 90, 23, 254, 209, 50, 227, 67, 42, 240, 208, 219, 205, 139, 32, 78, 246, 175, 241, 45, 99, 77, 116, 40, 188, 47, 65, 3, 148, 46, 106, 115, 102, 232, 99, 95, 237, 10, 92, 78, 99, 101, 227, 206, 115, 96, 228, 133, 126, 179, 91, 164, 226, 41, 49, 243, 220, 23, 224, 197, 95, 27, 151, 167, 236, 17, 96, 156, 32, 29, 185, 111, 127, 68, 167, 114, 45, 87, 38, 139, 252, 76, 40, 75, 46, 87, 110, 217, 216, 205, 116, 207, 44, 151, 136, 103, 160, 191, 74, 161, 124, 157, 59, 112, 42, 242, 31, 33, 75, 24 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("1e891547-ec71-4275-8159-fbbceb4e6010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("cc810f19-c3a1-4bca-be95-e814df26dbd7") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("1e891547-ec71-4275-8159-fbbceb4e6010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cc810f19-c3a1-4bca-be95-e814df26dbd7"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 859, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 860, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 860, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 860, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 860, DateTimeKind.Utc).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 860, DateTimeKind.Utc).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 862, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 862, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 862, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 862, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 863, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 863, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 863, DateTimeKind.Utc).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 863, DateTimeKind.Utc).AddTicks(3600));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 863, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 863, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 863, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 863, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 16, 2, 48, 864, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 866, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 866, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 866, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 16, 2, 48, 866, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("e3df641b-ea5f-4b1d-8a84-3c608e5cbabd"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 239, 88, 1, 175, 242, 210, 243, 50, 189, 103, 26, 69, 98, 129, 71, 210, 193, 166, 209, 187, 210, 108, 80, 192, 203, 22, 126, 94, 158, 176, 23, 98, 181, 146, 10, 87, 170, 9, 75, 84, 89, 117, 127, 76, 244, 195, 241, 236, 180, 184, 158, 72, 166, 210, 20, 111, 68, 31, 38, 11, 218, 59, 114, 114 }, new byte[] { 79, 218, 37, 120, 53, 120, 47, 106, 112, 166, 249, 32, 82, 75, 216, 209, 170, 221, 54, 245, 251, 18, 169, 52, 91, 53, 21, 227, 29, 81, 146, 133, 7, 126, 93, 131, 221, 10, 202, 7, 215, 176, 213, 169, 23, 172, 142, 176, 49, 33, 110, 234, 250, 79, 58, 224, 220, 183, 131, 4, 231, 3, 37, 38, 126, 16, 58, 115, 34, 116, 30, 182, 130, 135, 12, 67, 8, 230, 121, 75, 143, 245, 12, 44, 171, 189, 203, 1, 72, 74, 66, 182, 154, 56, 244, 111, 222, 41, 186, 69, 246, 56, 224, 43, 177, 141, 174, 243, 145, 197, 102, 164, 21, 95, 71, 243, 118, 112, 150, 2, 106, 13, 134, 242, 153, 94, 200, 36 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("47275be9-c33a-4952-9817-4a931845f160"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("e3df641b-ea5f-4b1d-8a84-3c608e5cbabd") });
        }
    }
}
