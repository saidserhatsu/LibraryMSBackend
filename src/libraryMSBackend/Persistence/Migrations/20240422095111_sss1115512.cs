using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class sss1115512 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Members_MemberSettingId",
                table: "Members");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("596bd976-0597-445b-b23b-37c118218371"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27e06259-583e-4db2-b6d2-7532469c6d66"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 861, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 862, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 862, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 862, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 862, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 862, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 864, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 864, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 864, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 864, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 865, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 865, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 865, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 865, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9754));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 2, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 14, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 9, 51, 10, 866, DateTimeKind.Utc).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 869, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 869, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 869, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 51, 10, 869, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("801e3ce4-c86f-4d8f-ac99-364f6cfa6e7c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 199, 195, 147, 92, 148, 131, 190, 169, 242, 169, 105, 212, 20, 19, 184, 72, 177, 254, 75, 228, 224, 182, 9, 146, 228, 239, 79, 235, 255, 61, 43, 5, 92, 139, 90, 180, 144, 239, 186, 162, 215, 1, 37, 99, 194, 154, 0, 141, 250, 165, 90, 101, 199, 206, 24, 95, 167, 29, 67, 71, 117, 153, 254, 143 }, new byte[] { 160, 2, 38, 138, 149, 173, 143, 27, 254, 253, 131, 78, 54, 137, 147, 125, 4, 228, 139, 35, 82, 161, 46, 182, 55, 62, 197, 87, 88, 70, 109, 63, 51, 143, 218, 64, 189, 203, 69, 253, 8, 185, 175, 156, 70, 236, 7, 230, 181, 184, 8, 179, 89, 229, 185, 64, 68, 127, 197, 4, 149, 84, 16, 117, 184, 98, 25, 54, 202, 169, 190, 72, 174, 141, 17, 23, 133, 191, 68, 112, 134, 128, 188, 228, 182, 147, 47, 174, 2, 29, 185, 35, 51, 211, 85, 40, 6, 55, 232, 10, 163, 75, 139, 37, 167, 30, 71, 159, 56, 54, 32, 106, 188, 15, 46, 169, 223, 172, 130, 203, 12, 133, 190, 54, 60, 59, 24, 56 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("faa18c70-21ed-43e6-ae6f-8d133ad4473d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("801e3ce4-c86f-4d8f-ac99-364f6cfa6e7c") });

            migrationBuilder.CreateIndex(
                name: "Member_UserID_UK",
                table: "Members",
                column: "MemberSettingId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Member_UserID_UK",
                table: "Members");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("faa18c70-21ed-43e6-ae6f-8d133ad4473d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("801e3ce4-c86f-4d8f-ac99-364f6cfa6e7c"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 53, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 54, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 54, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 54, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 54, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 54, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 56, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 56, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 56, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 56, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 58, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 58, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 58, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 58, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 58, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 58, DateTimeKind.Utc).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 58, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 58, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 2, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 14, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 9, 50, 5, 59, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 61, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 61, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 61, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 50, 5, 61, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("27e06259-583e-4db2-b6d2-7532469c6d66"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 223, 127, 231, 136, 225, 169, 218, 223, 251, 223, 95, 187, 113, 141, 94, 42, 176, 116, 16, 53, 75, 245, 108, 224, 219, 63, 100, 241, 102, 129, 173, 114, 39, 35, 252, 194, 201, 183, 52, 48, 29, 195, 38, 235, 97, 83, 230, 220, 160, 49, 95, 249, 87, 124, 134, 144, 186, 164, 12, 116, 134, 195, 219, 119 }, new byte[] { 232, 180, 182, 125, 231, 156, 123, 163, 192, 172, 85, 228, 201, 161, 152, 27, 211, 183, 229, 131, 255, 246, 50, 125, 95, 88, 164, 81, 216, 220, 73, 237, 6, 176, 59, 157, 10, 30, 78, 100, 123, 54, 36, 103, 51, 237, 5, 57, 126, 80, 226, 204, 32, 43, 111, 223, 66, 88, 133, 49, 70, 251, 175, 171, 71, 125, 108, 38, 46, 167, 19, 82, 59, 240, 86, 146, 111, 84, 39, 204, 87, 242, 13, 192, 235, 22, 255, 20, 5, 99, 211, 253, 235, 248, 240, 60, 58, 231, 30, 49, 175, 235, 173, 81, 170, 241, 221, 29, 85, 106, 208, 114, 166, 195, 222, 107, 15, 189, 227, 181, 151, 6, 12, 178, 247, 91, 34, 143 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("596bd976-0597-445b-b23b-37c118218371"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("27e06259-583e-4db2-b6d2-7532469c6d66") });

            migrationBuilder.CreateIndex(
                name: "IX_Members_MemberSettingId",
                table: "Members",
                column: "MemberSettingId");
        }
    }
}
