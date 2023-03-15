using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class ChangeEGNpropToTypeStringAndSeedAdmin1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a908c8b-09c3-4ab4-a69a-e4fd7e69f68f", new DateTime(2023, 3, 15, 10, 32, 44, 900, DateTimeKind.Local).AddTicks(2366), "Pa$$w0rd", null, "c0335df7-e3ab-4589-ba3a-3052040b62dd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b079006-67b2-492a-b464-a2377ce33569", new DateTime(2023, 3, 15, 10, 30, 55, 206, DateTimeKind.Local).AddTicks(9089), null, "Pa$$w0rd", "1ac2870d-289d-4651-bef0-5c0b3d08ef62" });
        }
    }
}
