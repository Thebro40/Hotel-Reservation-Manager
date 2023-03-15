using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class SeedNewAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "HireDate", "NormalizedEmail", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "988db3fc-c1f8-4f62-aa60-8ec6c8d4b1ff", true, new DateTime(2023, 3, 15, 13, 39, 20, 48, DateTimeKind.Local).AddTicks(2080), "ADMIN@ABV.BG", "AQAAAAEAACcQAAAAEL/gWogu8sgr6F/L3FPYnfnLIRtqHP3m96adNXqI1MrYIrMlc0PTw7JA1GTbT1Aghg==", true, "3158df5f-6924-4f40-a259-a7da08e17bd7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "HireDate", "NormalizedEmail", "PasswordHash", "PhoneNumberConfirmed", "SecurityStamp" },
                values: new object[] { "9a908c8b-09c3-4ab4-a69a-e4fd7e69f68f", false, new DateTime(2023, 3, 15, 10, 32, 44, 900, DateTimeKind.Local).AddTicks(2366), null, null, false, "c0335df7-e3ab-4589-ba3a-3052040b62dd" });
        }
    }
}
