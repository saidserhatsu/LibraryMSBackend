using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class eBookSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("576fef5d-d719-4c66-986f-d1e7f0d4db45"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("23b06558-42fe-4683-bdf1-8241d3991021"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 624, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 625, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("23182d33-1ebf-4a74-a93d-0c63cd2047a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 42, 30, 626, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 627, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.InsertData(
                table: "EBooks",
                columns: new[] { "Id", "AuthorName", "CategoryId", "CreatedDate", "DeletedDate", "EBookTitle", "FileUrl", "ISBNCode", "ImageUrl", "PageCount", "ReleaseDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("179a926b-d022-4bcc-8e78-f977127853e1"), "Merve Korkmaz", 7, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1765), null, "Çöl Rüzgarı", "www.fileurl.com/pdf7", "9789759038478", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 290, 2015, null },
                    { new Guid("1c9505c2-16a5-4830-aee9-630e70f51391"), "Ayşe Nur", 5, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1759), null, "Yeşil Bahçe", "www.fileurl.com/pdf5", "9789759038476", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 250, 2005, null },
                    { new Guid("217a3bae-a23e-43f6-b7c9-30d9731b536c"), "Mustafa Koca", 1, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1757), null, "Deniz Yıldızı", "www.fileurl.com/pdf4", "9789759038475", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 310, 2000, null },
                    { new Guid("2583810b-e2bf-41de-8faa-a88409df1849"), "Emine Gül", 2, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1755), null, "Gökyüzü", "www.fileurl.com/pdf3", "9789759038474", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 176, 1995, null },
                    { new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"), "Hasan Tek", 3, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1742), null, "Yaşar Ne Yaşar Ne Yaşamaz", "www.fileurl.com/pdf1", "9789759038472", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 343, 1977, null },
                    { new Guid("602a8dfe-36e7-4945-a569-c3eb3300d490"), "Barış Taş", 10, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1771), null, "Dağ Başında", "www.fileurl.com/pdf10", "9789759038481", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 305, 2023, null },
                    { new Guid("6cc13c88-973f-4720-9aea-5fe3fe6d4670"), "Zeynep Kılıç", 9, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1768), null, "Nehrin Kıyısı", "www.fileurl.com/pdf9", "9789759038480", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 330, 2022, null },
                    { new Guid("74e96a42-91c6-4d66-bacb-ee04e90ca081"), "Selin Özgür", 8, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1766), null, "Vadi", "www.fileurl.com/pdf8", "9789759038479", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 260, 2020, null },
                    { new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"), "Ahmet Yılmaz", 4, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1752), null, "Siyah Beyaz", "www.fileurl.com/pdf2", "9789759038473", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 210, 1988, null },
                    { new Guid("b7456736-9fbf-4e9b-869c-8935a4f5cca1"), "Ali Demir", 6, new DateTime(2024, 5, 3, 18, 42, 30, 628, DateTimeKind.Local).AddTicks(1762), null, "Mavi Yol", "www.fileurl.com/pdf6", "9789759038477", "https://res.cloudinary.com/dafqsbtn7/image/upload/v1714747440/mzc4vzmdoa2kpkkesfi4.jpg", 270, 2010, null }
                });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 629, DateTimeKind.Utc).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 13, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 3, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 15, 42, 30, 630, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9361));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 42, 30, 632, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("da94f4af-1181-4a4d-ae54-ee70921cc551"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 35, 170, 180, 218, 212, 14, 118, 199, 117, 247, 71, 154, 178, 144, 30, 247, 77, 88, 178, 162, 155, 187, 50, 103, 21, 222, 53, 171, 175, 81, 209, 31, 186, 254, 71, 111, 138, 174, 13, 53, 197, 40, 92, 233, 133, 217, 30, 216, 224, 54, 151, 254, 40, 123, 218, 92, 141, 96, 67, 214, 241, 151, 237, 232 }, new byte[] { 212, 46, 211, 220, 76, 160, 109, 14, 24, 118, 4, 251, 132, 70, 175, 242, 190, 180, 187, 170, 215, 113, 122, 122, 50, 50, 93, 167, 233, 82, 205, 59, 81, 166, 94, 67, 96, 239, 195, 160, 237, 36, 248, 25, 65, 231, 146, 137, 111, 106, 43, 173, 95, 45, 182, 39, 117, 178, 206, 158, 26, 225, 186, 239, 53, 198, 231, 87, 61, 67, 36, 87, 237, 11, 16, 183, 9, 18, 185, 123, 141, 97, 250, 7, 172, 85, 194, 227, 11, 187, 156, 91, 21, 164, 226, 234, 239, 102, 4, 31, 99, 60, 160, 134, 241, 206, 110, 117, 31, 156, 181, 23, 58, 1, 42, 233, 43, 200, 186, 174, 104, 181, 190, 55, 31, 228, 75, 202 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("c0f7c0a0-2df2-42cc-b4f2-9cdb0f5b8408"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("da94f4af-1181-4a4d-ae54-ee70921cc551") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("179a926b-d022-4bcc-8e78-f977127853e1"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("1c9505c2-16a5-4830-aee9-630e70f51391"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("217a3bae-a23e-43f6-b7c9-30d9731b536c"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("602a8dfe-36e7-4945-a569-c3eb3300d490"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("6cc13c88-973f-4720-9aea-5fe3fe6d4670"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("74e96a42-91c6-4d66-bacb-ee04e90ca081"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"));

            migrationBuilder.DeleteData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("b7456736-9fbf-4e9b-869c-8935a4f5cca1"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("c0f7c0a0-2df2-42cc-b4f2-9cdb0f5b8408"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da94f4af-1181-4a4d-ae54-ee70921cc551"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 82, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 83, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("23182d33-1ebf-4a74-a93d-0c63cd2047a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 18, 22, 57, 84, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 85, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 88, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 13, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 3, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 15, 22, 57, 89, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 15, 22, 57, 91, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("23b06558-42fe-4683-bdf1-8241d3991021"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 199, 24, 226, 160, 235, 156, 157, 126, 133, 130, 23, 128, 73, 203, 7, 35, 245, 166, 10, 216, 192, 227, 97, 88, 68, 95, 189, 87, 13, 223, 58, 49, 83, 39, 184, 189, 34, 252, 75, 17, 218, 97, 176, 149, 188, 148, 187, 45, 15, 165, 143, 57, 170, 97, 46, 200, 98, 35, 89, 159, 95, 96, 109, 230 }, new byte[] { 84, 224, 159, 161, 107, 39, 108, 24, 46, 107, 67, 150, 117, 172, 92, 227, 149, 103, 125, 158, 42, 240, 65, 66, 200, 248, 49, 244, 102, 137, 1, 3, 180, 187, 12, 242, 174, 245, 72, 202, 235, 42, 241, 9, 77, 216, 67, 239, 50, 93, 176, 184, 60, 2, 53, 6, 47, 123, 35, 117, 164, 138, 74, 139, 216, 103, 223, 27, 219, 180, 15, 183, 150, 152, 143, 131, 84, 23, 74, 107, 190, 85, 3, 106, 70, 98, 240, 145, 217, 92, 147, 56, 49, 88, 47, 12, 1, 175, 81, 3, 83, 209, 191, 31, 133, 236, 24, 72, 26, 247, 47, 67, 71, 255, 180, 127, 51, 144, 14, 133, 253, 194, 52, 185, 83, 198, 83, 162 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("576fef5d-d719-4c66-986f-d1e7f0d4db45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("23b06558-42fe-4683-bdf1-8241d3991021") });
        }
    }
}
