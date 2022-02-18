using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                        name: "FK_LeaveRequests_LeaveType_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab83a6e-f9aa-4448-bcaf-1add431erbbf",
                column: "ConcurrencyStamp",
                value: "accade2b-2f82-4b7f-9735-57a5176633e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "446e3f81-8aa2-47ed-93de-4f46678bb3f7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00a252dc-df46-4231-88c5-9c2af30d95f9", "AQAAAAEAACcQAAAAENrjFtmp8xbg7r451F7LJeKzwYP2Y9Pd4ghOvORxwnIpbCATgWk5A4Xm26RHWWPvYw==", "17bfcaf0-6456-4670-8bb6-a571fb5c2b01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fd17149-df32-40c1-a940-4f63f80ff752", "AQAAAAEAACcQAAAAEMbSd0PEtf0UJqWmYeGry5gStB3an3SO+4udUj4wOq3hgl1cLh+4D44RVFXz+PpN/g==", "41e0d7d6-241b-4ec7-9390-bef628571845" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab83a6e-f9aa-4448-bcaf-1add431erbbf",
                column: "ConcurrencyStamp",
                value: "ea1f1587-7f82-4eef-a034-0e3f8afe22b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "50bb7b86-5c16-44cb-a386-e4eef4dca88a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bf6aa44-974f-41ac-93a1-0e00b5c645d6", "AQAAAAEAACcQAAAAEKhL3lr2zJlguuRqLVhNT2jPfQ3pPRCotkapP8GJi/Ihbf3fMOoU8w+ZetKD/UIGeQ==", "448cbac9-85ab-4114-92a0-1645e008f3ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2adcfc0-983f-489e-a978-a216ad78bfdb", "AQAAAAEAACcQAAAAEDRzA09FJ/Xk0kVSfmkYh9WkKSkwnAHQ3Go4NypcXcZQmPawTk5HAT6Mcep5xEO1dg==", "f5814419-685c-4a94-8727-4286b38e7cb1" });
        }
    }
}
