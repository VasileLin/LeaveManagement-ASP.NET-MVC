using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultAdminAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82", "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82",
                column: "ConcurrencyStamp",
                value: "d9b76c1a-c838-4503-abd0-093eb52d409f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92",
                column: "ConcurrencyStamp",
                value: "2a61d8c0-0b78-4092-8a75-712dc69646e7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "72a856f4-0797-4d8d-9be6-c10d8d17a93d", 0, "c3d96a06-f90f-4845-92ef-84826274481c", null, null, "vasile.linga1@gmail.com", true, "Linga", "Vasile", false, null, "VASILE.LINGA1@GMAIL.COM", "VASILE.LINGA1@GMAIL.COM", "AQAAAAEAACcQAAAAELMiSnhZaxbvXa4tn68ixt+RCyrkUUNV5/nm8UqL/GF5mcaXg78JF8QZla7hwini4A==", null, false, "3606016c-b209-46ac-a1b4-6af28bd612dd", null, false, "vasile.linga1@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82", "72a856f4-0797-4d8d-9be6-c10d8d17a93d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82", "72a856f4-0797-4d8d-9be6-c10d8d17a93d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a856f4-0797-4d8d-9be6-c10d8d17a93d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82",
                column: "ConcurrencyStamp",
                value: "3559b5c2-7829-46f9-9105-c72608b0f11c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92",
                column: "ConcurrencyStamp",
                value: "65663185-29d8-4e54-8f1b-9ed1f31fad37");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92", 0, "c42a9beb-e5a1-4cd7-a412-04cff5795575", null, null, "vasile.linga1@gmail.com", true, "Linga", "Vasile", false, null, "VASILE.LINGA1@GMAIL.COM", "VASILE.LINGA1@GMAIL.COM", "AQAAAAEAACcQAAAAEOIvUdsRWnTzWRtmaOa2MOImGqmmywX75cYixJercNh6M6bQP6IyiC+A9grBPmS7QA==", null, false, "d583468e-e984-4035-af51-03945f95ff9b", null, false, "vasile.linga1@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82", "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92" });
        }
    }
}
