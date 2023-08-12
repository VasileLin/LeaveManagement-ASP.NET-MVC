using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92", "15d7adae-15f4-4743-9af2-b2e292dbed94", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4fa2536-6e79-49bc-8dc9-1c3b52f25b92", "6d657d33-fdff-4979-9d18-453be17aebb5", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92", 0, "cd7035a0-35d3-410d-be52-624bdad7dcaf", null, null, "vasile.linga1@gmail.com", false, "Linga", "Vasile", false, null, "VASILE.LINGA1@GMAIL.COM", null, "AQAAAAEAACcQAAAAEJHIII0P091RtSyKjod+kTooRXl9VXBksMJD8GiY32q16KV5xOeNHv6LlhAH+M9UdQ==", null, false, "f3bb1680-33da-4d96-9c76-753ead52356c", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f4fa2536-6e79-49bc-8dc9-1c3b52f25b92", "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4fa2536-6e79-49bc-8dc9-1c3b52f25b92", "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4fa2536-6e79-49bc-8dc9-1c3b52f25b92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92");
        }
    }
}
