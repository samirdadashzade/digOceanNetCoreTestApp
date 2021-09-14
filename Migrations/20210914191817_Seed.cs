using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Country", "FirstName", "LastName", "Mobile" },
                values: new object[] { 1, "DC", "USA", "Samir", "Dadash", 111 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Country", "FirstName", "LastName", "Mobile" },
                values: new object[] { 2, "DC", "USA", "Ilhame", "Dadash", 222 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Country", "FirstName", "LastName", "Mobile" },
                values: new object[] { 3, "DC", "USA", "Nunus", "Dadash", 333 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
