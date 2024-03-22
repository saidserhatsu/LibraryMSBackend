using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors");

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("2cd4c05c-bdd2-406c-963d-ee1420662937"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("15348339-6814-4b86-959b-226dd82afdc5"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                columns: new[] { "BookId", "AuthorId" });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 114, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Admin", null },
                    { 115, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Read", null },
                    { 116, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Write", null },
                    { 117, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Create", null },
                    { 118, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Update", null },
                    { 119, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Locations.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("efe6899c-3a77-4c3d-a1b4-fd7a9a613d89"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 221, 52, 36, 73, 123, 223, 81, 85, 57, 198, 157, 52, 48, 249, 12, 140, 122, 237, 254, 142, 13, 201, 91, 112, 19, 148, 44, 104, 189, 66, 57, 134, 8, 139, 102, 150, 153, 65, 35, 34, 133, 254, 106, 242, 227, 140, 77, 2, 129, 86, 132, 226, 41, 30, 56, 126, 234, 17, 90, 23, 4, 250, 36, 186 }, new byte[] { 180, 104, 232, 69, 181, 182, 130, 236, 244, 195, 239, 94, 33, 19, 56, 53, 166, 80, 199, 124, 228, 98, 248, 232, 238, 167, 214, 72, 148, 176, 214, 232, 192, 252, 6, 106, 122, 49, 85, 172, 34, 236, 96, 40, 192, 60, 149, 167, 52, 217, 139, 250, 69, 222, 212, 206, 3, 41, 116, 197, 94, 104, 60, 198, 35, 172, 247, 11, 155, 120, 252, 194, 119, 252, 150, 82, 90, 198, 196, 209, 226, 157, 192, 206, 245, 159, 137, 167, 50, 161, 231, 18, 199, 129, 75, 135, 138, 205, 228, 152, 107, 82, 29, 90, 191, 97, 192, 123, 1, 80, 69, 230, 161, 197, 227, 107, 149, 173, 150, 224, 210, 20, 37, 116, 193, 200, 51, 38 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("4dbcd54b-7f1e-4522-8cc5-36da597b5bdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("efe6899c-3a77-4c3d-a1b4-fd7a9a613d89") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("4dbcd54b-7f1e-4522-8cc5-36da597b5bdc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("efe6899c-3a77-4c3d-a1b4-fd7a9a613d89"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthors",
                table: "BookAuthors",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("15348339-6814-4b86-959b-226dd82afdc5"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 240, 234, 59, 61, 15, 16, 237, 127, 246, 227, 241, 79, 42, 121, 38, 248, 169, 199, 143, 220, 167, 149, 201, 40, 246, 3, 238, 11, 15, 125, 17, 229, 134, 118, 193, 72, 40, 42, 46, 168, 195, 236, 39, 166, 8, 5, 46, 75, 87, 129, 148, 46, 233, 61, 24, 138, 31, 115, 101, 52, 198, 148, 112, 179 }, new byte[] { 226, 151, 129, 122, 251, 1, 47, 232, 169, 178, 60, 75, 115, 22, 155, 97, 163, 42, 14, 161, 40, 60, 224, 12, 217, 42, 220, 132, 66, 216, 153, 27, 16, 189, 95, 106, 254, 250, 32, 156, 211, 210, 161, 155, 159, 7, 126, 65, 13, 45, 10, 94, 224, 129, 222, 206, 74, 49, 150, 198, 26, 158, 244, 39, 169, 122, 194, 45, 110, 24, 58, 117, 120, 120, 57, 84, 213, 85, 25, 166, 181, 107, 134, 220, 195, 1, 60, 162, 85, 85, 127, 110, 6, 51, 52, 118, 61, 36, 233, 139, 246, 3, 90, 180, 206, 56, 118, 32, 61, 4, 17, 114, 205, 127, 232, 162, 135, 130, 178, 46, 22, 56, 219, 36, 38, 8, 111, 248 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("2cd4c05c-bdd2-406c-963d-ee1420662937"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("15348339-6814-4b86-959b-226dd82afdc5") });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");
        }
    }
}
