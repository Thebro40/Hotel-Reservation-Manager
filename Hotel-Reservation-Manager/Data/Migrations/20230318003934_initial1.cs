using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.data.migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "037a0d7e-f4c0-4c24-bc94-008a4a5075c2", "5c937bab-1742-4952-9945-cf9d65468516" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "27d87402-e834-4fc7-b22c-941f1e759cf4", "5c937bab-1742-4952-9945-cf9d65468516" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7024306a-7151-45e7-b257-03ff8fc9f404", "5c937bab-1742-4952-9945-cf9d65468516" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7c627bc7-5238-4739-857e-03abf066d1d0", "5c937bab-1742-4952-9945-cf9d65468516" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8197ce90-61be-49e9-9828-1d055021a4ce", "5c937bab-1742-4952-9945-cf9d65468516" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "391a393f-0c18-47f8-b416-58e402ed674a" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "370d863f-99d0-4639-902d-8fa790290961");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7711cf8c-a28c-4a4f-9407-3db0a755077c");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "79e42517-cf67-4b24-9c54-7eeef9febf22");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a4241003-0d1a-40b1-b67d-5f5348336ee2");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "baa21250-809e-4965-aae2-99dbe3a9868d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "391a393f-0c18-47f8-b416-58e402ed674a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c937bab-1742-4952-9945-cf9d65468516");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "037a0d7e-f4c0-4c24-bc94-008a4a5075c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d87402-e834-4fc7-b22c-941f1e759cf4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7024306a-7151-45e7-b257-03ff8fc9f404");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c627bc7-5238-4739-857e-03abf066d1d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8197ce90-61be-49e9-9828-1d055021a4ce");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Reservations");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "391a393f-0c18-47f8-b416-58e402ed674a", "c7d3bffe-3598-4fda-9294-cfc009968b4c", "Admin", "ADMIN" },
                    { "5c937bab-1742-4952-9945-cf9d65468516", "540e7470-7b0d-4883-b218-ca81e22a50d0", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "7c1411fc-f4da-42b4-8678-f248c834d3ea", new DateTime(2023, 3, 17, 15, 51, 13, 33, DateTimeKind.Local).AddTicks(7277), "AQAAAAEAACcQAAAAEOE7RenII98uzt4fjU4lamxI3hRNUCUsO7BrgbL5UmOWuP7o5Y46CQIe++Vtti0Hxw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8197ce90-61be-49e9-9828-1d055021a4ce", 0, "b8bc7dfd-599e-46b4-9011-98859e9dea8d", "001945", "user0@abv.bg", true, null, "Jane", new DateTime(2023, 3, 17, 15, 51, 13, 43, DateTimeKind.Local).AddTicks(7211), true, "Alexandrov", false, null, "Jane", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAELsQNuShGZ0hryGsd8AasG0C36yIgrlHxwX7xl386KQIp6P1mq5HPcdz+yDk6Rxpqg==", "006192", true, "", false, "user0@abv.bg" },
                    { "27d87402-e834-4fc7-b22c-941f1e759cf4", 0, "a94a3b6d-0c67-484e-9a47-adeedda6a1a3", "007059", "user1@abv.bg", true, null, "Alex", new DateTime(2023, 3, 17, 15, 51, 13, 52, DateTimeKind.Local).AddTicks(9040), true, "Johnson", false, null, "John", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEO8In8pqrfiqR0HKNXLqcMjySnYwfQZxoVUuCdUgDke7LCi84mGv7w50zhMSQf7YnQ==", "000927", true, "", false, "user1@abv.bg" },
                    { "7c627bc7-5238-4739-857e-03abf066d1d0", 0, "8071aabf-b95c-4f72-b692-6c17b435dd48", "003896", "user2@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 15, 51, 13, 68, DateTimeKind.Local).AddTicks(4209), true, "Alexandrov", false, null, "John", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEBg2GK/EUAxJNcsFQEeiAofPJy9Zmk+OfzLzCrJ8dtb6VMRnNF+56ocSu0gcONjh2Q==", "002986", true, "", false, "user2@abv.bg" },
                    { "037a0d7e-f4c0-4c24-bc94-008a4a5075c2", 0, "c60c6687-4273-4eba-be9a-7b382fd02a89", "000910", "user3@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 15, 51, 13, 81, DateTimeKind.Local).AddTicks(1999), true, "Johnson", false, null, "Jane", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEMM+4OMhb4+xK9USbejIf1NKNYbJakfX03JxyT09it0p01IJXtuzApXFT76WNA4mgw==", "001293", true, "", false, "user3@abv.bg" },
                    { "7024306a-7151-45e7-b257-03ff8fc9f404", 0, "4bec8b24-ae41-4e2c-ae46-97298db007cf", "007670", "user4@abv.bg", true, null, "John", new DateTime(2023, 3, 17, 15, 51, 13, 95, DateTimeKind.Local).AddTicks(3219), true, "Alexandrov", false, null, "John", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEMrym8oGqMXcXeX7ixTPD0m/1RQoBs8rB0oEAF+GTRGeotcvagO8aZd4J5ohN84bGw==", "004551", true, "", false, "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "baa21250-809e-4965-aae2-99dbe3a9868d", "customer0@abv.bg", "Alex", false, "Alexandrov", "721151", null },
                    { "a4241003-0d1a-40b1-b67d-5f5348336ee2", "customer1@abv.bg", "Jane", false, "Alexandrov", "615801", null },
                    { "370d863f-99d0-4639-902d-8fa790290961", "customer2@abv.bg", "Alex", true, "Alexandrov", "581427", null },
                    { "79e42517-cf67-4b24-9c54-7eeef9febf22", "customer3@abv.bg", "Alex", true, "Alexandrov", "923112", null },
                    { "7711cf8c-a28c-4a4f-9407-3db0a755077c", "customer4@abv.bg", "John", false, "Johnson", "237991", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "391a393f-0c18-47f8-b416-58e402ed674a" },
                    { "8197ce90-61be-49e9-9828-1d055021a4ce", "5c937bab-1742-4952-9945-cf9d65468516" },
                    { "27d87402-e834-4fc7-b22c-941f1e759cf4", "5c937bab-1742-4952-9945-cf9d65468516" },
                    { "7c627bc7-5238-4739-857e-03abf066d1d0", "5c937bab-1742-4952-9945-cf9d65468516" },
                    { "037a0d7e-f4c0-4c24-bc94-008a4a5075c2", "5c937bab-1742-4952-9945-cf9d65468516" },
                    { "7024306a-7151-45e7-b257-03ff8fc9f404", "5c937bab-1742-4952-9945-cf9d65468516" }
                });
        }
    }
}
