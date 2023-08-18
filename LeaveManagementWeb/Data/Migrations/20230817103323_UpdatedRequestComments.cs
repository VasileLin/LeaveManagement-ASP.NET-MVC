using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82",
                column: "ConcurrencyStamp",
                value: "b8f14c4d-49ac-4add-8e3c-001baa12d87c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92",
                column: "ConcurrencyStamp",
                value: "665f7bcc-fb2e-4577-a281-0a7a872ad590");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a856f4-0797-4d8d-9be6-c10d8d17a93d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "660f1d1d-381c-4f15-ba57-e276ceef443d", "AQAAAAEAACcQAAAAEJy61COcGkI0eM2dFGLLOXF80snOJofCoBUsxrn5GAnJVBH3xkb6gh1QzH9oHBngXg==", "033a1f6d-41f5-47b3-a3b6-8090b77bca9b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82",
                column: "ConcurrencyStamp",
                value: "5168b1cf-e825-47ca-adb6-57560dd9b5aa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92",
                column: "ConcurrencyStamp",
                value: "fd0a47ed-5a9d-4761-b545-eb4e47919056");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a856f4-0797-4d8d-9be6-c10d8d17a93d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3280cab8-5c8c-44a1-90f9-292ad0a49a0e", "AQAAAAEAACcQAAAAEENZKUTeypT9dKWlECH4ab8GXiczE90edDAtKTazbf7UpyosHkFkfy/44L+GHplPDQ==", "562621f8-8d8b-4147-a936-95293925d140" });
        }
    }
}
