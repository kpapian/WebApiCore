using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCore.Dal.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Type" },
                values: new object[] { 1, "user" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Type" },
                values: new object[] { 2, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "RoleId" },
                values: new object[,]
                {
                    { 1, "Anna", 1 },
                    { 3, "Ira", 1 },
                    { 4, "Oleg", 1 },
                    { 5, "Karina", 1 },
                    { 2, "Petr", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserData",
                columns: new[] { "Id", "UserId", "UserText" },
                values: new object[,]
                {
                    { 1, 1, "My name is Anna. My role is user." },
                    { 3, 3, "My name is Ira. My role is user." },
                    { 4, 4, "My name is Oleg. My role is user." },
                    { 5, 5, "My name is Karina. My role is user." },
                    { 2, 2, "My name is Petr. My role is admin." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserData",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserData",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserData",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserData",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
