using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class sss1115512345 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EBooks_Books_BookId",
                table: "EBooks");

            migrationBuilder.DropIndex(
                name: "IX_EBooks_BookId",
                table: "EBooks");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("29086f7e-6222-4bcb-ac44-c66c150ff7d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3c5f34c9-6594-48c3-bcea-9c4892113fbd"));

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "EBooks");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 419, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 419, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 419, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 419, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 419, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 419, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 420, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 420, DateTimeKind.Utc).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 420, DateTimeKind.Utc).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 420, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 420, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 421, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 421, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 421, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 421, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 421, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 423, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 423, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 423, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 423, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 424, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 424, DateTimeKind.Utc).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 424, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 424, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 424, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 424, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 424, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 424, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 2, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 14, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 12, 51, 48, 425, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 427, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 427, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 427, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 51, 48, 427, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("991bb54c-8db7-42b0-bec6-10af49e3438a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 62, 189, 41, 192, 131, 14, 217, 35, 123, 11, 8, 39, 56, 195, 117, 177, 83, 235, 53, 235, 185, 239, 55, 163, 36, 95, 255, 249, 248, 80, 159, 227, 132, 7, 200, 61, 65, 51, 205, 77, 103, 58, 212, 16, 215, 220, 41, 32, 216, 56, 180, 127, 21, 69, 170, 154, 210, 137, 31, 72, 67, 54, 74, 198 }, new byte[] { 187, 0, 121, 11, 154, 83, 2, 22, 101, 55, 201, 208, 106, 237, 228, 112, 39, 54, 193, 151, 128, 236, 181, 243, 29, 244, 25, 67, 159, 165, 64, 11, 226, 60, 194, 236, 227, 184, 11, 194, 159, 113, 26, 17, 33, 51, 236, 192, 121, 64, 199, 118, 22, 27, 68, 78, 196, 12, 181, 104, 123, 218, 234, 113, 100, 14, 189, 86, 91, 106, 113, 224, 38, 106, 249, 45, 164, 155, 104, 154, 212, 80, 166, 150, 14, 23, 156, 193, 116, 193, 77, 86, 196, 68, 208, 161, 200, 245, 171, 152, 194, 104, 15, 203, 233, 28, 147, 127, 148, 248, 194, 255, 122, 237, 143, 102, 201, 177, 238, 63, 230, 74, 152, 45, 242, 83, 199, 167 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("e04f51a5-e78c-422c-8a98-203c1cb8e504"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("991bb54c-8db7-42b0-bec6-10af49e3438a") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e04f51a5-e78c-422c-8a98-203c1cb8e504"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("991bb54c-8db7-42b0-bec6-10af49e3438a"));

            migrationBuilder.AddColumn<Guid>(
                name: "BookId",
                table: "EBooks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 336, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 336, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 336, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 336, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 336, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 336, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 337, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 337, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 337, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 337, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 337, DateTimeKind.Utc).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 338, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 338, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 338, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 338, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 338, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 340, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 340, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 340, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 340, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 341, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 341, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 341, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 341, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 341, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 341, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 341, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 341, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 2, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 14, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 12, 42, 59, 342, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 344, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 344, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 344, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 12, 42, 59, 344, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("3c5f34c9-6594-48c3-bcea-9c4892113fbd"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 36, 180, 104, 72, 39, 245, 169, 212, 95, 202, 42, 34, 29, 31, 212, 95, 50, 186, 122, 204, 252, 59, 15, 114, 208, 251, 245, 235, 18, 23, 11, 36, 130, 171, 58, 105, 160, 162, 248, 168, 234, 102, 26, 5, 200, 116, 26, 24, 211, 140, 217, 143, 254, 207, 71, 124, 15, 225, 198, 172, 5, 135, 156, 152 }, new byte[] { 211, 73, 118, 178, 189, 189, 243, 23, 227, 244, 169, 25, 47, 81, 236, 73, 142, 190, 202, 116, 62, 118, 196, 240, 57, 39, 102, 155, 129, 80, 226, 27, 143, 90, 72, 183, 234, 59, 226, 27, 191, 24, 29, 231, 126, 215, 174, 78, 31, 196, 97, 169, 193, 238, 202, 13, 142, 202, 33, 148, 72, 33, 190, 166, 66, 100, 79, 154, 250, 239, 109, 35, 207, 86, 56, 2, 0, 122, 171, 24, 14, 31, 253, 165, 122, 36, 222, 223, 112, 8, 71, 53, 4, 250, 189, 127, 170, 185, 52, 238, 37, 220, 125, 195, 96, 10, 243, 70, 92, 76, 39, 207, 132, 149, 207, 184, 78, 93, 22, 240, 84, 6, 142, 221, 25, 64, 92, 177 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("29086f7e-6222-4bcb-ac44-c66c150ff7d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("3c5f34c9-6594-48c3-bcea-9c4892113fbd") });

            migrationBuilder.CreateIndex(
                name: "IX_EBooks_BookId",
                table: "EBooks",
                column: "BookId",
                unique: true,
                filter: "[BookId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_EBooks_Books_BookId",
                table: "EBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
