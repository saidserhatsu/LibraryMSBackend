using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class magazineseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("48418be7-ac85-4dc5-acc6-6ecfff81b046"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f70d8fd3-f7fd-46dd-b591-4a23591ec958"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 229, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 232, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 232, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 232, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 232, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 234, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 234, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 234, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 234, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.InsertData(
                table: "Magazines",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "ISSNCode", "MagazineTitle", "Number", "PublisherId", "ReleaseDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"), 2, new DateTime(2024, 4, 5, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1288), null, "ISSN8888-9999", "Foodie Finds", 5, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"), 1, new DateTime(2024, 4, 10, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1279), null, "ISSN9876-5432", "Health & Wellness", 2, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"), 1, new DateTime(2024, 4, 20, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1285), null, "ISSN7777-4321", "Travel Trends", 4, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("44519209-e844-4908-9d92-75db10400dcc"), 1, new DateTime(2024, 4, 25, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1291), null, "ISSN4444-3333", "Artistic Expressions", 6, new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"), new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"), 2, new DateTime(2024, 4, 18, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1294), null, "ISSN2222-1111", "Fashion Forward", 7, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"), 2, new DateTime(2024, 3, 31, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1245), null, "ISSN1234-5678", "Tech Insights", 1, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"), 1, new DateTime(2024, 4, 22, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1297), null, "ISSN9999-8888", "Sports Spectacle", 8, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"), 3, new DateTime(2024, 4, 27, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1299), null, "ISSN3333-4444", "Science Scopes", 9, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"), 3, new DateTime(2024, 4, 15, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1282), null, "ISSN5555-1234", "Finance Focus", 3, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"), 2, new DateTime(2024, 4, 29, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1302), null, "ISSN6666-5555", "Music Monthly", 10, new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 237, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 237, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 237, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 49, 50, 237, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("2eea8e7b-531e-4681-b474-728984f2287b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 47, 255, 163, 125, 224, 61, 221, 94, 7, 24, 190, 107, 149, 29, 129, 68, 226, 158, 252, 151, 184, 151, 88, 145, 137, 9, 166, 108, 36, 200, 88, 224, 62, 184, 26, 229, 246, 139, 213, 97, 145, 185, 222, 78, 10, 130, 50, 196, 108, 228, 178, 37, 172, 5, 1, 80, 123, 91, 27, 147, 115, 12, 144, 5 }, new byte[] { 192, 71, 182, 216, 104, 120, 242, 243, 58, 12, 72, 141, 133, 93, 66, 75, 23, 177, 82, 98, 123, 48, 3, 145, 150, 143, 108, 107, 238, 157, 66, 93, 222, 40, 183, 130, 69, 120, 205, 202, 231, 109, 251, 215, 153, 21, 183, 91, 71, 66, 48, 112, 117, 72, 161, 233, 96, 240, 183, 160, 129, 143, 101, 186, 96, 254, 249, 227, 234, 131, 29, 10, 199, 174, 248, 172, 11, 236, 97, 101, 164, 28, 242, 118, 210, 124, 22, 64, 105, 226, 111, 201, 125, 78, 8, 141, 168, 125, 141, 116, 167, 237, 28, 47, 255, 248, 46, 99, 178, 212, 95, 200, 185, 165, 91, 95, 126, 172, 108, 218, 128, 180, 20, 157, 25, 34, 175, 184 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("aff3f46c-ba08-407c-8a5a-2aabd942ad59"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("2eea8e7b-531e-4681-b474-728984f2287b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"));

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"));

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"));

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"));

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"));

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"));

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"));

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"));

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"));

            migrationBuilder.DeleteData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("aff3f46c-ba08-407c-8a5a-2aabd942ad59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2eea8e7b-531e-4681-b474-728984f2287b"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 663, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 664, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 664, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 664, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 664, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 664, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 666, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 666, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 666, DateTimeKind.Utc).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 666, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 668, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 668, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 668, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 668, DateTimeKind.Utc).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 671, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 671, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 671, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 48, 7, 671, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("f70d8fd3-f7fd-46dd-b591-4a23591ec958"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 137, 12, 173, 247, 206, 31, 195, 214, 56, 49, 128, 196, 189, 186, 43, 119, 218, 151, 22, 200, 105, 167, 136, 195, 69, 66, 253, 213, 52, 109, 243, 255, 156, 204, 207, 252, 134, 169, 147, 117, 242, 45, 95, 24, 106, 54, 177, 61, 42, 121, 159, 171, 210, 157, 59, 197, 28, 253, 121, 214, 177, 65, 66, 105 }, new byte[] { 137, 230, 255, 133, 132, 177, 187, 176, 144, 242, 31, 250, 40, 143, 167, 251, 212, 183, 16, 249, 114, 81, 37, 94, 163, 89, 213, 140, 89, 44, 185, 48, 116, 117, 54, 69, 1, 213, 172, 248, 236, 7, 205, 173, 59, 101, 29, 234, 66, 198, 99, 66, 218, 127, 11, 133, 135, 171, 172, 238, 48, 157, 34, 209, 48, 233, 202, 84, 181, 169, 1, 57, 129, 79, 93, 177, 228, 116, 64, 236, 239, 176, 47, 161, 198, 94, 50, 214, 159, 203, 144, 177, 62, 189, 117, 67, 187, 225, 102, 174, 84, 49, 79, 235, 183, 168, 222, 52, 38, 211, 242, 249, 100, 182, 90, 151, 138, 109, 80, 149, 41, 130, 248, 62, 5, 140, 204, 10 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("48418be7-ac85-4dc5-acc6-6ecfff81b046"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("f70d8fd3-f7fd-46dd-b591-4a23591ec958") });
        }
    }
}
