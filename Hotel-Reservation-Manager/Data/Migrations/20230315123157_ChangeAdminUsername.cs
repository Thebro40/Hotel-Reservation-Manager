using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class ChangeAdminUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "36801da3-c6b3-4388-8459-0864d2501973", new DateTime(2023, 3, 15, 14, 31, 56, 803, DateTimeKind.Local).AddTicks(3221), "ADMIN@ABV.BG", "AQAAAAEAACcQAAAAEDLWvsF8itzRgprynYY18xAxvG/rJjH2VvxQQ7+x0wPXaeNtbG9wHIczJGTarxyupA==", "ef89edde-1ebe-4981-9c7a-4e9b9f7f0fea", "admin@abv.bg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "150d96cb-4da7-4e00-8961-3f9946333829", new DateTime(2023, 3, 15, 14, 30, 22, 673, DateTimeKind.Local).AddTicks(7229), "ADMIN", "AQAAAAEAACcQAAAAEM/R5tAzBpjwJOwYKHCBgxvBZI4eRugN4s5+NfBmXkYJUQMINIG49jDy1C00EbLQRw==", "b252c4a9-8879-4f1a-8349-9920cbf327c7", "admin" });
        }
    }
}
