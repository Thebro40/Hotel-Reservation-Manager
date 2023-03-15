using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class ChangeEGNpropToTypeStringAndSeedAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EGN",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "7b079006-67b2-492a-b464-a2377ce33569", "12121", "admin@abv.bg", false, null, "ss", new DateTime(2023, 3, 15, 10, 30, 55, 206, DateTimeKind.Local).AddTicks(9089), true, "s2s", false, null, "vv", null, "Admin", null, "Pa$$w0rd", "1111111111", false, "1ac2870d-289d-4651-bef0-5c0b3d08ef62", false, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.AlterColumn<int>(
                name: "EGN",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
