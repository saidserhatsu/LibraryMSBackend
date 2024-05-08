using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFeedBackTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("48f72478-041f-4559-b650-db0e7b60052e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4a275cf4-759e-410c-a19f-b5be5f89f255"));

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 739, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 739, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 739, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 739, DateTimeKind.Utc).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 739, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 739, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(752), "Oðuz" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                columns: new[] { "CreatedDate", "LastName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(768), "Tanpýnar" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                columns: new[] { "CreatedDate", "LastName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(754), "Atýlgan" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(760), "Reþat Nuri" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(762), "Yaþar" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Çalýkuþu", new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Ýnce Memed", new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Beyaz Diþ", new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Yaþar Ne Yaþar Ne Yaþamaz", new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Bir Gün Tek Baþýna", new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Gülþah", new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("23182d33-1ebf-4a74-a93d-0c63cd2047a2"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4052), "Ekonomi ve Finans Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4057), "Biliþim" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4046), "Tarih ve Tarihî Eserler Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4049), "Sanat ve Kültür Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4043), "Dünya Coðrafyasý Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4051), "Psikoloji Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4048), "Bilim ve Teknoloji Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4045), "Edebiyat ve Roman Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4054), "Felsefe ve Din Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4031), "Kiþisel Geliþim Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4056), "Çocuk ve Gençlik Kitaplarý Kataloðu" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4140), "Aþk" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4157), "Þiir" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4162), "Saðlýk" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4163), "Týp" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4170), "Eðitim" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4173), "Ýþ Dünyasý" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4177), "Kiþisel Geliþim" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6893), "Gece Yarýsý Kütüphanesi" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6879), "Akýllý yatýrýmcý" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                columns: new[] { "AuthorName", "CreatedDate", "EBookTitle" },
                values: new object[] { "Reþat Nuri Güntekin", new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6891), "Çalýkuþu" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6899), "Hýzlý ve Yavaþ Düþünme" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6896), "Deðersiz Bir Hayat" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(326), "Sanat ve Tasarým Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(316), "Felsefe Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(308), "Roman Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(318), "Ýþletme Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(303), "Psikoloji Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(299), "Tarih Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(305), "Edebiyat Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(321), "Hukuk Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(325), "Müzik Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(311), "Mimarlýk Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(313), "Bilim Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(320), "Ekonomi Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(315), "Teknoloji Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(323), "Medya ve Ýletiþim Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(310), "Sanat Kitaplarý" });

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 13, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 7, 6, 1, 747, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 324, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Admin", null },
                    { 325, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Read", null },
                    { 326, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Write", null },
                    { 327, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Create", null },
                    { 328, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Update", null },
                    { 329, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Delete", null }
                });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(829), "Ýletiþim Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(847), "Epsilon Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(841), "Martý Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(844), "Artemis Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(846), "Pegasus Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(831), "Doðan Kitap" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(835), "Everest Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(819), "Kapra Yayýncýlýk" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(838), "Koridor Yayýncýlýk" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(837), "Destek Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(850), "Ýþ Bankasý Kültür Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(834), "Altýn Kitaplar" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(822), "Alfa Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(824), "Timaþ Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(832), "Bilgi Yayýnevi" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(815), "Can Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(827), "YKY - Yapý Kredi Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(843), "Ýthaki Yayýnlarý" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(849), "Altýn Nokta Yayýnevi" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("188f4036-06ca-47fe-9663-a04a7eb4c881"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 210, 173, 98, 219, 188, 23, 123, 52, 155, 177, 205, 135, 61, 56, 115, 150, 145, 98, 205, 104, 180, 104, 165, 131, 220, 68, 144, 118, 214, 213, 234, 198, 61, 8, 24, 220, 52, 205, 151, 111, 230, 200, 95, 71, 184, 230, 153, 153, 230, 123, 252, 123, 35, 218, 116, 146, 108, 122, 107, 215, 82, 76, 6, 81 }, new byte[] { 116, 74, 0, 159, 17, 45, 7, 142, 59, 77, 223, 183, 50, 101, 244, 105, 170, 82, 84, 48, 8, 191, 125, 86, 241, 52, 186, 247, 142, 157, 251, 39, 10, 254, 108, 197, 244, 240, 144, 81, 94, 147, 228, 72, 177, 210, 74, 174, 40, 251, 231, 155, 165, 122, 193, 91, 214, 173, 113, 190, 154, 84, 113, 109, 84, 226, 4, 254, 97, 49, 237, 237, 101, 160, 26, 64, 132, 222, 140, 116, 98, 210, 86, 235, 126, 94, 34, 207, 1, 208, 41, 225, 209, 69, 118, 17, 219, 198, 141, 50, 180, 58, 1, 225, 86, 182, 61, 248, 147, 238, 207, 186, 56, 166, 82, 178, 82, 46, 96, 8, 203, 99, 187, 169, 255, 236, 188, 199 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("16fab5bf-6832-402b-b09c-39db4b2202bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("188f4036-06ca-47fe-9663-a04a7eb4c881") });

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_MemberId",
                table: "FeedBacks",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("16fab5bf-6832-402b-b09c-39db4b2202bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("188f4036-06ca-47fe-9663-a04a7eb4c881"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9619), "Oğuz" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                columns: new[] { "CreatedDate", "LastName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9632), "Tanpınar" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                columns: new[] { "CreatedDate", "LastName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9621), "Atılgan" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9626), "Reşat Nuri" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                columns: new[] { "CreatedDate", "FirstName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9627), "Yaşar" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 927, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Çalıkuşu", new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "İnce Memed", new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Beyaz Diş", new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Yaşar Ne Yaşar Ne Yaşamaz", new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Bir Gün Tek Başına", new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                columns: new[] { "BookTitle", "CreatedDate" },
                values: new object[] { "Gülşah", new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 928, DateTimeKind.Utc).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("23182d33-1ebf-4a74-a93d-0c63cd2047a2"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4250), "Ekonomi ve Finans Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4254), "Bilişim" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4244), "Tarih ve Tarihî Eserler Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4247), "Sanat ve Kültür Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4241), "Dünya Coğrafyası Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4248), "Psikoloji Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4245), "Bilim ve Teknoloji Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4242), "Edebiyat ve Roman Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4251), "Felsefe ve Din Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4228), "Kişisel Gelişim Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 929, DateTimeKind.Local).AddTicks(4252), "Çocuk ve Gençlik Kitapları Kataloğu" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(146), "Aşk" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(160), "Şiir" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(191), "Sağlık" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(193), "Tıp" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(194), "Eğitim" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(197), "İş Dünyası" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 930, DateTimeKind.Utc).AddTicks(201), "Kişisel Gelişim" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 930, DateTimeKind.Local).AddTicks(3697), "Gece Yarısı Kütüphanesi" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 930, DateTimeKind.Local).AddTicks(3682), "Akıllı yatırımcı" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                columns: new[] { "AuthorName", "CreatedDate", "EBookTitle" },
                values: new object[] { "Reşat Nuri Güntekin", new DateTime(2024, 5, 8, 3, 42, 25, 930, DateTimeKind.Local).AddTicks(3694), "Çalıkuşu" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 930, DateTimeKind.Local).AddTicks(3704), "Hızlı ve Yavaş Düşünme" });

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                columns: new[] { "CreatedDate", "EBookTitle" },
                values: new object[] { new DateTime(2024, 5, 8, 3, 42, 25, 930, DateTimeKind.Local).AddTicks(3701), "Değersiz Bir Hayat" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8214), "Sanat ve Tasarım Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8204), "Felsefe Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8196), "Roman Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8206), "İşletme Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8190), "Psikoloji Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8187), "Tarih Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8193), "Edebiyat Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8209), "Hukuk Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8213), "Müzik Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8200), "Mimarlık Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8201), "Bilim Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8208), "Ekonomi Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8203), "Teknoloji Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8211), "Medya ve İletişim Kitapları" });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                columns: new[] { "CreatedDate", "ShelfName" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 931, DateTimeKind.Utc).AddTicks(8198), "Sanat Kitapları" });

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 13, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 26, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 7, 0, 42, 25, 932, DateTimeKind.Utc).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9377), "İletişim Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9394), "Epsilon Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9388), "Martı Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9391), "Artemis Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9393), "Pegasus Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9379), "Doğan Kitap" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9383), "Everest Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9370), "Kapra Yayıncılık" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9386), "Koridor Yayıncılık" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9384), "Destek Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9397), "İş Bankası Kültür Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9381), "Altın Kitaplar" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9372), "Alfa Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9373), "Timaş Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9380), "Bilgi Yayınevi" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9367), "Can Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9376), "YKY - Yapı Kredi Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9390), "İthaki Yayınları" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2024, 5, 8, 0, 42, 25, 933, DateTimeKind.Utc).AddTicks(9395), "Altın Nokta Yayınevi" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("4a275cf4-759e-410c-a19f-b5be5f89f255"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 237, 191, 94, 31, 103, 199, 49, 66, 132, 94, 13, 34, 163, 190, 212, 254, 250, 229, 185, 119, 188, 193, 109, 166, 246, 44, 36, 96, 196, 250, 57, 35, 205, 134, 68, 149, 71, 206, 130, 230, 242, 19, 185, 37, 137, 123, 248, 70, 233, 116, 236, 210, 102, 233, 46, 199, 15, 235, 167, 164, 56, 11, 254, 93 }, new byte[] { 175, 196, 123, 54, 173, 65, 216, 251, 132, 197, 236, 15, 97, 151, 182, 181, 124, 55, 67, 143, 31, 103, 18, 131, 241, 225, 138, 7, 69, 128, 230, 108, 21, 217, 244, 207, 46, 84, 252, 241, 178, 116, 203, 14, 31, 52, 163, 91, 166, 168, 224, 174, 161, 85, 75, 212, 143, 145, 47, 4, 221, 242, 86, 228, 96, 250, 42, 90, 87, 212, 135, 254, 178, 140, 203, 196, 159, 35, 98, 177, 59, 118, 165, 25, 206, 109, 54, 209, 217, 245, 39, 188, 43, 109, 143, 4, 59, 14, 125, 93, 76, 37, 8, 209, 56, 205, 186, 109, 40, 197, 196, 13, 124, 68, 15, 223, 121, 251, 185, 231, 159, 131, 136, 31, 118, 39, 130, 241 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("48f72478-041f-4559-b650-db0e7b60052e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("4a275cf4-759e-410c-a19f-b5be5f89f255") });
        }
    }
}
