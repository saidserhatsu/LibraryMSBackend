using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("6b5842e0-5f21-4bab-a7d9-8d61d4110987"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6131fb80-929d-4d4b-b233-6905cc95ea3b"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 612, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 612, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 612, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FirstName", "LastName", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"), new DateTime(2024, 3, 26, 0, 33, 26, 612, DateTimeKind.Utc).AddTicks(3684), null, "Burak", "Turna", null },
                    { new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"), new DateTime(2024, 3, 26, 0, 33, 26, 612, DateTimeKind.Utc).AddTicks(3682), null, "Orkun", "Uçar", null }
                });

            migrationBuilder.InsertData(
                table: "BookIssues",
                columns: new[] { "Id", "BookId", "CreatedDate", "DeletedDate", "LibraryStaffId", "MemberId", "ReturnDate", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0f5ab2b8-1e2a-4380-94c6-5ea6524c4a84"), new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"), new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(1762), null, new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"), new Guid("10f30ed6-aa0d-4cc5-8155-63e13cc50cd9"), new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(1761), null },
                    { new Guid("d36b9b6d-86bf-4dc0-b1d3-b6a1aadd0d11"), new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"), new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(1765), null, new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"), new Guid("10f30ed6-aa0d-4cc5-8155-63e13cc50cd9"), new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(1765), null }
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 613, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 613, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 613, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 613, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("10f30ed6-aa0d-4cc5-8155-63e13cc50cd9"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("2d7e8997-68c0-4a84-846f-ded3e8a3d6ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("3e754b13-3554-4f20-805f-29ba737d96cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("e8676014-fff7-4c43-8baa-ae40263b0069"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 616, DateTimeKind.Utc).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 617, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 617, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 26, 0, 33, 26, 617, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Language", "Name", "UpdatedDate" },
                values: new object[] { new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), new DateTime(2024, 3, 26, 0, 33, 26, 617, DateTimeKind.Utc).AddTicks(5612), null, "TR", "Timaş Yayınları", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("2eba4a05-1db8-4fca-bd35-7684c08dc53b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 228, 230, 170, 174, 77, 198, 150, 129, 222, 134, 173, 64, 66, 101, 137, 108, 181, 28, 162, 98, 24, 252, 225, 56, 87, 16, 54, 171, 37, 139, 95, 199, 152, 194, 208, 179, 240, 56, 47, 36, 110, 162, 131, 148, 251, 166, 163, 230, 217, 91, 208, 0, 133, 230, 134, 85, 126, 3, 48, 158, 212, 12, 62, 141 }, new byte[] { 9, 110, 199, 122, 221, 223, 231, 101, 248, 107, 195, 39, 193, 119, 49, 164, 42, 16, 166, 226, 190, 146, 117, 18, 148, 192, 235, 15, 115, 41, 134, 81, 55, 75, 109, 244, 129, 200, 74, 87, 69, 11, 23, 227, 106, 223, 227, 201, 90, 50, 105, 24, 248, 15, 128, 244, 25, 180, 131, 195, 107, 187, 68, 183, 58, 44, 59, 102, 71, 41, 240, 9, 225, 173, 96, 68, 187, 9, 183, 175, 249, 156, 159, 242, 60, 19, 219, 1, 116, 22, 22, 131, 43, 132, 0, 73, 251, 38, 240, 97, 207, 193, 78, 102, 125, 69, 9, 96, 66, 168, 242, 221, 98, 135, 85, 47, 108, 183, 227, 47, 39, 207, 229, 9, 253, 20, 242, 33 }, null });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookEdition", "BookTitle", "CategoryId", "CreatedDate", "DeletedDate", "ISBNCode", "LocationId", "PublisherId", "ReleaseDate", "Status", "UpdatedDate" },
                values: new object[] { new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"), 14, "Metal Fırtına", 3, new DateTime(2024, 3, 26, 0, 33, 26, 613, DateTimeKind.Utc).AddTicks(5140), null, "9473284657234", new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"), new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"), 2004, 1, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("949bf22c-2dc7-463f-a155-28fdbf25bca5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("2eba4a05-1db8-4fca-bd35-7684c08dc53b") });

            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId", "CreatedDate", "DeletedDate", "Id", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"), new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null },
                    { new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"), new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("00000000-0000-0000-0000-000000000000"), null }
                });

            migrationBuilder.InsertData(
                table: "BookIssues",
                columns: new[] { "Id", "BookId", "CreatedDate", "DeletedDate", "LibraryStaffId", "MemberId", "ReturnDate", "UpdatedDate" },
                values: new object[] { new Guid("e902bad2-62ea-4273-8e0b-9667e9ec0566"), new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"), new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(1757), null, new Guid("f9206bc5-cf90-4623-a942-598395cb431e"), new Guid("e8676014-fff7-4c43-8baa-ae40263b0069"), new DateTime(2024, 3, 26, 0, 33, 26, 614, DateTimeKind.Utc).AddTicks(1757), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"), new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa") });

            migrationBuilder.DeleteData(
                table: "BookAuthors",
                keyColumns: new[] { "AuthorId", "BookId" },
                keyValues: new object[] { new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"), new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa") });

            migrationBuilder.DeleteData(
                table: "BookIssues",
                keyColumn: "Id",
                keyValue: new Guid("0f5ab2b8-1e2a-4380-94c6-5ea6524c4a84"));

            migrationBuilder.DeleteData(
                table: "BookIssues",
                keyColumn: "Id",
                keyValue: new Guid("d36b9b6d-86bf-4dc0-b1d3-b6a1aadd0d11"));

            migrationBuilder.DeleteData(
                table: "BookIssues",
                keyColumn: "Id",
                keyValue: new Guid("e902bad2-62ea-4273-8e0b-9667e9ec0566"));

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("949bf22c-2dc7-463f-a155-28fdbf25bca5"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0a0a0651-d2f9-4c37-a91d-334d850c23db"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("bfcb46ec-fce6-4305-84fd-8453a0c032c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cbcaea85-df78-4fb5-9219-13bcc50dc1fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2eba4a05-1db8-4fca-bd35-7684c08dc53b"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9acb5f4c-966e-44a4-8ddb-9fe31fa0090e"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("24a402a9-46e6-42f7-9d18-27ed258b8418"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 584, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("999b5ec6-5d88-437c-a6a8-8f397772acd3"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 584, DateTimeKind.Utc).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f52bd761-cef2-4728-b3a3-b8e1aaa86710"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 584, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224b200d-a4cb-4ad0-8957-662dd965794c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 585, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("55349e9b-304e-4ede-b5d3-b82d2eb2fbc7"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 585, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c5fad3d-7630-4dc5-80f5-4647ceb50830"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 585, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c16ce715-40b7-4bf8-9b7e-f34e21b8e99c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 585, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 586, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 586, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 586, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 586, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("22027a43-0eb7-40d2-bca6-3184563c4813"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("5f1f04fb-c293-431d-bd8f-7b021416d048"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("7be672cf-558f-4513-98a3-cdf0b2a22d5c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "LibraryStaffs",
                keyColumn: "Id",
                keyValue: new Guid("f9206bc5-cf90-4623-a942-598395cb431e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("57cac248-2a17-43bf-a584-9d2e7e966457"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6347179f-64d6-4c1d-a3ec-62bc02147d73"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("66a89aa8-e8ad-4add-8ec8-df9d372e4833"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("6e3709bf-803e-42d6-818c-c82cf15be93b"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("10f30ed6-aa0d-4cc5-8155-63e13cc50cd9"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("2d7e8997-68c0-4a84-846f-ded3e8a3d6ab"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("3e754b13-3554-4f20-805f-29ba737d96cc"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("e8676014-fff7-4c43-8baa-ae40263b0069"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("65584687-00c3-4673-b2da-d7c287e12a7c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("96946aaa-597d-4b96-a270-02a46204ebf6"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("cbb7895d-a862-459c-9622-2a2f3f5be99e"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 24, 0, 13, 4, 587, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("6131fb80-929d-4d4b-b233-6905cc95ea3b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 164, 242, 248, 55, 238, 150, 57, 215, 205, 100, 166, 60, 64, 134, 8, 50, 148, 157, 170, 95, 14, 18, 144, 202, 153, 8, 67, 73, 86, 136, 204, 233, 172, 7, 238, 194, 249, 212, 68, 105, 163, 150, 164, 84, 91, 236, 57, 45, 6, 0, 160, 243, 72, 14, 7, 129, 122, 215, 15, 153, 41, 105, 115, 17 }, new byte[] { 211, 247, 102, 219, 182, 251, 118, 76, 214, 79, 77, 134, 146, 11, 207, 40, 17, 178, 238, 211, 66, 198, 95, 38, 111, 68, 144, 173, 123, 167, 212, 250, 162, 210, 234, 119, 86, 93, 97, 169, 208, 178, 13, 197, 43, 123, 214, 2, 174, 153, 190, 101, 93, 197, 8, 162, 225, 220, 109, 15, 229, 236, 126, 218, 191, 237, 242, 125, 45, 219, 163, 48, 185, 191, 2, 215, 131, 219, 73, 247, 16, 44, 177, 57, 46, 146, 75, 99, 206, 207, 149, 85, 24, 52, 207, 245, 38, 51, 173, 158, 185, 103, 146, 129, 80, 17, 179, 74, 17, 227, 203, 152, 225, 146, 19, 82, 215, 228, 249, 216, 193, 18, 199, 251, 119, 7, 116, 50 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("6b5842e0-5f21-4bab-a7d9-8d61d4110987"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("6131fb80-929d-4d4b-b233-6905cc95ea3b") });
        }
    }
}
