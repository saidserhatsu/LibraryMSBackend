using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class eBookİmage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e17b5150-3832-4b3c-bf0a-d827cb508463"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6628cf3a-8a13-4c45-b23e-cc171e5868e3"));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "EBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 335, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 336, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 338, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 340, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 13, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 3, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 14, 51, 39, 341, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 14, 51, 39, 344, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("16ff6c52-212c-474f-bc8c-8b11cc250840"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 173, 221, 179, 54, 143, 97, 178, 3, 198, 223, 171, 120, 103, 35, 13, 48, 165, 247, 35, 27, 42, 195, 197, 194, 41, 7, 50, 42, 93, 162, 232, 150, 207, 99, 162, 57, 32, 223, 241, 71, 108, 52, 183, 150, 21, 130, 6, 55, 118, 84, 208, 79, 127, 12, 28, 75, 38, 15, 171, 197, 243, 163, 83, 78 }, new byte[] { 69, 69, 25, 166, 102, 70, 16, 134, 20, 93, 77, 105, 166, 94, 64, 255, 13, 84, 81, 53, 179, 242, 211, 167, 174, 0, 132, 247, 151, 83, 160, 76, 242, 6, 117, 145, 1, 208, 106, 103, 27, 207, 225, 28, 116, 225, 202, 10, 109, 183, 199, 117, 50, 83, 108, 133, 142, 21, 100, 43, 38, 156, 67, 144, 55, 237, 79, 96, 224, 162, 20, 118, 41, 144, 194, 9, 38, 33, 10, 99, 55, 227, 208, 179, 64, 196, 77, 251, 243, 22, 36, 27, 82, 141, 222, 113, 225, 83, 51, 111, 111, 123, 42, 105, 146, 180, 38, 0, 51, 146, 80, 218, 144, 93, 39, 101, 229, 73, 254, 95, 211, 171, 47, 211, 208, 236, 2, 199 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("6b589fa8-04ca-47e1-ab95-c9eeb301d4ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("16ff6c52-212c-474f-bc8c-8b11cc250840") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6b589fa8-04ca-47e1-ab95-c9eeb301d4ef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("16ff6c52-212c-474f-bc8c-8b11cc250840"));

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "EBooks");

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("0e19a5be-6546-4c5a-9340-cf1e1748b1b1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("7085aa16-5230-42ca-941b-6d73c692053b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("9c6c985f-b331-4a85-bee5-c7d2a9d57073"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("bf3669a9-a784-4941-bf6e-4893374abb2b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("e014efc4-0973-4fc1-80bb-464b4d791173"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Announcements",
                keyColumn: "Id",
                keyValue: new Guid("f4710162-5b4a-4dfe-9bcf-8951ec64b55e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("283ba145-e4a5-4e21-8ae3-4a52cd44d399"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2bae52f5-6e58-4071-b79c-da1cba7f560b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("46a0ae1a-b4d4-49fa-bc99-302b29a4b7f5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("64919748-c9e3-423b-a9e0-51652edb5fba"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("7d9fbe1e-67b2-4911-bb06-47b042e2245b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("8f75fb32-c516-4c3a-8a96-fa98aede126b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ac24c21b-f665-4350-8129-9be9f02c2791"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("c5b259fb-a635-48b3-9a92-6155c317bc68"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e88f8263-c7f6-4c96-aa5e-969bbc7c7e34"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e8e83303-6ab3-4cb7-9573-7be6ab4d1a21"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 199, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ac0f60e-20d3-47d0-982e-2d642c19e704"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3645));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1aa5427d-24ac-48ae-8788-a5d8102056eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e73afc5-80d2-4549-bab8-02b69762dd04"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("399c68e7-f2ce-4416-893c-946dd3696ed3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48f650e8-1cc9-4bac-a77c-59b4b6056dc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8214333a-6ddd-4c4c-8803-dd2efd58cd64"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a315107-d02c-4d47-ab72-b48b3cfc0d56"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6e2a4ba-ab5f-473d-a47e-b6634c241389"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c776b453-d81f-4d5b-82af-845fcd3b08fb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1d16714-3328-42bd-a2b3-53fe5e03cb41"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 200, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 202, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 204, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("0126025b-b09b-443b-9cb0-f28d61a34a3c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 8, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("33ec09e7-b0fa-4f0d-ad57-168fbaf7797d"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 13, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("3bb08885-5ea5-405d-bcff-3ae7ec0b1911"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 23, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("44519209-e844-4908-9d92-75db10400dcc"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 28, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("46a33882-534b-4c1e-8049-14dd03f7a7fa"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 21, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("8d9c7bb2-6baf-4319-a3a3-a2ac3092c8f1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 3, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("a6df0f9e-9aa2-49c6-bf84-2033ae97355f"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("ba3158f1-2c48-47a6-8c64-be115d0b02e1"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 30, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("c5939743-2f35-48f8-9858-51f4c1556bf0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Magazines",
                keyColumn: "Id",
                keyValue: new Guid("f24b9d85-f392-45b1-a8c6-9a42edde0d6a"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 2, 11, 50, 59, 205, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5f503f17-5ca7-4a17-b131-6330c7fd52eb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 3, 11, 50, 59, 207, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("6628cf3a-8a13-4c45-b23e-cc171e5868e3"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 205, 34, 221, 229, 202, 180, 97, 68, 133, 45, 147, 111, 198, 46, 161, 173, 118, 129, 10, 108, 187, 178, 78, 17, 242, 66, 251, 70, 32, 250, 221, 158, 64, 55, 237, 113, 154, 45, 236, 222, 91, 154, 21, 86, 88, 42, 255, 205, 228, 174, 229, 46, 97, 3, 206, 197, 171, 87, 80, 165, 198, 87, 195, 132 }, new byte[] { 254, 36, 154, 158, 124, 45, 135, 172, 114, 98, 164, 106, 146, 223, 92, 43, 47, 190, 85, 4, 87, 159, 96, 214, 14, 156, 61, 235, 88, 220, 27, 71, 18, 107, 187, 65, 196, 1, 55, 189, 143, 216, 61, 128, 102, 70, 206, 245, 226, 134, 106, 233, 226, 52, 82, 95, 134, 177, 2, 103, 23, 176, 190, 191, 149, 213, 212, 64, 218, 139, 207, 38, 95, 233, 251, 132, 225, 139, 251, 71, 48, 36, 152, 101, 28, 234, 84, 78, 184, 59, 111, 219, 176, 222, 251, 100, 116, 243, 88, 16, 203, 197, 162, 106, 162, 114, 214, 159, 6, 145, 130, 120, 203, 62, 111, 20, 166, 181, 31, 129, 12, 194, 28, 74, 239, 117, 64, 161 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("e17b5150-3832-4b3c-bf0a-d827cb508463"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("6628cf3a-8a13-4c45-b23e-cc171e5868e3") });
        }
    }
}
