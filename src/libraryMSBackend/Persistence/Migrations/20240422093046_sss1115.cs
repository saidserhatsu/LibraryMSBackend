using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class sss1115 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("7f66f215-1ed8-4030-a1ff-0448784a3ff4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4f3d0609-2d3e-4744-b923-79732161b67d"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 764, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 764, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 764, DateTimeKind.Utc).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 764, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 764, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 764, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 765, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 765, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 765, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 765, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 765, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 766, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 766, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 766, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 766, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 766, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 768, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 768, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 768, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 768, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 770, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 770, DateTimeKind.Utc).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 770, DateTimeKind.Utc).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 770, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 770, DateTimeKind.Utc).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 770, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 770, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 770, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 2, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 14, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 9, 30, 45, 771, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 773, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 773, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 773, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 30, 45, 773, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("efade444-5935-40c4-897b-c0e2430e319b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 226, 95, 65, 48, 182, 185, 156, 153, 122, 220, 208, 110, 59, 238, 72, 249, 75, 174, 77, 187, 236, 192, 101, 204, 148, 55, 29, 32, 2, 94, 71, 37, 194, 146, 91, 19, 226, 248, 243, 226, 50, 212, 13, 57, 167, 53, 22, 88, 97, 37, 234, 33, 245, 140, 173, 116, 255, 32, 241, 187, 194, 207, 168, 207 }, new byte[] { 23, 249, 6, 255, 7, 246, 248, 190, 190, 211, 225, 81, 243, 254, 128, 12, 215, 59, 236, 249, 163, 80, 188, 200, 177, 234, 27, 41, 30, 82, 75, 50, 129, 155, 8, 120, 153, 168, 53, 249, 242, 103, 42, 234, 85, 95, 154, 193, 206, 83, 73, 30, 3, 151, 238, 126, 39, 11, 72, 79, 1, 61, 254, 165, 214, 192, 37, 33, 171, 188, 84, 165, 26, 46, 219, 52, 247, 207, 141, 116, 118, 3, 217, 229, 88, 145, 77, 34, 159, 4, 45, 122, 245, 22, 34, 34, 178, 69, 178, 165, 24, 224, 107, 221, 66, 224, 90, 97, 118, 53, 35, 88, 156, 3, 239, 63, 27, 179, 2, 95, 150, 125, 29, 38, 152, 44, 209, 113 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("12736edf-0703-450f-b4a3-f66a2ddd2c0e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("efade444-5935-40c4-897b-c0e2430e319b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("12736edf-0703-450f-b4a3-f66a2ddd2c0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efade444-5935-40c4-897b-c0e2430e319b"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 276, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 277, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 277, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 277, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 277, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 277, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 279, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 279, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 279, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 279, DateTimeKind.Utc).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 281, DateTimeKind.Utc).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 281, DateTimeKind.Utc).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 281, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 281, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 281, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 281, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 281, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 281, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 28, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 2, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 12, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 17, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 23, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 14, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 19, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 7, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 9, 27, 45, 282, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 285, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 285, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 285, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 9, 27, 45, 285, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("4f3d0609-2d3e-4744-b923-79732161b67d"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 214, 2, 175, 174, 127, 208, 84, 79, 56, 243, 56, 180, 158, 154, 227, 18, 240, 163, 61, 74, 79, 16, 131, 120, 66, 246, 130, 114, 38, 237, 99, 174, 99, 107, 114, 137, 205, 63, 43, 254, 71, 199, 190, 68, 169, 192, 246, 104, 8, 1, 231, 86, 248, 230, 108, 127, 234, 246, 181, 90, 125, 237, 158, 42 }, new byte[] { 66, 192, 93, 230, 148, 37, 172, 74, 131, 37, 206, 148, 195, 232, 209, 77, 164, 210, 172, 137, 44, 104, 23, 152, 33, 176, 238, 168, 238, 89, 159, 27, 45, 214, 100, 86, 125, 22, 252, 2, 83, 128, 42, 226, 130, 117, 48, 109, 34, 5, 170, 37, 23, 57, 115, 196, 57, 233, 16, 44, 50, 71, 128, 251, 221, 211, 103, 139, 205, 183, 81, 214, 182, 153, 124, 195, 120, 157, 204, 47, 109, 231, 186, 148, 203, 182, 28, 14, 74, 124, 113, 85, 213, 24, 247, 127, 185, 246, 133, 180, 214, 78, 129, 81, 148, 103, 222, 221, 49, 239, 236, 208, 136, 27, 135, 193, 107, 111, 152, 72, 246, 161, 104, 167, 199, 27, 239, 119 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("7f66f215-1ed8-4030-a1ff-0448784a3ff4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("4f3d0609-2d3e-4744-b923-79732161b67d") });
        }
    }
}
