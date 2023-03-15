using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class CreateNewAdmin2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "018a708c-0d43-4961-9b52-f89c74eb0c34", new DateTime(2023, 3, 15, 13, 49, 10, 279, DateTimeKind.Local).AddTicks(6516), "AQAAAAEAACcQAAAAECmb+TLmedOr1N/f0LjbNXUvWXHVkHsXcWfz1bZ5jJQsJ5CGuslPrElWwkR46oZUfQ==", "3aecd1b2-8291-4ba7-9de0-4b53e36a70c4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09560d21-a99a-4c1d-8139-34c123776c53", new DateTime(2023, 3, 15, 13, 47, 14, 870, DateTimeKind.Local).AddTicks(9016), null, "bc1a81a8-d0cb-41ee-bd65-81749a202e2a" });
        }
    }
}
