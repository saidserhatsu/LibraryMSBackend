using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class s12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("586397e1-db5f-4f90-83ed-10a6d0150719"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29bad80a-3027-4fcb-97f7-3b7cc64de0ce"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 829, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 830, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 830, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 830, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 830, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 830, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 832, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 832, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 832, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 832, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 833, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 833, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 833, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 833, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 14, 55, 10, 834, DateTimeKind.Utc).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 837, DateTimeKind.Utc).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 837, DateTimeKind.Utc).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 837, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 55, 10, 837, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("6f05676a-1516-4c53-93ef-14599532ea71"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 50, 92, 152, 218, 173, 140, 96, 34, 208, 117, 197, 71, 161, 129, 233, 238, 252, 192, 149, 141, 30, 79, 75, 99, 11, 50, 232, 52, 225, 182, 207, 183, 252, 77, 216, 69, 96, 214, 226, 207, 126, 34, 120, 102, 13, 66, 230, 99, 104, 7, 159, 181, 137, 95, 2, 62, 92, 213, 76, 230, 77, 239, 199, 186 }, new byte[] { 34, 205, 115, 245, 5, 69, 35, 30, 239, 62, 128, 235, 88, 17, 94, 38, 242, 225, 151, 218, 159, 76, 52, 97, 227, 62, 209, 74, 28, 15, 198, 40, 219, 224, 99, 217, 73, 107, 210, 247, 105, 81, 40, 215, 157, 26, 104, 6, 18, 163, 88, 20, 230, 244, 126, 249, 154, 138, 108, 189, 239, 226, 255, 201, 161, 100, 249, 21, 168, 208, 139, 55, 60, 202, 67, 41, 150, 241, 154, 117, 29, 162, 107, 101, 76, 87, 62, 197, 25, 185, 125, 10, 213, 234, 36, 216, 164, 127, 187, 203, 166, 56, 70, 34, 51, 226, 235, 200, 246, 79, 242, 109, 18, 122, 246, 46, 202, 213, 216, 214, 13, 52, 244, 132, 71, 238, 183, 28 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("88912b38-0663-4ad0-a25f-038c68cbff46"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("6f05676a-1516-4c53-93ef-14599532ea71") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("88912b38-0663-4ad0-a25f-038c68cbff46"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6f05676a-1516-4c53-93ef-14599532ea71"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 283, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 284, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 284, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 284, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 284, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 284, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 286, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 286, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 286, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 286, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 288, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 288, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 288, DateTimeKind.Utc).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 288, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 288, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 288, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 288, DateTimeKind.Utc).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 288, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 21, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 14, 53, 17, 289, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 292, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 292, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 292, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 14, 53, 17, 292, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("29bad80a-3027-4fcb-97f7-3b7cc64de0ce"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 73, 79, 70, 207, 10, 113, 46, 39, 193, 147, 62, 162, 147, 70, 248, 43, 163, 210, 160, 110, 170, 235, 255, 18, 35, 179, 250, 156, 224, 198, 63, 128, 143, 192, 136, 162, 14, 173, 122, 37, 184, 165, 171, 130, 84, 159, 87, 217, 69, 119, 173, 205, 78, 60, 27, 10, 206, 94, 151, 180, 123, 174, 205, 143 }, new byte[] { 3, 90, 102, 146, 76, 20, 143, 54, 112, 52, 45, 130, 191, 178, 140, 132, 211, 127, 145, 210, 134, 170, 48, 117, 205, 25, 127, 255, 128, 18, 212, 217, 208, 142, 73, 131, 172, 245, 176, 13, 151, 251, 198, 105, 44, 60, 160, 72, 20, 198, 118, 83, 139, 73, 24, 207, 41, 117, 111, 0, 155, 171, 38, 211, 170, 194, 169, 175, 219, 195, 53, 58, 51, 111, 177, 62, 186, 182, 66, 153, 114, 85, 34, 160, 17, 233, 101, 51, 92, 245, 35, 129, 127, 99, 8, 159, 52, 249, 98, 36, 54, 158, 120, 98, 241, 201, 172, 102, 217, 175, 35, 210, 91, 80, 22, 113, 78, 197, 168, 155, 147, 168, 247, 19, 163, 141, 79, 16 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("586397e1-db5f-4f90-83ed-10a6d0150719"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("29bad80a-3027-4fcb-97f7-3b7cc64de0ce") });
        }
    }
}
