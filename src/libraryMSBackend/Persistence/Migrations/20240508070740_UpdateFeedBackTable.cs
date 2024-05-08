using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFeedBackTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("16fab5bf-6832-402b-b09c-39db4b2202bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("188f4036-06ca-47fe-9663-a04a7eb4c881"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "FeedBacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "FeedBacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "FeedBacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "FeedBacks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3705));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3723));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3716));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 594, DateTimeKind.Utc).AddTicks(3717));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6631));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6639));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6622));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 595, DateTimeKind.Utc).AddTicks(6643));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 596, DateTimeKind.Local).AddTicks(8863));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8785));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8802));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8815));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8818));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 597, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 7, 39, 598, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 600, DateTimeKind.Utc).AddTicks(726));

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

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 330, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Admin", null },
                    { 331, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Read", null },
                    { 332, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Write", null },
                    { 333, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Create", null },
                    { 334, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Update", null },
                    { 335, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "FeedBacks.Delete", null }
                });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3997));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 7, 39, 603, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("a904ee20-7021-495b-af88-579fa4d7d533"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 81, 18, 44, 254, 108, 75, 249, 252, 211, 206, 121, 195, 60, 209, 114, 226, 162, 165, 64, 214, 68, 130, 106, 28, 23, 130, 185, 130, 29, 140, 188, 237, 146, 178, 224, 244, 1, 220, 112, 198, 60, 58, 145, 211, 124, 199, 236, 86, 194, 87, 170, 122, 201, 237, 51, 170, 250, 1, 96, 124, 198, 125, 15, 146 }, new byte[] { 149, 13, 192, 166, 253, 238, 131, 216, 221, 229, 39, 31, 213, 108, 126, 177, 9, 37, 112, 51, 149, 200, 31, 19, 153, 33, 101, 95, 126, 254, 74, 147, 30, 162, 148, 28, 119, 212, 200, 55, 44, 31, 125, 21, 27, 202, 199, 79, 42, 24, 19, 215, 212, 163, 1, 90, 45, 111, 212, 126, 253, 202, 41, 165, 136, 25, 195, 156, 54, 146, 67, 125, 213, 203, 154, 192, 229, 249, 36, 107, 23, 164, 151, 187, 214, 216, 190, 163, 245, 0, 107, 190, 236, 195, 235, 255, 151, 209, 67, 231, 165, 215, 120, 8, 116, 250, 36, 59, 244, 228, 5, 242, 220, 51, 184, 65, 38, 227, 74, 165, 147, 240, 140, 195, 17, 170, 6, 71 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("3a1e15bb-15c3-4c40-b5c5-91d370d653a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("a904ee20-7021-495b-af88-579fa4d7d533") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("3a1e15bb-15c3-4c40-b5c5-91d370d653a2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a904ee20-7021-495b-af88-579fa4d7d533"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "FeedBacks");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "FeedBacks");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "FeedBacks");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "FeedBacks");

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(752));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(768));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("b5517ee6-ca04-4e72-96cf-a1f9d4a9954e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(760));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 740, DateTimeKind.Utc).AddTicks(762));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1298));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1301));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81e99a97-2bfd-4754-9637-978b162bd04e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1284));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 741, DateTimeKind.Utc).AddTicks(1305));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("35c235e3-95c5-4fd4-b0a1-93a730d9f839"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("398c79ce-2501-475e-b86f-0959b89e73ad"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("429824df-e22f-4ca1-b8de-1eaa320a68b7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4d0896cc-92ba-4f69-9837-62bf1e2e1b8d"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("4dbc633a-ab1b-4a55-b159-d3dd1249b6cd"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("834183d5-be5d-4701-8b65-9593f2839066"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("b5cad88a-dbbc-441c-a095-e9957d4fa286"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("cf491419-601d-4bde-9b46-0e610589a4d7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("e2ddf880-692a-4dc6-9919-4ddf57f01daf"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Catalogs",
                keyColumn: "Id",
                keyValue: new Guid("fd64bb44-8a22-46b5-a573-bcd9629d3fd1"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 742, DateTimeKind.Local).AddTicks(4056));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4140));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4157));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4170));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4173));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 743, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("2583810b-e2bf-41de-8faa-a88409df1849"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("4fa38d56-3575-44ca-ab49-fa734492e642"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("8803a79b-fb10-4bc0-a726-45491e8a541b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("e41fa03a-66ec-4231-9f9e-a289b8eec252"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "EBooks",
                keyColumn: "Id",
                keyValue: new Guid("f67e3283-e7f0-4ae9-8cb4-f7c237995669"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 10, 6, 1, 743, DateTimeKind.Local).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("13b7a063-80a1-4d22-bb03-0f883ef12e85"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("173c9483-082d-46e9-9bf3-6ee28f906508"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("59cd3e7e-e103-4eb3-9f04-6ad7a8407952"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80da673f-f14f-4ce2-9d9b-bada572ddf91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("814b3b30-e185-4181-964a-bfa2c162c9ac"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9466485b-9c11-433a-b384-7d6382333193"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9985ceeb-f15a-4f6b-8814-67b5f6f50bea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("c4fa4874-380f-494c-af36-423ccdfd2dea"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d1448ef9-5746-4a25-99b8-eaa1accc7ebc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ddacb573-f83a-4fdc-ba85-c647378da1bc"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e6f25590-b816-405f-815f-dd543bcd9bbb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 746, DateTimeKind.Utc).AddTicks(310));

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

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("124589ea-4803-490c-9c86-dd68e59b8825"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3cdebc03-bad8-4657-8ecf-f196b55bf223"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3f51e2c8-dd62-49be-a384-6af21e614507"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("46266a6c-ed71-4b7a-8367-340f2f3f8e42"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("53458011-9e2b-4cf9-9647-3a7364c4e8a2"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5bce2c0e-36b7-4098-945e-700fc0a1d0c5"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("5d604071-905c-4da5-9277-a8c0d17a717b"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(835));

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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6b3d2f37-ca03-40b9-8fe6-c890bfdd9cf3"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("6bb7922f-079e-41e9-bbd2-1be557f30957"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("888f4ec1-6d74-4e7e-ad0e-e75d5cfaad86"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8ecae9d5-c9c1-4362-96a2-db0231083372"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b8fea0cc-e29a-4028-8b1b-08126eedcecb"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("ceaac2a8-b341-44cd-928c-d472e38a7f20"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("d72f299e-e695-49c5-94fb-79e382710b91"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("e875fb59-639f-4cd8-b2d3-3e222adb9211"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 8, 7, 6, 1, 750, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("188f4036-06ca-47fe-9663-a04a7eb4c881"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 210, 173, 98, 219, 188, 23, 123, 52, 155, 177, 205, 135, 61, 56, 115, 150, 145, 98, 205, 104, 180, 104, 165, 131, 220, 68, 144, 118, 214, 213, 234, 198, 61, 8, 24, 220, 52, 205, 151, 111, 230, 200, 95, 71, 184, 230, 153, 153, 230, 123, 252, 123, 35, 218, 116, 146, 108, 122, 107, 215, 82, 76, 6, 81 }, new byte[] { 116, 74, 0, 159, 17, 45, 7, 142, 59, 77, 223, 183, 50, 101, 244, 105, 170, 82, 84, 48, 8, 191, 125, 86, 241, 52, 186, 247, 142, 157, 251, 39, 10, 254, 108, 197, 244, 240, 144, 81, 94, 147, 228, 72, 177, 210, 74, 174, 40, 251, 231, 155, 165, 122, 193, 91, 214, 173, 113, 190, 154, 84, 113, 109, 84, 226, 4, 254, 97, 49, 237, 237, 101, 160, 26, 64, 132, 222, 140, 116, 98, 210, 86, 235, 126, 94, 34, 207, 1, 208, 41, 225, 209, 69, 118, 17, 219, 198, 141, 50, 180, 58, 1, 225, 86, 182, 61, 248, 147, 238, 207, 186, 56, 166, 82, 178, 82, 46, 96, 8, 203, 99, 187, 169, 255, 236, 188, 199 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("16fab5bf-6832-402b-b09c-39db4b2202bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("188f4036-06ca-47fe-9663-a04a7eb4c881") });
        }
    }
}
