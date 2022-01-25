using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernamesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "ConcurrencyStamp",
                value: "6f154a11-c80b-4613-8c5b-20198959e480");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2273d17d-6ded-40fe-8eda-634aefd559ac", "AQAAAAEAACcQAAAAEM0hl7YckKwsJLpIFrOSogTfHgnZ4DxoyAhcZcz0jsxLVpvAq2q9xBgfHpZzZAqXJQ==", "e1fd8444-2072-4ad5-aa20-990867c58a58", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4a04d908-2287-4b4a-b039-b49567fa3785", "AQAAAAEAACcQAAAAEP55oGOD2WdFPb/cxjdX5JP6EgUoLAA279gRgPdFYJJKMy7BKDx+zeTYaoEDyOZdFw==", "f100e208-a417-4f79-9328-dbd56052b634", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab83a6e-f9aa-4448-bcaf-1add431erbbf",
                column: "ConcurrencyStamp",
                value: "c6467114-7c66-4979-ba62-354b6cc7181f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a9490e59-cebe-416f-8da8-2f9f6aa4b554");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1dbccfa2-5bf9-4eaf-866f-e82ec8893a36", "AQAAAAEAACcQAAAAEI6H7UrcTr9n7dfxhPPLeytG3N5QMJ/F9rd1MDQ+K6u6P9LIK8RJqS7dKzXFApdbwg==", "1ece5ae8-7dc0-499b-9d7b-785c89236bde", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d5c8bf34-cf04-4742-81c1-46501dfcdb8f", "AQAAAAEAACcQAAAAEApj544w8RR/RocJhZGNertKh1MtrPlGOa8FG5ZNifuYAp7MAFxcHlgfZYyGTfbbqw==", "61e6cd63-3100-4e41-8bf8-6efd19160e5e", null });
        }
    }
}
