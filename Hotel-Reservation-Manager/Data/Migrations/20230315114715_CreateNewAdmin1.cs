using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class CreateNewAdmin1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09560d21-a99a-4c1d-8139-34c123776c53", new DateTime(2023, 3, 15, 13, 47, 14, 870, DateTimeKind.Local).AddTicks(9016), null, "bc1a81a8-d0cb-41ee-bd65-81749a202e2a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b479cedf-7636-48bc-9cd2-bb54c09ceb52", new DateTime(2023, 3, 15, 13, 42, 34, 548, DateTimeKind.Local).AddTicks(9620), "AQAAAAEAACcQAAAAEHK3vt4mrI5Cru6V/b2NIdhskgO6lHn9VYRUacvL3yXGwJHDlpzMoYcsjXqWvOTwSg==", "4ed75d01-2aa6-468d-894a-81ccb5f15a61" });
        }
    }
}
