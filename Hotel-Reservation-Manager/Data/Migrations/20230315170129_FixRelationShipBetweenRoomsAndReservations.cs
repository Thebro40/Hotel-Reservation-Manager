using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class FixRelationShipBetweenRoomsAndReservations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4d6e927-be04-4162-99c4-73f7442abeed", new DateTime(2023, 3, 15, 19, 1, 28, 963, DateTimeKind.Local).AddTicks(1034), "AQAAAAEAACcQAAAAELw5UFjIL7VylW3dGeD9uFVz5LJFqUB39u/8EjxEjnrY3ixlDZyLzfylM5+tSh+vSQ==", "17480d38-f802-4fb2-b70e-e643051a1fce" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e7e2aa5-51ae-46ef-9893-8c3cecffa390", new DateTime(2023, 3, 15, 18, 58, 21, 370, DateTimeKind.Local).AddTicks(7113), "AQAAAAEAACcQAAAAECAh+koI/rgfSBkUS7Zu7QBGx6Nxo4sXHJR2ytbjXTJkyjf67BIIevTMpL/Gf/pKcw==", "993fd0a4-5781-4054-a215-1bb11acfe8a4" });
        }
    }
}
