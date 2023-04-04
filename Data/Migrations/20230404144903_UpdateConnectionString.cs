using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class UpdateConnectionString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f8fd7f9-c188-447b-8081-fbc2b21b1f48", "838f17ed-9ce0-44bf-9cf4-d389c9f8b235", "Admin", "ADMIN" },
                    { "530f19e5-5839-4b40-865c-937230e3298f", "8951eb84-fea2-4fa1-85bd-6b994c577d0a", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "29cf92fe-6bf6-4be3-a804-d2c123109315", new DateTime(2023, 4, 4, 17, 49, 2, 192, DateTimeKind.Local).AddTicks(8241), "AQAAAAEAACcQAAAAEOqwVzsXOWiMSQXGYpx6+W6QK32c/fP7sEPEG7C1VGbdWrIeDQOJjEHzLvXSiyUA9Q==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "7eaef534-e21d-4bb9-b539-f59f7d562ced", 0, "51cabda7-a787-4c4b-aee7-7af7b1ea7f0a", "user0@abv.bg", true, null, "John", new DateTime(2023, 4, 4, 17, 49, 2, 199, DateTimeKind.Local).AddTicks(6686), true, "Johnson", false, null, "Jack", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEPeIdcxSY8qUZ2cTvNLXG0CCoLG9yLGnr7JwkHQX/DQOxYyyS2WQ0FoK6/oLZarpsg==", "000063", true, "", false, "008174", "user0@abv.bg" },
                    { "418e4c71-a36c-4a66-8bc0-5625a9c7d979", 0, "71358607-7645-450f-8309-82313ec8b39e", "user1@abv.bg", true, null, "Jane", new DateTime(2023, 4, 4, 17, 49, 2, 207, DateTimeKind.Local).AddTicks(8211), true, "Johnson", false, null, "Jack", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAELipfwrmStnzx4nJGwrDGc7Zp3o+JJn8VmyRDZqO4kPJJSa2S6m1Ugf+wLtulDiWig==", "001735", true, "", false, "000006", "user1@abv.bg" },
                    { "57c79831-63fc-4569-9d81-e8db0ff1d149", 0, "ca52d33b-cfd9-47b2-a9dd-6f8705ab507a", "user2@abv.bg", true, null, "Alex", new DateTime(2023, 4, 4, 17, 49, 2, 215, DateTimeKind.Local).AddTicks(8668), true, "Johnson", false, null, "Jane", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEHV6/QL0FEgSMarNgzDbtNQ9ayTTjSedH7mI4fRJQ1iVu4j3D2jQTO+vSeRkdJbdpQ==", "002759", true, "", false, "007559", "user2@abv.bg" },
                    { "77f83e7b-8ada-4fb3-bd7c-55d6500cc140", 0, "a9b1475e-2104-4d5d-87e3-aeb880183ad3", "user3@abv.bg", true, null, "Jane", new DateTime(2023, 4, 4, 17, 49, 2, 223, DateTimeKind.Local).AddTicks(7505), true, "Johnson", false, null, "Alex", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEBQbisXHCKV8jtkZZKMlZ3UOTe8aBEvEuveIlxfVWFrHo9hghbLmOBrqXLJGtfWoLA==", "004956", true, "", false, "009072", "user3@abv.bg" },
                    { "ac1ef0b5-804c-4a2a-a2be-8b044192dcc3", 0, "4c60cd6d-df4a-4bbb-82b0-531a74dffe1c", "user4@abv.bg", true, null, "Alex", new DateTime(2023, 4, 4, 17, 49, 2, 231, DateTimeKind.Local).AddTicks(3504), true, "Johnson", false, null, "Jane", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEJk1kGymxg0Ia4goPOoJjKZ77ufZmab0DeboipqybWMteO2fYfgR7X/ns3n3TIQ6Zw==", "007497", true, "", false, "004224", "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "87c53f71-ff57-4274-abc0-340c7e69751a", "customer0@abv.bg", "John", false, "Alexandrov", "050345", null },
                    { "82614971-1b07-4ec3-b4d7-4492e7e2326b", "customer1@abv.bg", "Alex", false, "Alexandrov", "307020", null },
                    { "4a741437-3a85-4f42-b284-1c1e441cfa41", "customer2@abv.bg", "Jack", true, "Alexandrov", "228336", null },
                    { "97525404-e0c7-49ff-9b2e-9cc34af3b572", "customer3@abv.bg", "John", false, "Johnson", "328620", null },
                    { "32f27254-6aef-4e51-b8b7-b2d110746969", "customer4@abv.bg", "Jack", false, "Johnson", "361673", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "0f8fd7f9-c188-447b-8081-fbc2b21b1f48" },
                    { "7eaef534-e21d-4bb9-b539-f59f7d562ced", "530f19e5-5839-4b40-865c-937230e3298f" },
                    { "418e4c71-a36c-4a66-8bc0-5625a9c7d979", "530f19e5-5839-4b40-865c-937230e3298f" },
                    { "57c79831-63fc-4569-9d81-e8db0ff1d149", "530f19e5-5839-4b40-865c-937230e3298f" },
                    { "77f83e7b-8ada-4fb3-bd7c-55d6500cc140", "530f19e5-5839-4b40-865c-937230e3298f" },
                    { "ac1ef0b5-804c-4a2a-a2be-8b044192dcc3", "530f19e5-5839-4b40-865c-937230e3298f" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "418e4c71-a36c-4a66-8bc0-5625a9c7d979", "530f19e5-5839-4b40-865c-937230e3298f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "57c79831-63fc-4569-9d81-e8db0ff1d149", "530f19e5-5839-4b40-865c-937230e3298f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "77f83e7b-8ada-4fb3-bd7c-55d6500cc140", "530f19e5-5839-4b40-865c-937230e3298f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7eaef534-e21d-4bb9-b539-f59f7d562ced", "530f19e5-5839-4b40-865c-937230e3298f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "0f8fd7f9-c188-447b-8081-fbc2b21b1f48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ac1ef0b5-804c-4a2a-a2be-8b044192dcc3", "530f19e5-5839-4b40-865c-937230e3298f" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "32f27254-6aef-4e51-b8b7-b2d110746969");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4a741437-3a85-4f42-b284-1c1e441cfa41");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "82614971-1b07-4ec3-b4d7-4492e7e2326b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "87c53f71-ff57-4274-abc0-340c7e69751a");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "97525404-e0c7-49ff-9b2e-9cc34af3b572");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f8fd7f9-c188-447b-8081-fbc2b21b1f48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "530f19e5-5839-4b40-865c-937230e3298f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "418e4c71-a36c-4a66-8bc0-5625a9c7d979");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c79831-63fc-4569-9d81-e8db0ff1d149");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77f83e7b-8ada-4fb3-bd7c-55d6500cc140");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7eaef534-e21d-4bb9-b539-f59f7d562ced");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac1ef0b5-804c-4a2a-a2be-8b044192dcc3");

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
        }
    }
}
