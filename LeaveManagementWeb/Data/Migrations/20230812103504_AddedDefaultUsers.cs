using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c42a9beb-e5a1-4cd7-a412-04cff5795575", "AQAAAAEAACcQAAAAEOIvUdsRWnTzWRtmaOa2MOImGqmmywX75cYixJercNh6M6bQP6IyiC+A9grBPmS7QA==", "d583468e-e984-4035-af51-03945f95ff9b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82",
                column: "ConcurrencyStamp",
                value: "9028d70b-1959-41cf-8638-e3d4c98e1346");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92",
                column: "ConcurrencyStamp",
                value: "bf65f864-4b14-4c57-97d8-86427af7f167");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4ba8547-8e89-49bc-8ff9-1c3b52f15b92",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50c3bf36-323b-46ed-9983-eb7d633c9156", "AQAAAAEAACcQAAAAEAjRKyc4050cOtifbUrYGsd3wgIc01hWcjAWglTBQxDeLZ0tdr9/OVLVowZvTS029w==", "70089578-09d8-4855-9413-9fffa8dcbe29" });
        }
    }
}
