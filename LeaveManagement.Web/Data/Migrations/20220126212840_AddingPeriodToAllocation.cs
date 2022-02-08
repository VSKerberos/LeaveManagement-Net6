using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocationS",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "50bb7b86-5c16-44cb-a386-e4eef4dca88a", "ADMİNİSTRATOR" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocationS");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab83a6e-f9aa-4448-bcaf-1add431erbbf",
                column: "ConcurrencyStamp",
                value: "be61b6cc-c6ec-439c-bbf7-3789ba30f591");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "6f154a11-c80b-4613-8c5b-20198959e480", "Administrator" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2273d17d-6ded-40fe-8eda-634aefd559ac", "AQAAAAEAACcQAAAAEM0hl7YckKwsJLpIFrOSogTfHgnZ4DxoyAhcZcz0jsxLVpvAq2q9xBgfHpZzZAqXJQ==", "e1fd8444-2072-4ad5-aa20-990867c58a58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a04d908-2287-4b4a-b039-b49567fa3785", "AQAAAAEAACcQAAAAEP55oGOD2WdFPb/cxjdX5JP6EgUoLAA279gRgPdFYJJKMy7BKDx+zeTYaoEDyOZdFw==", "f100e208-a417-4f79-9328-dbd56052b634" });
        }
    }
}
