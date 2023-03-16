using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class SeedAdministrator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49ae6324-b56e-4ac2-a884-a2857447d289", new DateTime(2023, 3, 16, 17, 14, 52, 609, DateTimeKind.Local).AddTicks(197), "AQAAAAEAACcQAAAAECEJlpwPFR+QQSDCw/yBxs2EQB/B1LOBnP3kvsRh+Iyw/iMzbN1tfxBQcZKzMTfF3Q==", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2abaefd8-040a-4618-adc3-6e2b01754b07", new DateTime(2023, 3, 16, 17, 12, 57, 594, DateTimeKind.Local).AddTicks(1449), "AQAAAAEAACcQAAAAEINOh0RF+WrMDJJEmHlEhyJ58lS3SxKg9p0IeLD3kF3X8fJ3Y26MdYFrVZofe12ouA==", null });
        }
    }
}
