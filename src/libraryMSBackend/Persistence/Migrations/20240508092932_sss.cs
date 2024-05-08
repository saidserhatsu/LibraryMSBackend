using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class sss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3a1e15bb-15c3-4c40-b5c5-91d370d653a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a904ee20-7021-495b-af88-579fa4d7d533"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4260), "Oğuz" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                columns: new[] { "CreatedDate", "LastName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4276), "Tanpınar" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                columns: new[] { "CreatedDate", "LastName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4262), "Atılgan" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4269), "Reşat Nuri" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4271), "Yaşar" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 514, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Çalıkuşu", new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "İnce Memed", new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Beyaz Diş", new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Yaşar Ne Yaşar Ne Yaşamaz", new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Bir Gün Tek Başına", new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Gülşah", new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 515, DateTimeKind.Utc).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("23182d33-1ebf-4a74-a93d-0c63cd2047a2"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6234), "Ekonomi ve Finans Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6238), "Bilişim" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6228), "Tarih ve Tarihî Eserler Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6231), "Sanat ve Kültür Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6225), "Dünya Coğrafyası Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6233), "Psikoloji Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6230), "Bilim ve Teknoloji Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6227), "Edebiyat ve Roman Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6236), "Felsefe ve Din Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6213), "Kişisel Gelişim Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 516, DateTimeKind.Local).AddTicks(6237), "Çocuk ve Gençlik Kitapları Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6666), "Aşk" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6683), "Şiir" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6687), "Sağlık" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6688), "Tıp" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6689), "Eğitim" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6692), "İş Dünyası" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 517, DateTimeKind.Utc).AddTicks(6725), "Kişisel Gelişim" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 517, DateTimeKind.Local).AddTicks(9367), "Gece Yarısı Kütüphanesi" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 517, DateTimeKind.Local).AddTicks(9354), "Akıllı yatırımcı" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                columns: new[] { "AuthorName", "CreatedDate", "EBookTitle" },
                values: new object[] { "Reşat Nuri Güntekin", new DateTime(2024, 5, 8, 12, 29, 31, 517, DateTimeKind.Local).AddTicks(9364), "Çalıkuşu" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 517, DateTimeKind.Local).AddTicks(9372), "Hızlı ve Yavaş Düşünme" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 12, 29, 31, 517, DateTimeKind.Local).AddTicks(9369), "Değersiz Bir Hayat" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9234), "Sanat ve Tasarım Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9223), "Felsefe Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9209), "Roman Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9225), "İşletme Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9204), "Psikoloji Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9198), "Tarih Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9206), "Edebiyat Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9228), "Hukuk Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9231), "Müzik Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9213), "Mimarlık Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9219), "Bilim Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9226), "Ekonomi Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9221), "Teknoloji Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9229), "Medya ve İletişim Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 519, DateTimeKind.Utc).AddTicks(9211), "Sanat Kitapları" });

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 13, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 9, 29, 31, 520, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(78), "İletişim Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(157), "Epsilon Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(90), "Martı Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(92), "Artemis Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(94), "Pegasus Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(80), "Doğan Kitap" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(84), "Everest Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(69), "Kapra Yayıncılık" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(87), "Koridor Yayıncılık" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(86), "Destek Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(162), "İş Bankası Kültür Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(83), "Altın Kitaplar" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(74), "Alfa Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(75), "Timaş Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(81), "Bilgi Yayınevi" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(66), "Can Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(77), "YKY - Yapı Kredi Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(91), "İthaki Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 9, 29, 31, 523, DateTimeKind.Utc).AddTicks(160), "Altın Nokta Yayınevi" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("8f7dedba-5473-4613-9600-fa4dbb1916cc"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 155, 169, 99, 240, 95, 96, 177, 16, 4, 124, 238, 147, 107, 117, 165, 205, 53, 255, 78, 159, 127, 109, 154, 245, 249, 126, 50, 76, 118, 146, 2, 244, 181, 22, 179, 10, 137, 103, 171, 159, 8, 11, 134, 17, 150, 136, 45, 210, 240, 136, 130, 89, 231, 79, 243, 52, 77, 173, 18, 253, 13, 177, 128, 219 }, new byte[] { 190, 153, 10, 86, 176, 219, 78, 215, 209, 74, 193, 229, 9, 67, 73, 41, 176, 20, 173, 181, 213, 181, 66, 68, 173, 7, 255, 148, 112, 80, 118, 119, 205, 49, 199, 0, 253, 238, 15, 111, 102, 175, 213, 190, 229, 78, 254, 214, 225, 115, 100, 173, 220, 86, 100, 184, 24, 227, 213, 66, 98, 90, 159, 228, 234, 20, 150, 114, 60, 22, 5, 230, 1, 162, 147, 142, 208, 23, 15, 205, 97, 182, 48, 137, 62, 149, 212, 255, 244, 37, 239, 113, 61, 14, 65, 236, 98, 1, 138, 198, 215, 222, 98, 59, 106, 254, 236, 0, 231, 86, 52, 108, 241, 120, 85, 140, 179, 59, 48, 83, 62, 84, 234, 239, 116, 135, 153, 36 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8cea78e5-c7c0-4999-873c-c8c909e2114c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("8f7dedba-5473-4613-9600-fa4dbb1916cc") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8cea78e5-c7c0-4999-873c-c8c909e2114c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8f7dedba-5473-4613-9600-fa4dbb1916cc"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 593, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 593, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 593, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 593, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 593, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 593, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3705), "Oðuz" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                columns: new[] { "CreatedDate", "LastName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3723), "Tanpýnar" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                columns: new[] { "CreatedDate", "LastName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3706), "Atýlgan" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3716), "Reþat Nuri" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3717), "Yaþar" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Çalýkuþu", new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Ýnce Memed", new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Beyaz Diþ", new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Yaþar Ne Yaþar Ne Yaþamaz", new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Bir Gün Tek Baþýna", new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Gülþah", new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("23182d33-1ebf-4a74-a93d-0c63cd2047a2"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8860), "Ekonomi ve Finans Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8864), "Biliþim" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8852), "Tarih ve Tarihî Eserler Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8857), "Sanat ve Kültür Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8778), "Dünya Coðrafyasý Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8858), "Psikoloji Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8854), "Bilim ve Teknoloji Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8780), "Edebiyat ve Roman Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8861), "Felsefe ve Din Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8769), "Kiþisel Geliþim Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8863), "Çocuk ve Gençlik Kitaplarý Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8785), "Aþk" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8802), "Þiir" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8807), "Saðlýk" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8814), "Týp" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8815), "Eðitim" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8818), "Ýþ Dünyasý" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8823), "Kiþisel Geliþim" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1383), "Gece Yarýsý Kütüphanesi" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1370), "Akýllý yatýrýmcý" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                columns: new[] { "AuthorName", "CreatedDate", "EBookTitle" },
                values: new object[] { "Reþat Nuri Güntekin", new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1380), "Çalýkuþu" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1389), "Hýzlý ve Yavaþ Düþünme" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1386), "Deðersiz Bir Hayat" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(743), "Sanat ve Tasarým Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(733), "Felsefe Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(724), "Roman Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(734), "Ýþletme Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(719), "Psikoloji Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(716), "Tarih Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(721), "Edebiyat Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(738), "Hukuk Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(741), "Müzik Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(727), "Mimarlýk Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(729), "Bilim Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(736), "Ekonomi Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(731), "Teknoloji Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(739), "Medya ve Ýletiþim Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(726), "Sanat Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 13, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3984), "Ýletiþim Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4009), "Epsilon Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4002), "Martý Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4005), "Artemis Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4008), "Pegasus Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3985), "Doðan Kitap" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3997), "Everest Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3974), "Kapra Yayýncýlýk" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3999), "Koridor Yayýncýlýk" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3998), "Destek Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4012), "Ýþ Bankasý Kültür Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3988), "Altýn Kitaplar" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3978), "Alfa Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3980), "Timaþ Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3987), "Bilgi Yayýnevi" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3970), "Can Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3981), "YKY - Yapý Kredi Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4004), "Ýthaki Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4011), "Altýn Nokta Yayýnevi" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("a904ee20-7021-495b-af88-579fa4d7d533"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 81, 18, 44, 254, 108, 75, 249, 252, 211, 206, 121, 195, 60, 209, 114, 226, 162, 165, 64, 214, 68, 130, 106, 28, 23, 130, 185, 130, 29, 140, 188, 237, 146, 178, 224, 244, 1, 220, 112, 198, 60, 58, 145, 211, 124, 199, 236, 86, 194, 87, 170, 122, 201, 237, 51, 170, 250, 1, 96, 124, 198, 125, 15, 146 }, new byte[] { 149, 13, 192, 166, 253, 238, 131, 216, 221, 229, 39, 31, 213, 108, 126, 177, 9, 37, 112, 51, 149, 200, 31, 19, 153, 33, 101, 95, 126, 254, 74, 147, 30, 162, 148, 28, 119, 212, 200, 55, 44, 31, 125, 21, 27, 202, 199, 79, 42, 24, 19, 215, 212, 163, 1, 90, 45, 111, 212, 126, 253, 202, 41, 165, 136, 25, 195, 156, 54, 146, 67, 125, 213, 203, 154, 192, 229, 249, 36, 107, 23, 164, 151, 187, 214, 216, 190, 163, 245, 0, 107, 190, 236, 195, 235, 255, 151, 209, 67, 231, 165, 215, 120, 8, 116, 250, 36, 59, 244, 228, 5, 242, 220, 51, 184, 65, 38, 227, 74, 165, 147, 240, 140, 195, 17, 170, 6, 71 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("3a1e15bb-15c3-4c40-b5c5-91d370d653a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("a904ee20-7021-495b-af88-579fa4d7d533") });
        }
    }
}
