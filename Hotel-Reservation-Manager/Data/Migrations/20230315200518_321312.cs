using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class _321312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b281c5d-e2b8-4c96-9927-8b8b582f6e73", new DateTime(2023, 3, 15, 22, 5, 18, 163, DateTimeKind.Local).AddTicks(3435), "Password", "AQAAAAEAACcQAAAAEIojNyl/IwhKkIqvT5zZvW+qb5UtLQze+VoQi0sMvWbq/cAKGz5tV/M4YCBkq57ujA==", "45dfef0f-497b-4a55-9553-06d24aabbe54" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4d6e927-be04-4162-99c4-73f7442abeed", new DateTime(2023, 3, 15, 19, 1, 28, 963, DateTimeKind.Local).AddTicks(1034), "Pa$$w0rd", "AQAAAAEAACcQAAAAELw5UFjIL7VylW3dGeD9uFVz5LJFqUB39u/8EjxEjnrY3ixlDZyLzfylM5+tSh+vSQ==", "17480d38-f802-4fb2-b70e-e643051a1fce" });
        }
    }
}
