using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f4fa2536-6e79-49bc-8dc9-1c3b52f25b92", "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4fa2536-6e79-49bc-8dc9-1c3b52f25b92");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92",
                column: "ConcurrencyStamp",
                value: "96ae0196-ecee-46dc-9c8b-d23dbc96f862");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82", "fd996e98-6161-4269-b47f-97cb95eaa364", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf358cec-d9b3-4ce7-ad3f-fae15ad2fc37", true, "VASILE.LINGA1@GMAIL.COM", "AQAAAAEAACcQAAAAEKhclsMaIggcglM/UKYCtnleWar3wDcImFqsgbicRUqzlxJTfGEkCy0pG8LfrZf+Kw==", "272bbea4-939c-4cad-8478-1ce9d59e8f0d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82", "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82", "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92",
                column: "ConcurrencyStamp",
                value: "15d7adae-15f4-4743-9af2-b2e292dbed94");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4fa2536-6e79-49bc-8dc9-1c3b52f25b92", "6d657d33-fdff-4979-9d18-453be17aebb5", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd7035a0-35d3-410d-be52-624bdad7dcaf", false, null, "AQAAAAEAACcQAAAAEJHIII0P091RtSyKjod+kTooRXl9VXBksMJD8GiY32q16KV5xOeNHv6LlhAH+M9UdQ==", "f3bb1680-33da-4d96-9c76-753ead52356c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f4fa2536-6e79-49bc-8dc9-1c3b52f25b92", "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92" });
        }
    }
}
