using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class globalSeeddatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("68157702-3580-4d3b-8fc3-0fb440260347"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("763bd948-01d2-4f8d-bf10-65829234d398"));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 214, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 215, DateTimeKind.Utc).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 217, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FloorNo", "Name", "ShelfName", "ShelfNo", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6018), null, 3, "Merkez Kütüphane", "Sanat ve Tasarım Kitapları", 5, null },
                    { new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6008), null, 2, "Merkez Kütüphane", "Felsefe Kitapları", 4, null },
                    { new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6010), null, 2, "Merkez Kütüphane", "İşletme Kitapları", 5, null },
                    { new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6013), null, 3, "Merkez Kütüphane", "Hukuk Kitapları", 2, null },
                    { new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6016), null, 3, "Merkez Kütüphane", "Müzik Kitapları", 4, null },
                    { new Guid("9466485b-9c11-433a-b384-7d6382333193"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6004), null, 2, "Merkez Kütüphane", "Mimarlık Kitapları", 1, null },
                    { new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6005), null, 2, "Merkez Kütüphane", "Bilim Kitapları", 2, null },
                    { new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6012), null, 3, "Merkez Kütüphane", "Ekonomi Kitapları", 1, null },
                    { new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6007), null, 2, "Merkez Kütüphane", "Teknoloji Kitapları", 3, null },
                    { new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6015), null, 3, "Merkez Kütüphane", "Medya ve İletişim Kitapları", 3, null },
                    { new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"), new DateTime(2024, 4, 30, 17, 14, 3, 219, DateTimeKind.Utc).AddTicks(6002), null, 1, "Merkez Kütüphane", "Sanat Kitapları", 5, null }
                });

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 5, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 10, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 31, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 22, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 27, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 15, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 29, 17, 14, 3, 220, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Language", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("124589ea-4803-490c-9c86-dd68e59b8825"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4736), null, "TR", "İletişim Yayınları", null },
                    { new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4781), null, "TR", "Epsilon Yayınları", null },
                    { new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4776), null, "TR", "Martı Yayınları", null },
                    { new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4778), null, "TR", "Artemis Yayınları", null },
                    { new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4780), null, "TR", "Pegasus Yayınları", null },
                    { new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4738), null, "TR", "Doğan Kitap", null },
                    { new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4742), null, "TR", "Everest Yayınları", null },
                    { new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4774), null, "TR", "Remzi Kitabevi", null },
                    { new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4773), null, "TR", "Koridor Yayıncılık", null },
                    { new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4744), null, "TR", "Destek Yayınları", null },
                    { new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4784), null, "TR", "İş Bankası Kültür Yayınları", null },
                    { new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4741), null, "TR", "Altın Kitaplar", null },
                    { new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4740), null, "TR", "Bilgi Yayınevi", null },
                    { new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4734), null, "TR", "YKY - Yapı Kredi Yayınları", null },
                    { new Guid("d72f299e-e695-49c5-94fb-79e382710b91"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4777), null, "TR", "İthaki Yayınları", null },
                    { new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"), new DateTime(2024, 4, 30, 17, 14, 3, 222, DateTimeKind.Utc).AddTicks(4783), null, "TR", "Altın Nokta Yayınevi", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("5a588063-88fe-45e0-a126-d3284363eb76"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 19, 226, 156, 143, 115, 185, 144, 250, 199, 190, 112, 30, 202, 59, 210, 216, 175, 142, 51, 199, 148, 5, 104, 119, 238, 234, 87, 118, 145, 196, 72, 152, 106, 4, 90, 97, 7, 99, 217, 60, 227, 221, 123, 148, 163, 139, 191, 115, 3, 179, 121, 232, 28, 181, 227, 136, 194, 61, 4, 75, 111, 85, 232, 122 }, new byte[] { 1, 38, 82, 224, 174, 136, 18, 95, 125, 229, 0, 60, 188, 150, 250, 130, 151, 247, 31, 9, 94, 76, 65, 221, 2, 193, 83, 88, 167, 45, 98, 66, 31, 134, 114, 67, 239, 87, 6, 150, 229, 157, 21, 208, 68, 54, 37, 59, 136, 86, 49, 159, 129, 81, 136, 2, 79, 101, 133, 81, 36, 250, 222, 84, 94, 28, 223, 10, 157, 226, 18, 89, 254, 240, 59, 54, 47, 1, 1, 35, 66, 247, 117, 64, 80, 65, 251, 191, 117, 3, 86, 36, 52, 21, 114, 246, 82, 239, 79, 17, 7, 28, 84, 122, 210, 48, 12, 218, 9, 100, 127, 186, 243, 188, 110, 115, 117, 240, 197, 73, 18, 229, 112, 244, 252, 224, 126, 184 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("327eb1d6-6ab1-432c-a0d4-104ecf44297e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("5a588063-88fe-45e0-a126-d3284363eb76") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("327eb1d6-6ab1-432c-a0d4-104ecf44297e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a588063-88fe-45e0-a126-d3284363eb76"));

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
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 471, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 472, DateTimeKind.Utc).AddTicks(8522));

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 17, 3, 54, 474, DateTimeKind.Utc).AddTicks(9464));

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
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("68157702-3580-4d3b-8fc3-0fb440260347"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("763bd948-01d2-4f8d-bf10-65829234d398") });
        }
    }
}
