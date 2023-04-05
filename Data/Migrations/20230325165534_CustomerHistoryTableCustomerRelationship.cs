using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class CustomerHistoryTableCustomerRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "CustomerHistory",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "715c3eff-4c3a-4be0-beeb-a8c4eb97a630", "279a39c8-0f24-4465-bfd9-6cc580fac581", "Admin", "ADMIN" },
                    { "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d", "090713db-fcc5-4363-8b51-ee08ae189d6e", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "a44a053f-b9cc-425d-9e1a-a381b95e6d5e", new DateTime(2023, 3, 25, 18, 55, 33, 790, DateTimeKind.Local).AddTicks(4976), "AQAAAAEAACcQAAAAEOUcBAXjU/cl59ObvoZ7dYiVZkwcZoLLSWK7K98jTmRrTEj6gN9MVfyTFHN4gP6T0Q==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "4f6a170b-a8a4-4509-92c0-de95de097de9", 0, "29afa2dd-1118-4256-9c2e-9ad02cbbcbf8", "user0@abv.bg", true, null, "John", new DateTime(2023, 3, 25, 18, 55, 33, 796, DateTimeKind.Local).AddTicks(7111), true, "Johnson", false, null, "Jane", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEGyaTjUmAI/3V+RW2lwiM3ZkSYY1tjOflqFTR2+5e7QqGPyz7MwbRKqxmYpGCQcyYw==", "002042", true, "", false, "005272", "user0@abv.bg" },
                    { "72ede08b-86a1-4987-b34c-7bc71d013905", 0, "b4b8c209-1829-4b70-bf84-4b0a1e41bb03", "user1@abv.bg", true, null, "John", new DateTime(2023, 3, 25, 18, 55, 33, 804, DateTimeKind.Local).AddTicks(9917), true, "Alexandrov", false, null, "Jack", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEIaWvplmyT5mhFSRpvtEiwQLF5cMpJwPkXlY20uOgnwEmfMWCFgjymSIpnTaSNxtJA==", "002064", true, "", false, "006602", "user1@abv.bg" },
                    { "3be20ac0-424d-498f-a57d-911115c90e82", 0, "0c36acba-028f-4777-8345-30e3bd6dbbb0", "user2@abv.bg", true, null, "Jack", new DateTime(2023, 3, 25, 18, 55, 33, 813, DateTimeKind.Local).AddTicks(2165), true, "Johnson", false, null, "Jack", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEGlR3MGVAaSGx22bbNxwkrXD1hxdGje/3PoLPu+jQ86FJ64qtZaaapXEZ59CQ+7l7Q==", "004859", true, "", false, "008995", "user2@abv.bg" },
                    { "155540ee-3727-4aeb-bd75-3de868275bf5", 0, "c2a8a74a-aa8d-441a-95cc-b5b3ed513cd4", "user3@abv.bg", true, null, "Jack", new DateTime(2023, 3, 25, 18, 55, 33, 821, DateTimeKind.Local).AddTicks(660), true, "Alexandrov", false, null, "Jack", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAECNQHsww+5mTylTbsDmfopDqhEOzz2Luo+r3sW6ZDo4UvufBebJokk1LEzcq8rBMdA==", "006392", true, "", false, "000427", "user3@abv.bg" },
                    { "d23001ee-a57d-4d29-9bf3-dfd265189348", 0, "3d95e25d-2aeb-4e05-b95f-fb3d2071cff8", "user4@abv.bg", true, null, "John", new DateTime(2023, 3, 25, 18, 55, 33, 829, DateTimeKind.Local).AddTicks(7941), true, "Alexandrov", false, null, "John", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAENvPCKxz0BJT9Ob6rksP1T7Bu+v97J7lRcQDVTKduRqiy8Jvj2iIVzgBUPKugqwPLg==", "002967", true, "", false, "000082", "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "30eec48d-0d0f-4fea-9dfd-344bad649cd2", "customer0@abv.bg", "Jack", true, "Johnson", "835509", null },
                    { "8b42ba23-f43c-4e47-a335-f50ea1525cdc", "customer1@abv.bg", "John", false, "Alexandrov", "323060", null },
                    { "6d8a40aa-c270-4744-9474-aaed1fbbe932", "customer2@abv.bg", "Alex", true, "Alexandrov", "044528", null },
                    { "5f1681cc-931f-4544-ae5c-708bde0baa4e", "customer3@abv.bg", "Jane", false, "Alexandrov", "454708", null },
                    { "78e36fb3-d523-4651-a7eb-c402411037af", "customer4@abv.bg", "Jack", false, "Johnson", "566779", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "715c3eff-4c3a-4be0-beeb-a8c4eb97a630" },
                    { "4f6a170b-a8a4-4509-92c0-de95de097de9", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" },
                    { "72ede08b-86a1-4987-b34c-7bc71d013905", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" },
                    { "3be20ac0-424d-498f-a57d-911115c90e82", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" },
                    { "155540ee-3727-4aeb-bd75-3de868275bf5", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" },
                    { "d23001ee-a57d-4d29-9bf3-dfd265189348", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerHistory_CustomerId",
                table: "CustomerHistory",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerHistory_Customers_CustomerId",
                table: "CustomerHistory",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerHistory_Customers_CustomerId",
                table: "CustomerHistory");

            migrationBuilder.DropIndex(
                name: "IX_CustomerHistory_CustomerId",
                table: "CustomerHistory");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "155540ee-3727-4aeb-bd75-3de868275bf5", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3be20ac0-424d-498f-a57d-911115c90e82", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4f6a170b-a8a4-4509-92c0-de95de097de9", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "72ede08b-86a1-4987-b34c-7bc71d013905", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "715c3eff-4c3a-4be0-beeb-a8c4eb97a630" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d23001ee-a57d-4d29-9bf3-dfd265189348", "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "30eec48d-0d0f-4fea-9dfd-344bad649cd2");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5f1681cc-931f-4544-ae5c-708bde0baa4e");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6d8a40aa-c270-4744-9474-aaed1fbbe932");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "78e36fb3-d523-4651-a7eb-c402411037af");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8b42ba23-f43c-4e47-a335-f50ea1525cdc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "715c3eff-4c3a-4be0-beeb-a8c4eb97a630");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97e1771e-18b8-4533-8a4e-7fccbd3c8a6d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "155540ee-3727-4aeb-bd75-3de868275bf5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3be20ac0-424d-498f-a57d-911115c90e82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f6a170b-a8a4-4509-92c0-de95de097de9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72ede08b-86a1-4987-b34c-7bc71d013905");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d23001ee-a57d-4d29-9bf3-dfd265189348");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "CustomerHistory",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
