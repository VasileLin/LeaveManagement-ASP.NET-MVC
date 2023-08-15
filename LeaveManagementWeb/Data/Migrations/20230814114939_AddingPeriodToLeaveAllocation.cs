using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddingPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4ca2532-6e74-49fc-8dc8-3c3b11f26b82",
                column: "ConcurrencyStamp",
                value: "e1d8a872-b2bf-4fe8-8cad-59334139358e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ba8547-8e71-41bc-8ff9-1c3b12f15e92",
                column: "ConcurrencyStamp",
                value: "d3067abf-7996-4a31-8dfd-75f53670e4ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a856f4-0797-4d8d-9be6-c10d8d17a93d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70722a32-0bb8-466a-bfce-9813d7ad507e", "AQAAAAEAACcQAAAAEFKx0CaXd7FmDIgvGerZpzOBAHYcw6CiL2Bwenc6miSH7HY5+HzdOEvrAKk8Jlsdmw==", "1bd9059f-8f06-4939-aa31-4fc4625d7c52" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72a856f4-0797-4d8d-9be6-c10d8d17a93d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3d96a06-f90f-4845-92ef-84826274481c", "AQAAAAEAACcQAAAAELMiSnhZaxbvXa4tn68ixt+RCyrkUUNV5/nm8UqL/GF5mcaXg78JF8QZla7hwini4A==", "3606016c-b209-46ac-a1b4-6af28bd612dd" });
        }
    }
}
