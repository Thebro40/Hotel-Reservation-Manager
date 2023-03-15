using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class CreateNewAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b479cedf-7636-48bc-9cd2-bb54c09ceb52", new DateTime(2023, 3, 15, 13, 42, 34, 548, DateTimeKind.Local).AddTicks(9620), "AQAAAAEAACcQAAAAEHK3vt4mrI5Cru6V/b2NIdhskgO6lHn9VYRUacvL3yXGwJHDlpzMoYcsjXqWvOTwSg==", "4ed75d01-2aa6-468d-894a-81ccb5f15a61" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "988db3fc-c1f8-4f62-aa60-8ec6c8d4b1ff", new DateTime(2023, 3, 15, 13, 39, 20, 48, DateTimeKind.Local).AddTicks(2080), "AQAAAAEAACcQAAAAEL/gWogu8sgr6F/L3FPYnfnLIRtqHP3m96adNXqI1MrYIrMlc0PTw7JA1GTbT1Aghg==", "3158df5f-6924-4f40-a259-a7da08e17bd7" });
        }
    }
}
