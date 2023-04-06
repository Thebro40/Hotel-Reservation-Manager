using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class CustomerHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0eebc067-bed8-41aa-8505-3e09dcbaace4", "f40d8b19-06cc-4554-b6cb-67414611c0df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2de9d5f0-1c53-4aaf-885a-e83c17ea4950", "f40d8b19-06cc-4554-b6cb-67414611c0df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7531416f-579f-4c1b-bc20-1a014f071f6d", "f40d8b19-06cc-4554-b6cb-67414611c0df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7cdcf7d4-0b82-4916-82e8-a669796ee3c2", "f40d8b19-06cc-4554-b6cb-67414611c0df" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "66f8c581-f6f0-406c-9af0-35e7d2567b09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d43f19f8-6f5d-4a29-a1fe-0505e250ac14", "f40d8b19-06cc-4554-b6cb-67414611c0df" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4a1cc43a-2e9e-4b10-95f8-2f53de9691f1");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8d0685ff-894c-42bf-8371-82b3e7a51344");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "98abd15c-5bcc-46f3-96b7-00fb9de86194");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9d76f617-5197-480e-a8b2-59bb73df934b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "f3e560ff-c5f0-4a98-9612-d5ff53f68fb9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66f8c581-f6f0-406c-9af0-35e7d2567b09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f40d8b19-06cc-4554-b6cb-67414611c0df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0eebc067-bed8-41aa-8505-3e09dcbaace4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de9d5f0-1c53-4aaf-885a-e83c17ea4950");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7531416f-579f-4c1b-bc20-1a014f071f6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cdcf7d4-0b82-4916-82e8-a669796ee3c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d43f19f8-6f5d-4a29-a1fe-0505e250ac14");

            migrationBuilder.CreateTable(
                name: "CustomerHistory",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    ResRoomNumber = table.Column<int>(nullable: false),
                    ResAccomDate = table.Column<DateTime>(nullable: false),
                    ResLeaveDate = table.Column<DateTime>(nullable: false),
                    ResPrice = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerHistory", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6abdd5f3-6410-4467-8871-0bc107d815ad", "aad78411-2ee6-49ad-820c-2967b3a00a57", "Admin", "ADMIN" },
                    { "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c", "c9ec4c4f-9739-4e28-bfae-b06adc557e74", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "4956a84a-4b78-44df-ac06-b7ac224c6d66", new DateTime(2023, 3, 25, 18, 54, 5, 497, DateTimeKind.Local).AddTicks(1085), "AQAAAAEAACcQAAAAEBhcEqT21UsWo6o/HJH+LiVSM0DIYgkJBP0q29ctwwi0O0ZtKybbFx778gVdkPBRbw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "ef11b75a-a620-42ad-8c0c-fe8f9ad3efc1", 0, "4b666c5d-81e2-4b42-bdb8-1f089a5f8b27", "user0@abv.bg", true, null, "Alex", new DateTime(2023, 3, 25, 18, 54, 5, 507, DateTimeKind.Local).AddTicks(8626), true, "Alexandrov", false, null, "Alex", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAECeDNe0dlWyEALdU/L5hNy+cSrvz5xyTf7uS6jWMG5KEh/KuHgl9yZWkDLZm71vhVA==", "002233", true, "", false, "007694", "user0@abv.bg" },
                    { "265cb529-1711-4793-82ee-0b91f4b8ca0e", 0, "9d954fad-8df8-409e-affb-3549bec90fcf", "user1@abv.bg", true, null, "John", new DateTime(2023, 3, 25, 18, 54, 5, 520, DateTimeKind.Local).AddTicks(1226), true, "Johnson", false, null, "John", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAENDiHMaPhoO1pXsO4iaoX0gLvjVRLwydALz+WHqygXBX2rwGf5/cJbPjgPBH1nBtMQ==", "007167", true, "", false, "000144", "user1@abv.bg" },
                    { "bf0a6dde-bf2e-479c-8b27-ea04737f75a7", 0, "504b90a7-19fe-4703-afd5-dd3d3b40b303", "user2@abv.bg", true, null, "Jane", new DateTime(2023, 3, 25, 18, 54, 5, 531, DateTimeKind.Local).AddTicks(254), true, "Alexandrov", false, null, "Jack", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEJj8UzXCz7cyef/VIUbi4WHnmjFqIzq67NCr1PhOLZilkCIFv4vS0GcHYtLlpkOUFQ==", "007915", true, "", false, "008019", "user2@abv.bg" },
                    { "a854cf6b-c539-4ddd-be7c-27103bfd329c", 0, "b7aa368b-8f05-42ed-911c-b74d453137dd", "user3@abv.bg", true, null, "Jack", new DateTime(2023, 3, 25, 18, 54, 5, 541, DateTimeKind.Local).AddTicks(3042), true, "Johnson", false, null, "John", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEATBkFymo85yUB8gZjocJ6vvK7osgvOJ34JB+HIg4rC6iiE36GjEHzGmCpcHTQzi1w==", "005416", true, "", false, "001936", "user3@abv.bg" },
                    { "28d34957-86d0-4c4d-9194-09fbad66557f", 0, "2cd36d7a-0763-4611-81ae-ae9ffff15f00", "user4@abv.bg", true, null, "Jack", new DateTime(2023, 3, 25, 18, 54, 5, 549, DateTimeKind.Local).AddTicks(8626), true, "Alexandrov", false, null, "John", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEEIFYyImT3dxmgTXox7z4yv6hZy9Myc0yfQ8zcooYzh9xnm3KdjkwfuSgoD0vkMCEg==", "000122", true, "", false, "009148", "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "0853a7ad-f924-4366-be9b-abe3e4fb24d0", "customer0@abv.bg", "Jack", true, "Johnson", "569783", null },
                    { "7bc8179c-ef22-41c2-8c29-7c62e7c054dc", "customer1@abv.bg", "John", true, "Johnson", "395746", null },
                    { "7abf3f8d-e8a4-4ac4-8bdc-89dc2ed5712d", "customer2@abv.bg", "John", false, "Johnson", "900105", null },
                    { "b37e3e6d-fcbb-44ac-837a-91b235254dde", "customer3@abv.bg", "Jack", true, "Alexandrov", "767105", null },
                    { "347d07c6-fe63-4912-9986-83c47d31db40", "customer4@abv.bg", "Jack", false, "Johnson", "935594", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "6abdd5f3-6410-4467-8871-0bc107d815ad" },
                    { "ef11b75a-a620-42ad-8c0c-fe8f9ad3efc1", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" },
                    { "265cb529-1711-4793-82ee-0b91f4b8ca0e", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" },
                    { "bf0a6dde-bf2e-479c-8b27-ea04737f75a7", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" },
                    { "a854cf6b-c539-4ddd-be7c-27103bfd329c", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" },
                    { "28d34957-86d0-4c4d-9194-09fbad66557f", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerHistory");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "265cb529-1711-4793-82ee-0b91f4b8ca0e", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "28d34957-86d0-4c4d-9194-09fbad66557f", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "6abdd5f3-6410-4467-8871-0bc107d815ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a854cf6b-c539-4ddd-be7c-27103bfd329c", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bf0a6dde-bf2e-479c-8b27-ea04737f75a7", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ef11b75a-a620-42ad-8c0c-fe8f9ad3efc1", "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "0853a7ad-f924-4366-be9b-abe3e4fb24d0");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "347d07c6-fe63-4912-9986-83c47d31db40");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7abf3f8d-e8a4-4ac4-8bdc-89dc2ed5712d");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7bc8179c-ef22-41c2-8c29-7c62e7c054dc");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "b37e3e6d-fcbb-44ac-837a-91b235254dde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6abdd5f3-6410-4467-8871-0bc107d815ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccc03e0c-a72c-49e8-98d8-beeb1a913b5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "265cb529-1711-4793-82ee-0b91f4b8ca0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28d34957-86d0-4c4d-9194-09fbad66557f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a854cf6b-c539-4ddd-be7c-27103bfd329c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf0a6dde-bf2e-479c-8b27-ea04737f75a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef11b75a-a620-42ad-8c0c-fe8f9ad3efc1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "66f8c581-f6f0-406c-9af0-35e7d2567b09", "04d4e941-0686-4e51-89de-003129cfe1a0", "Admin", "ADMIN" },
                    { "f40d8b19-06cc-4554-b6cb-67414611c0df", "88ae0370-cfdb-49ed-b1ae-d9a3aa9ad35f", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "b3140740-1bca-4f51-a5ea-833fcb5eccbc", new DateTime(2023, 3, 25, 18, 29, 41, 20, DateTimeKind.Local).AddTicks(6698), "AQAAAAEAACcQAAAAEM4wCwlze62EoJsrcJwiclaxktm8ROCm8aVgy+R6pxJ2Z4rDSdFD36leZ40LxwalUA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "2de9d5f0-1c53-4aaf-885a-e83c17ea4950", 0, "bb1f6f40-acf4-48e1-a22f-b2f389f9ced7", "user0@abv.bg", true, null, "Alex", new DateTime(2023, 3, 25, 18, 29, 41, 26, DateTimeKind.Local).AddTicks(6630), true, "Alexandrov", false, null, "Jane", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEIq7A4h2D44yR8KIV0yIHkyOznjjkb87+0+4B/Yb3MIbpVyKWligVmiewfJcMp3+QA==", "005783", true, "", false, "006695", "user0@abv.bg" },
                    { "0eebc067-bed8-41aa-8505-3e09dcbaace4", 0, "9a10f496-5501-400e-b6f0-350c9c9b8785", "user1@abv.bg", true, null, "Jane", new DateTime(2023, 3, 25, 18, 29, 41, 36, DateTimeKind.Local).AddTicks(483), true, "Alexandrov", false, null, "Alex", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEDFZE53NVDrcFoDXqdo95MDHplw0vOSXLQVSWwQjsFPTOLWjyyOTOxb2mxA37N0w6A==", "000315", true, "", false, "008982", "user1@abv.bg" },
                    { "7531416f-579f-4c1b-bc20-1a014f071f6d", 0, "260e9a22-0d47-48a2-9cd1-40c832b213d9", "user2@abv.bg", true, null, "Jane", new DateTime(2023, 3, 25, 18, 29, 41, 44, DateTimeKind.Local).AddTicks(9280), true, "Alexandrov", false, null, "John", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEMhTNaW2SEXQykkqdM7KrnX4oug1g1gQRMWNYV2dL4eEjek9Z6C1dXdAsJnyQxBoUg==", "002967", true, "", false, "005612", "user2@abv.bg" },
                    { "7cdcf7d4-0b82-4916-82e8-a669796ee3c2", 0, "f94044fe-4247-496c-b38d-e626ed7ba8eb", "user3@abv.bg", true, null, "Alex", new DateTime(2023, 3, 25, 18, 29, 41, 62, DateTimeKind.Local).AddTicks(3142), true, "Alexandrov", false, null, "John", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEDyM6nTVy5JMhfwjT6n9wEBalMm8FlBQydpdWJ3XaeL5RgpyWZiDZO6Co/M+M2do5Q==", "003009", true, "", false, "007130", "user3@abv.bg" },
                    { "d43f19f8-6f5d-4a29-a1fe-0505e250ac14", 0, "b41bd786-2b91-4e83-aafc-c9b1d16d4567", "user4@abv.bg", true, null, "Jack", new DateTime(2023, 3, 25, 18, 29, 41, 70, DateTimeKind.Local).AddTicks(5196), true, "Alexandrov", false, null, "John", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEEzTzkVnmupsibjpYstr63PaXp+5IJHO+fmjNLoJLzD9/HAm67vKXQw2achrQCTXXg==", "007354", true, "", false, "008862", "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "9d76f617-5197-480e-a8b2-59bb73df934b", "customer0@abv.bg", "Jane", false, "Johnson", "988418", null },
                    { "8d0685ff-894c-42bf-8371-82b3e7a51344", "customer1@abv.bg", "Jack", false, "Johnson", "953794", null },
                    { "98abd15c-5bcc-46f3-96b7-00fb9de86194", "customer2@abv.bg", "Jack", false, "Johnson", "447797", null },
                    { "4a1cc43a-2e9e-4b10-95f8-2f53de9691f1", "customer3@abv.bg", "John", true, "Johnson", "209110", null },
                    { "f3e560ff-c5f0-4a98-9612-d5ff53f68fb9", "customer4@abv.bg", "Jack", false, "Johnson", "525575", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "66f8c581-f6f0-406c-9af0-35e7d2567b09" },
                    { "2de9d5f0-1c53-4aaf-885a-e83c17ea4950", "f40d8b19-06cc-4554-b6cb-67414611c0df" },
                    { "0eebc067-bed8-41aa-8505-3e09dcbaace4", "f40d8b19-06cc-4554-b6cb-67414611c0df" },
                    { "7531416f-579f-4c1b-bc20-1a014f071f6d", "f40d8b19-06cc-4554-b6cb-67414611c0df" },
                    { "7cdcf7d4-0b82-4916-82e8-a669796ee3c2", "f40d8b19-06cc-4554-b6cb-67414611c0df" },
                    { "d43f19f8-6f5d-4a29-a1fe-0505e250ac14", "f40d8b19-06cc-4554-b6cb-67414611c0df" }
                });
        }
    }
}
