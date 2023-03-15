using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class RemovePasswordColumnFromUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87fae9ea-d3ce-4a7b-9163-ef700a4e68a5", new DateTime(2023, 3, 15, 23, 11, 52, 421, DateTimeKind.Local).AddTicks(8804), "AQAAAAEAACcQAAAAEF+dWSOfagARZ5pCiKpHyunSZD9MeB18XfKL/M8FtmWCnzejLSlFMC5phUtlXXTyDg==", "c42c42c6-d85e-4a96-917e-7e9cc8a71e68" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "Password", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b281c5d-e2b8-4c96-9927-8b8b582f6e73", new DateTime(2023, 3, 15, 22, 5, 18, 163, DateTimeKind.Local).AddTicks(3435), "Password", "AQAAAAEAACcQAAAAEIojNyl/IwhKkIqvT5zZvW+qb5UtLQze+VoQi0sMvWbq/cAKGz5tV/M4YCBkq57ujA==", "45dfef0f-497b-4a55-9553-06d24aabbe54" });
        }
    }
}
