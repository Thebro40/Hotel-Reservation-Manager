using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class CreateNewAdmin3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", 0, "a7494988-8a40-46f3-aec1-f3d2c227b8a5", "12121", "admin@abv.bg", true, null, "ss", new DateTime(2023, 3, 15, 13, 49, 56, 596, DateTimeKind.Local).AddTicks(9305), true, "s2s", false, null, "vv", "ADMIN@ABV.BG", "Admin", "Pa$$w0rd", "AQAAAAEAACcQAAAAENH+ETZYE/XS6MDM2v7KKHiX3LA4oA9f+UKRsI5ajbpjScsE9rXhGRFb6xk/H0gh0Q==", "1111111111", true, "a37eb242-060b-4433-9d70-4614c3397c76", false, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "018a708c-0d43-4961-9b52-f89c74eb0c34", "12121", "admin@abv.bg", true, null, "ss", new DateTime(2023, 3, 15, 13, 49, 10, 279, DateTimeKind.Local).AddTicks(6516), true, "s2s", false, null, "vv", "ADMIN@ABV.BG", "Admin", "Pa$$w0rd", "AQAAAAEAACcQAAAAECmb+TLmedOr1N/f0LjbNXUvWXHVkHsXcWfz1bZ5jJQsJ5CGuslPrElWwkR46oZUfQ==", "1111111111", true, "3aecd1b2-8291-4ba7-9de0-4b53e36a70c4", false, "Admin" });
        }
    }
}
