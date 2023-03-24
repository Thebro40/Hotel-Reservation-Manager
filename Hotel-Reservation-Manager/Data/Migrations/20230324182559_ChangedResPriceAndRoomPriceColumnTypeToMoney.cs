using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.data.migrations
{
    public partial class ChangedResPriceAndRoomPriceColumnTypeToMoney : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0fb09dee-6f70-4171-a729-376daa78332c", "a1477455-7ab0-41ba-8222-5041ee3d73b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "43b7ddc0-3718-49b0-bbb0-23bd2ddb712b", "a1477455-7ab0-41ba-8222-5041ee3d73b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "55d513f5-afb6-408b-8ca5-e450d01c52a4", "a1477455-7ab0-41ba-8222-5041ee3d73b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "2e6a08f6-35ed-4b76-a42c-c0f6484c2b14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b319e86f-5ba8-4b74-bb17-f5382c277d68", "a1477455-7ab0-41ba-8222-5041ee3d73b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c8e761d9-3e95-4d68-b536-85adaf0d3954", "a1477455-7ab0-41ba-8222-5041ee3d73b4" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7a5bbc11-16aa-46c7-abe7-e2d8ac4b48bf");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9e106149-a2e7-45cb-b239-2166b8f0a743");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a7641513-2f95-4d0b-9781-122d036fc442");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "cd0a896d-bb26-444a-b6c0-c57041ddbaf0");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "e54fd49a-75b2-4eaf-8370-070fcdd8522b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e6a08f6-35ed-4b76-a42c-c0f6484c2b14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1477455-7ab0-41ba-8222-5041ee3d73b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fb09dee-6f70-4171-a729-376daa78332c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43b7ddc0-3718-49b0-bbb0-23bd2ddb712b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55d513f5-afb6-408b-8ca5-e450d01c52a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b319e86f-5ba8-4b74-bb17-f5382c277d68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8e761d9-3e95-4d68-b536-85adaf0d3954");

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerBedChild",
                table: "Rooms",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerBedAdult",
                table: "Rooms",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Reservations",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "63c7a199-d368-43e7-a30b-10a7a9e51dec", "6cf69a70-5799-4a08-bf9c-46faa2497eab", "Admin", "ADMIN" },
                    { "8785bac4-ccd5-4c3f-a54a-d359b45c4aec", "a895f858-5a07-427c-97d0-55ed87d5c5c4", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "198254da-2ff2-4f16-b3c0-cf0d8352c73b", new DateTime(2023, 3, 24, 20, 25, 59, 11, DateTimeKind.Local).AddTicks(9503), "AQAAAAEAACcQAAAAELOKfHLNcQPZmYcbp+Wpx0BV/W6k+I5VAWWxM5AvtYDyWtBmeTVVn4zgrpWH9dZzew==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "74f66afe-d2bb-436d-a8fa-db4a6db02a42", 0, "f1bf4cef-3ffd-493a-ad75-7714960fd178", "009791", "user0@abv.bg", true, null, "Jane", new DateTime(2023, 3, 24, 20, 25, 59, 17, DateTimeKind.Local).AddTicks(9483), true, "Alexandrov", false, null, "John", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEAREPu0Hp0BiE3B57pqtpXYZnVQcIMp7lLCJ6wrnv0HXHIC8OOpykkPA1sMlKrxSCw==", "008272", true, "", false, "user0@abv.bg" },
                    { "4fc6eb55-51f4-4d5a-8db4-aede355f7f1a", 0, "5390a666-93b7-47cd-aea6-46347818213e", "007383", "user1@abv.bg", true, null, "John", new DateTime(2023, 3, 24, 20, 25, 59, 26, DateTimeKind.Local).AddTicks(3415), true, "Alexandrov", false, null, "Alex", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEOmx3sPd4jT+9iTgakrLCQFiNYKJVyA/irg9Y9Nj4WxRmxJ5LwQBvLpbyzupEKKZ7w==", "004539", true, "", false, "user1@abv.bg" },
                    { "1f8c01d3-363f-466c-85f6-ca3dbc30ca52", 0, "678f1b42-c2c2-4a9e-b264-25eb6fa2da8f", "000740", "user2@abv.bg", true, null, "Alex", new DateTime(2023, 3, 24, 20, 25, 59, 34, DateTimeKind.Local).AddTicks(4111), true, "Johnson", false, null, "Alex", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEIYFUpkRKbP2CsV14gSYW1IEP4AXBXPayIophUsdh/aM7xWtYCyfFdlGaIqeqUM2xA==", "008695", true, "", false, "user2@abv.bg" },
                    { "bbfcad3c-2e2e-40c7-aa7e-3afacdbd424f", 0, "3c42830c-a8ca-4d80-a085-c64cc1835ea9", "005674", "user3@abv.bg", true, null, "Jack", new DateTime(2023, 3, 24, 20, 25, 59, 42, DateTimeKind.Local).AddTicks(7318), true, "Alexandrov", false, null, "Alex", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEFIqwr/w4MUUt0sjXw4Jhy3Rjp1ZO7xukbeI5ZTij7eE1RZVT2ZZMkLwOEdUWv058g==", "008137", true, "", false, "user3@abv.bg" },
                    { "2a972c89-d9c0-4955-be52-ecdcf2b642fc", 0, "fe333319-1a61-4638-8a73-150fbdbdaab2", "003812", "user4@abv.bg", true, null, "Jane", new DateTime(2023, 3, 24, 20, 25, 59, 50, DateTimeKind.Local).AddTicks(9153), true, "Alexandrov", false, null, "Jack", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEBx7YJXMiCkY+CERWNKxllyabpFa15Xo0UzVYtu+uUt2RRDCkt3R7xP4IpYL57KWtw==", "000618", true, "", false, "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "c3d4ffb7-8faa-49e1-b53a-b6a54e150ef2", "customer0@abv.bg", "Jack", false, "Alexandrov", "572078", null },
                    { "98d98535-0f76-4f86-91c0-f7c6d31264f4", "customer1@abv.bg", "Jack", false, "Alexandrov", "318073", null },
                    { "0a879ae6-aebc-45fc-b243-3ba1f5c9e5c6", "customer2@abv.bg", "Jack", true, "Alexandrov", "675877", null },
                    { "71a4eb2f-55e2-4beb-95b6-cf289f0ab57c", "customer3@abv.bg", "Alex", false, "Johnson", "598184", null },
                    { "c2ec53cb-01e3-4073-b974-9900f68b460b", "customer4@abv.bg", "John", false, "Alexandrov", "324458", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "63c7a199-d368-43e7-a30b-10a7a9e51dec" },
                    { "74f66afe-d2bb-436d-a8fa-db4a6db02a42", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" },
                    { "4fc6eb55-51f4-4d5a-8db4-aede355f7f1a", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" },
                    { "1f8c01d3-363f-466c-85f6-ca3dbc30ca52", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" },
                    { "bbfcad3c-2e2e-40c7-aa7e-3afacdbd424f", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" },
                    { "2a972c89-d9c0-4955-be52-ecdcf2b642fc", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1f8c01d3-363f-466c-85f6-ca3dbc30ca52", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2a972c89-d9c0-4955-be52-ecdcf2b642fc", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4fc6eb55-51f4-4d5a-8db4-aede355f7f1a", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "74f66afe-d2bb-436d-a8fa-db4a6db02a42", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "63c7a199-d368-43e7-a30b-10a7a9e51dec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bbfcad3c-2e2e-40c7-aa7e-3afacdbd424f", "8785bac4-ccd5-4c3f-a54a-d359b45c4aec" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "0a879ae6-aebc-45fc-b243-3ba1f5c9e5c6");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "71a4eb2f-55e2-4beb-95b6-cf289f0ab57c");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "98d98535-0f76-4f86-91c0-f7c6d31264f4");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "c2ec53cb-01e3-4073-b974-9900f68b460b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "c3d4ffb7-8faa-49e1-b53a-b6a54e150ef2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63c7a199-d368-43e7-a30b-10a7a9e51dec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8785bac4-ccd5-4c3f-a54a-d359b45c4aec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f8c01d3-363f-466c-85f6-ca3dbc30ca52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a972c89-d9c0-4955-be52-ecdcf2b642fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fc6eb55-51f4-4d5a-8db4-aede355f7f1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74f66afe-d2bb-436d-a8fa-db4a6db02a42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bbfcad3c-2e2e-40c7-aa7e-3afacdbd424f");

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerBedChild",
                table: "Rooms",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "PricePerBedAdult",
                table: "Rooms",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Reservations",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e6a08f6-35ed-4b76-a42c-c0f6484c2b14", "e6e0835b-83b2-4165-ba03-448201697687", "Admin", "ADMIN" },
                    { "a1477455-7ab0-41ba-8222-5041ee3d73b4", "80570895-1f3b-4843-9e04-40670d7f24ba", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "ad4e2eda-503f-4864-b802-3ea203d18c3f", new DateTime(2023, 3, 18, 2, 39, 33, 737, DateTimeKind.Local).AddTicks(4070), "AQAAAAEAACcQAAAAEH++ZRlhZlE8/6erKmWW58oOzd7rOgqNqQSTW7rBUVYModLF1vwJk3Hdg8fbROmpWw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b319e86f-5ba8-4b74-bb17-f5382c277d68", 0, "07ccce53-350d-4783-a193-fb3ff9767590", "000956", "user0@abv.bg", true, null, "John", new DateTime(2023, 3, 18, 2, 39, 33, 742, DateTimeKind.Local).AddTicks(9548), true, "Alexandrov", false, null, "Jack", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEL+HmyFze/vD92mLEE+FeacnpQ0wOdUJi1bzLm23zYVki7BJEuo0shxRmvNe8Z23Cw==", "007342", true, "", false, "user0@abv.bg" },
                    { "43b7ddc0-3718-49b0-bbb0-23bd2ddb712b", 0, "33aca18d-72f5-42a5-b84b-08b142e2336f", "002792", "user1@abv.bg", true, null, "Jack", new DateTime(2023, 3, 18, 2, 39, 33, 751, DateTimeKind.Local).AddTicks(486), true, "Alexandrov", false, null, "Jack", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEB14IMBTd5ssz+JIv4SERHcYtNOoJj2KVHY6o9l/tj/EtwdMMKaZZ7WLwIleOnwtOw==", "007384", true, "", false, "user1@abv.bg" },
                    { "c8e761d9-3e95-4d68-b536-85adaf0d3954", 0, "3a1b2ab7-40b4-4a3a-b207-572238757218", "005065", "user2@abv.bg", true, null, "John", new DateTime(2023, 3, 18, 2, 39, 33, 758, DateTimeKind.Local).AddTicks(6178), true, "Johnson", false, null, "Alex", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEDR+w+2q7aiBX9gRk+1rjrCsV3CkKoSikkprHyZzngQ+BTRytP7RC4ThaYxx2mZyoQ==", "001292", true, "", false, "user2@abv.bg" },
                    { "55d513f5-afb6-408b-8ca5-e450d01c52a4", 0, "794eff4b-45a6-4ef5-880f-c7fd8a1d0e09", "005938", "user3@abv.bg", true, null, "John", new DateTime(2023, 3, 18, 2, 39, 33, 766, DateTimeKind.Local).AddTicks(4268), true, "Alexandrov", false, null, "Jane", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEP1iGEOTTAFanz4NJlV+tP3nFF53WV2J6BL8j9c8VgKq9tqd88wIMrbuKpMUuwdHYg==", "002462", true, "", false, "user3@abv.bg" },
                    { "0fb09dee-6f70-4171-a729-376daa78332c", 0, "ce07db8b-42e1-4180-b947-f0ac540ac142", "007687", "user4@abv.bg", true, null, "Alex", new DateTime(2023, 3, 18, 2, 39, 33, 774, DateTimeKind.Local).AddTicks(3077), true, "Johnson", false, null, "Alex", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEN6adEDKmgfO+cKAqgYqHKXBIRxGRyrAURpsyVNBqHvCpP4hLMn6V6YUvDuJnUyT8w==", "007972", true, "", false, "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "a7641513-2f95-4d0b-9781-122d036fc442", "customer0@abv.bg", "Jane", false, "Alexandrov", "936031", null },
                    { "7a5bbc11-16aa-46c7-abe7-e2d8ac4b48bf", "customer1@abv.bg", "Alex", false, "Johnson", "521940", null },
                    { "e54fd49a-75b2-4eaf-8370-070fcdd8522b", "customer2@abv.bg", "Jane", true, "Alexandrov", "168568", null },
                    { "cd0a896d-bb26-444a-b6c0-c57041ddbaf0", "customer3@abv.bg", "John", false, "Johnson", "950495", null },
                    { "9e106149-a2e7-45cb-b239-2166b8f0a743", "customer4@abv.bg", "John", false, "Alexandrov", "332020", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "2e6a08f6-35ed-4b76-a42c-c0f6484c2b14" },
                    { "b319e86f-5ba8-4b74-bb17-f5382c277d68", "a1477455-7ab0-41ba-8222-5041ee3d73b4" },
                    { "43b7ddc0-3718-49b0-bbb0-23bd2ddb712b", "a1477455-7ab0-41ba-8222-5041ee3d73b4" },
                    { "c8e761d9-3e95-4d68-b536-85adaf0d3954", "a1477455-7ab0-41ba-8222-5041ee3d73b4" },
                    { "55d513f5-afb6-408b-8ca5-e450d01c52a4", "a1477455-7ab0-41ba-8222-5041ee3d73b4" },
                    { "0fb09dee-6f70-4171-a729-376daa78332c", "a1477455-7ab0-41ba-8222-5041ee3d73b4" }
                });
        }
    }
}
