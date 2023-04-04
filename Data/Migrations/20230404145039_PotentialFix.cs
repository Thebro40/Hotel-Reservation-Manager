using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class PotentialFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "a8c738c6-e0bc-48f1-973a-2f750788321e", "6120d670-696a-48df-adeb-d2fd62c6adba", "Admin", "ADMIN" },
                    { "b4edf928-13cd-4401-b449-410c6a59b636", "3a99de59-2419-4da0-a958-88fa01d6a4e1", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "e603befd-0e84-46fd-bd4b-2c10051b3728", new DateTime(2023, 4, 4, 17, 50, 38, 210, DateTimeKind.Local).AddTicks(4339), "AQAAAAEAACcQAAAAEGw+q+SCpI50/cMggHXG9iFTtXhXi6MSeCgo/VDtcpC3K7ucOSuS+9tyWTGMnbkWww==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "22114927-6f59-48d1-a1a7-598beb4e7972", 0, "49375c48-e5bd-4c27-b8b3-3ba71b1dc0e4", "user0@abv.bg", true, null, "Jack", new DateTime(2023, 4, 4, 17, 50, 38, 217, DateTimeKind.Local).AddTicks(9373), true, "Johnson", false, null, "John", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEPu6SgPdtQ9e7c/LplTWxxA5u9rkCxmaNl7XqT0JJD+bziGP8ozfj5wJO93H5kENfw==", "004953", true, "", false, "004706", "user0@abv.bg" },
                    { "ad2760cb-a5fd-405d-b0d5-fbd00e5691a0", 0, "d946db5e-139e-471e-81d7-9ba3029c4d50", "user1@abv.bg", true, null, "Alex", new DateTime(2023, 4, 4, 17, 50, 38, 227, DateTimeKind.Local).AddTicks(1126), true, "Johnson", false, null, "Jane", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEPvx8n2RiPxv18tbEF19WZn6SAhzMT+0tOsuBw+wSmbSECfqA4L625E4xdPGUybiyQ==", "000162", true, "", false, "001213", "user1@abv.bg" },
                    { "53056158-ce78-4e98-b0a1-d3853b3c58a0", 0, "63d37b7b-3049-4ce8-833a-d3b2cae5023f", "user2@abv.bg", true, null, "Jane", new DateTime(2023, 4, 4, 17, 50, 38, 235, DateTimeKind.Local).AddTicks(7765), true, "Alexandrov", false, null, "John", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEKxkAHkstjXEc6wNmM+pCVnV2/91wVhd5qogEdi8/L6BUubfhjj20odzmNvqfddzmQ==", "006937", true, "", false, "002380", "user2@abv.bg" },
                    { "0256b5f6-18d2-4cde-b1ac-c8d0d641ebb4", 0, "a56ac65e-c6ab-470b-8bc4-e6e2649ccb08", "user3@abv.bg", true, null, "Jack", new DateTime(2023, 4, 4, 17, 50, 38, 244, DateTimeKind.Local).AddTicks(1863), true, "Johnson", false, null, "Jack", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEP1MDQNRwI9hWcP1mRweWzr3J6HGMg2hAWKNNBA6T+b++bE9Nl3XKdVvor1jkVEiKA==", "009777", true, "", false, "005960", "user3@abv.bg" },
                    { "93d15c5f-2c24-40e9-9ab9-32f1d74b1b7f", 0, "ed6b8003-f3ad-49fe-b286-ce7bc9c94144", "user4@abv.bg", true, null, "Jane", new DateTime(2023, 4, 4, 17, 50, 38, 252, DateTimeKind.Local).AddTicks(6655), true, "Johnson", false, null, "Jack", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEBoJw76qwPAJ5tByIcJgxiu3BwQYXtxfhW/bsPZIxuyzflc2yJQ0d7iTwD2x7SlRxQ==", "004725", true, "", false, "001670", "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "80685df1-ae8f-4952-9939-e97690c48664", "customer0@abv.bg", "Jane", false, "Alexandrov", "011820", null },
                    { "6fc60cf8-bb8c-47ed-b607-ed1e4ea92204", "customer1@abv.bg", "Alex", false, "Johnson", "047125", null },
                    { "0313f91c-0440-4470-8531-1a4f76ad48b1", "customer2@abv.bg", "John", false, "Johnson", "218031", null },
                    { "57ad24b5-b3c4-419c-9820-4737913751d1", "customer3@abv.bg", "Jack", false, "Johnson", "920752", null },
                    { "ca7999b2-83fb-44fc-99b5-a6c2d815dbc2", "customer4@abv.bg", "Alex", false, "Alexandrov", "313733", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "a8c738c6-e0bc-48f1-973a-2f750788321e" },
                    { "22114927-6f59-48d1-a1a7-598beb4e7972", "b4edf928-13cd-4401-b449-410c6a59b636" },
                    { "ad2760cb-a5fd-405d-b0d5-fbd00e5691a0", "b4edf928-13cd-4401-b449-410c6a59b636" },
                    { "53056158-ce78-4e98-b0a1-d3853b3c58a0", "b4edf928-13cd-4401-b449-410c6a59b636" },
                    { "0256b5f6-18d2-4cde-b1ac-c8d0d641ebb4", "b4edf928-13cd-4401-b449-410c6a59b636" },
                    { "93d15c5f-2c24-40e9-9ab9-32f1d74b1b7f", "b4edf928-13cd-4401-b449-410c6a59b636" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0256b5f6-18d2-4cde-b1ac-c8d0d641ebb4", "b4edf928-13cd-4401-b449-410c6a59b636" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "22114927-6f59-48d1-a1a7-598beb4e7972", "b4edf928-13cd-4401-b449-410c6a59b636" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "53056158-ce78-4e98-b0a1-d3853b3c58a0", "b4edf928-13cd-4401-b449-410c6a59b636" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "a8c738c6-e0bc-48f1-973a-2f750788321e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "93d15c5f-2c24-40e9-9ab9-32f1d74b1b7f", "b4edf928-13cd-4401-b449-410c6a59b636" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ad2760cb-a5fd-405d-b0d5-fbd00e5691a0", "b4edf928-13cd-4401-b449-410c6a59b636" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "0313f91c-0440-4470-8531-1a4f76ad48b1");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "57ad24b5-b3c4-419c-9820-4737913751d1");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6fc60cf8-bb8c-47ed-b607-ed1e4ea92204");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "80685df1-ae8f-4952-9939-e97690c48664");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "ca7999b2-83fb-44fc-99b5-a6c2d815dbc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8c738c6-e0bc-48f1-973a-2f750788321e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4edf928-13cd-4401-b449-410c6a59b636");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0256b5f6-18d2-4cde-b1ac-c8d0d641ebb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22114927-6f59-48d1-a1a7-598beb4e7972");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53056158-ce78-4e98-b0a1-d3853b3c58a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93d15c5f-2c24-40e9-9ab9-32f1d74b1b7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad2760cb-a5fd-405d-b0d5-fbd00e5691a0");

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
    }
}
