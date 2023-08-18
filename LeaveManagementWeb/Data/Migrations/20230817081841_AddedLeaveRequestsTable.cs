using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedLeaveRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    LeaveRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
