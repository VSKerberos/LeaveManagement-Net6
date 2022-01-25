using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dbccfa2-5bf9-4eaf-866f-e82ec8893a36", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEI6H7UrcTr9n7dfxhPPLeytG3N5QMJ/F9rd1MDQ+K6u6P9LIK8RJqS7dKzXFApdbwg==", "1ece5ae8-7dc0-499b-9d7b-785c89236bde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5c8bf34-cf04-4742-81c1-46501dfcdb8f", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEApj544w8RR/RocJhZGNertKh1MtrPlGOa8FG5ZNifuYAp7MAFxcHlgfZYyGTfbbqw==", "61e6cd63-3100-4e41-8bf8-6efd19160e5e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab83a6e-f9aa-4448-bcaf-1add431erbbf",
                column: "ConcurrencyStamp",
                value: "5a83d59a-d973-4f41-b151-97f14dc5f645");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "5ec48f20-3633-4fdb-aad8-ff96f3b203ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74fc0e79-cdea-4d54-ac02-c0eaf72ecf32", false, null, "AQAAAAEAACcQAAAAEApCBowQAu8m0NGf5Fygr/B6EM4vZ2MlbYlVLqGSJOlKBHbOarhASEo1d1/OnmmKSg==", "26e031d2-c5d9-43d1-bfca-76231d9b5dd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ede6e5a5-216f-425e-9cbb-fb14fea1d52a", false, null, "AQAAAAEAACcQAAAAEFwIT71YuIoLNsmHMMBdo75ISWFtuSgBnQHyaHEmcOgk8xxS8zayVcRrqqjQUweB1g==", "37709884-5876-45f2-b5d2-1695727459f3" });
        }
    }
}
