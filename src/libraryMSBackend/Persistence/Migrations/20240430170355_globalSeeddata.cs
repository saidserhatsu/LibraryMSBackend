using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class globalSeeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"), new Guid("224b200d-a4cb-4ad0-8957-662dd965794c") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"), new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"), new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"), new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"), new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"), new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa") });

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("aff3f46c-ba08-407c-8a5a-2aabd942ad59"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2eea8e7b-531e-4681-b474-728984f2287b"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9405), null, "Oğuz", "Atay", null },
                    { new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9409), null, "Vedat", "Türkali", null },
                    { new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9465), null, "Aziz", "Nesin", null },
                    { new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9411), null, "Jack", "London", null },
                    { new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9403), null, "Sabahattin", "Ali", null },
                    { new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9463), null, "Ahmet Hamdi", "Tanpınar", null },
                    { new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9407), null, "Yusuf", "Atılgan", null },
                    { new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9413), null, "Reşat Nuri", "Güntekin", null },
                    { new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9414), null, "Yaşar", "Kemal", null },
                    { new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9462), null, "Grigory", "Petrov", null },
                    { new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"), new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9460), null, "Emrah", "Serbes", null }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                columns: new[] { "BookEdition", "BookTitle", "CategoryId", "CreatedDate", "ISBNCode", "LocationId", "PageCount", "ReleaseDate" },
                values: new object[] { 1, "Yaşar Ne Yaşar Ne Yaşamaz", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8513), "9789759038472", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 343, 1977 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookEdition", "BookTitle", "CategoryId", "CreatedDate", "DeletedDate", "ISBNCode", "LocationId", "PageCount", "PublisherId", "ReleaseDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"), 1, "Çalıkuşu", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8545), null, "9786051414315", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 280, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 1922, 1, null },
                    { new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"), 1, "Nutuk", 2, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8518), null, "9789944888349", new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"), 343, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), 1977, 1, null },
                    { new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"), 1, "İnce Memed", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8548), null, "9789754709117", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 440, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 1955, 1, null },
                    { new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"), 1, "Aylak Adam", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8534), null, "9789750805158", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 176, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), 1959, 1, null },
                    { new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"), 1, "Beyaz Diş", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8541), null, "9786052954018", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 240, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 1906, 1, null },
                    { new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"), 1, "Bir Gün Tek Başına", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8537), null, "9789750736056", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 424, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), 1974, 1, null },
                    { new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"), 1, "Kürk Mantolu Madonna", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8526), null, "9789754700114", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 168, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), 1943, 1, null },
                    { new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"), 1, "Tutunamayanlar", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8530), null, "9789750812705", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 712, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), 1972, 1, null },
                    { new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"), 1, "Beyaz Zambaklar Ülkesinde", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8555), null, "9786050954201", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 216, new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"), 1928, 1, null },
                    { new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"), 1, "Gülşah", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8551), null, "9789750718352", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 360, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 1985, 1, null },
                    { new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"), 1, "Saatleri Ayarlama Enstitüsü", 3, new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8522), null, "9786051414315", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 420, new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"), 1961, 1, null }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9336));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9393), null, "Felsefe", null },
                    { 6, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9394), null, "Bilim Kurgu", null },
                    { 7, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9396), null, "Fantastik", null },
                    { 8, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9398), null, "Polisiye", null },
                    { 9, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9401), null, "Macera", null },
                    { 10, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9402), null, "Aşk", null },
                    { 11, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9403), null, "Çocuk", null },
                    { 12, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9405), null, "Biyografi", null },
                    { 13, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9406), null, "Otobiyografi", null },
                    { 14, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9407), null, "Gezi", null },
                    { 15, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9409), null, "Sanat", null },
                    { 16, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9410), null, "Mimari", null },
                    { 17, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9412), null, "Müzik", null },
                    { 18, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9413), null, "Tiyatro", null },
                    { 19, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9414), null, "Dans", null },
                    { 20, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9416), null, "Sinema", null },
                    { 21, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9417), null, "Şiir", null },
                    { 22, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9418), null, "Antoloji", null },
                    { 23, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9420), null, "Yemek", null },
                    { 24, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9421), null, "Sağlık", null },
                    { 25, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9423), null, "Tıp", null },
                    { 26, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9425), null, "Eğitim", null },
                    { 27, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9460), null, "Ekonomi", null },
                    { 28, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9461), null, "İş Dünyası", null },
                    { 29, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9463), null, "Hukuk", null },
                    { 30, new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9464), null, "Politika", null }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 476, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 476, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 476, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 476, DateTimeKind.Utc).AddTicks(9259));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 17, 3, 54, 477, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 479, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 479, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 479, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 479, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("763bd948-01d2-4f8d-bf10-65829234d398"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 185, 26, 188, 200, 111, 205, 173, 129, 63, 236, 18, 31, 87, 70, 99, 69, 21, 57, 123, 36, 245, 82, 65, 109, 93, 96, 182, 107, 244, 8, 185, 139, 209, 8, 52, 208, 127, 191, 2, 0, 91, 108, 177, 156, 14, 40, 199, 11, 202, 90, 84, 211, 97, 223, 170, 94, 69, 252, 108, 179, 206, 71, 188, 121 }, new byte[] { 235, 136, 146, 152, 136, 81, 126, 246, 16, 47, 51, 82, 216, 47, 212, 189, 85, 220, 240, 235, 18, 89, 87, 182, 2, 90, 227, 239, 41, 5, 51, 157, 108, 220, 57, 142, 202, 181, 13, 128, 71, 16, 117, 210, 146, 227, 186, 227, 139, 35, 92, 133, 10, 141, 82, 181, 140, 85, 130, 62, 196, 231, 238, 250, 49, 205, 160, 19, 39, 191, 204, 73, 62, 50, 26, 143, 95, 187, 22, 243, 62, 158, 135, 214, 111, 113, 208, 20, 191, 136, 108, 11, 244, 18, 11, 153, 75, 194, 185, 119, 84, 5, 229, 158, 129, 168, 31, 172, 158, 150, 210, 206, 156, 200, 99, 205, 53, 96, 161, 57, 178, 151, 159, 213, 227, 114, 98, 129 }, null });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId", "CreatedDate", "DeletedDate", "Id", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"), new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"), new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"), new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"), new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"), new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"), new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"), new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"), new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"), new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"), new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"), new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"), new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("68157702-3580-4d3b-8fc3-0fb440260347"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("763bd948-01d2-4f8d-bf10-65829234d398") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"), new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"), new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"), new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"), new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"), new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"), new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"), new Guid("81e99a97-2bfd-4754-9637-978b162bd04e") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"), new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"), new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"), new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"), new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"), new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41") });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("68157702-3580-4d3b-8fc3-0fb440260347"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("763bd948-01d2-4f8d-bf10-65829234d398"));

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

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId", "CreatedDate", "DeletedDate", "Id", "UpdatedDate" },
                values: new object[] { new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"), new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                columns: new[] { "BookEdition", "BookTitle", "CategoryId", "CreatedDate", "ISBNCode", "LocationId", "PageCount", "ReleaseDate" },
                values: new object[] { 10, "Nutuk", 2, new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3887), "9781234567897", new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"), 100, 1927 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookEdition", "BookTitle", "CategoryId", "CreatedDate", "DeletedDate", "ISBNCode", "LocationId", "PageCount", "PublisherId", "ReleaseDate", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"), 21, "Yeraltından Notlar", 1, new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3895), null, "9472837462176", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 300, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 2000, 1, null },
                    { new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"), 9, "Suç ve Ceza", 3, new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3899), null, "6482901846372", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 220, new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"), 1983, 1, null },
                    { new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"), 15, "Savaş Sanatı", 2, new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3891), null, "4373695632743", new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"), 200, new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"), 1959, 1, null },
                    { new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"), 14, "Metal Fırtına", 3, new DateTime(2024, 4, 30, 15, 49, 50, 230, DateTimeKind.Utc).AddTicks(3902), null, "9473284657234", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), 110, new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), 2004, 1, null }
                });

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

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 15, 49, 50, 235, DateTimeKind.Utc).AddTicks(1302));

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
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId", "CreatedDate", "DeletedDate", "Id", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"), new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"), new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"), new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"), new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"), new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("aff3f46c-ba08-407c-8a5a-2aabd942ad59"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("2eea8e7b-531e-4681-b474-728984f2287b") });
        }
    }
}
