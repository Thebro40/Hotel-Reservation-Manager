using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.data.migrations
{
    public partial class RemovedUnnecesaryRelationShipsConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c12a362-f81b-4dc3-a655-8016da334ef5", "067f9cf4-e570-468a-9f8f-f074a8f879f3", "Admin", "ADMIN" },
                    { "b4f508d1-2b96-4959-b2bd-de848903eee9", "41f3cdb5-511a-4f6f-9bd9-900f418d9e53", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "fa589cbd-ed4e-4129-9879-5a15cd9990a0", new DateTime(2023, 3, 24, 20, 27, 18, 797, DateTimeKind.Local).AddTicks(2344), "AQAAAAEAACcQAAAAEMVeM0tu0k8RIuYt/Y1w5eqYlCvA2s4KKXxmCv/0X4XiQXyLma6FFaeqW72uoz6Rmg==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "454329d5-c889-4247-a4d8-2519ff138fea", 0, "a7fef032-5558-4246-93ad-21e031460e25", "004644", "user0@abv.bg", true, null, "Jack", new DateTime(2023, 3, 24, 20, 27, 18, 804, DateTimeKind.Local).AddTicks(4503), true, "Alexandrov", false, null, "Alex", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEKSh7h3pTJHEhhslQ8GVOZNuc5O/BBCbnDYyEnGdB4vBp0SxA5oJmEn5pUnGXs+T8w==", "006956", true, "", false, "user0@abv.bg" },
                    { "2a8aba74-977c-40c2-919e-d11a8b407cbe", 0, "0a64779d-fa37-4d5a-b6f3-89fcf632711a", "008554", "user1@abv.bg", true, null, "John", new DateTime(2023, 3, 24, 20, 27, 18, 813, DateTimeKind.Local).AddTicks(3456), true, "Alexandrov", false, null, "Alex", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEOpHZHUfQXnvD7XLMyOvFhrrumREmYF/yQwK7fJ5HFZNdVbjhPocGwY2vt0okS93Og==", "002423", true, "", false, "user1@abv.bg" },
                    { "d0b251f0-76ec-4879-afdc-1730c201e01e", 0, "11ce9817-c8f6-4ab3-8c5e-8060d86adb71", "004343", "user2@abv.bg", true, null, "Jane", new DateTime(2023, 3, 24, 20, 27, 18, 821, DateTimeKind.Local).AddTicks(5480), true, "Johnson", false, null, "Alex", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEOTDdgP2aTEraxYqpdY9U69lLzvg4sEOEnNS0Jb1PusbE5h1oulisL8UFbeOQV7vAQ==", "004839", true, "", false, "user2@abv.bg" },
                    { "bb074b8e-5b09-4fc1-8718-f426d91b2892", 0, "bda772e7-15cf-490b-9319-064de0aa41c7", "007607", "user3@abv.bg", true, null, "Alex", new DateTime(2023, 3, 24, 20, 27, 18, 835, DateTimeKind.Local).AddTicks(5006), true, "Alexandrov", false, null, "Jack", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAENEDWOxlTs+icn9MgeCVBHfDlWbJ4USjvujmwOeSsoAI2e6cR+pN5r9rSfbTbr0Lxw==", "001740", true, "", false, "user3@abv.bg" },
                    { "08b8ffc9-068c-4f38-b937-53e9d117833f", 0, "ae084632-6b3b-4e49-b918-a837c9bfc67f", "001619", "user4@abv.bg", true, null, "Jane", new DateTime(2023, 3, 24, 20, 27, 18, 845, DateTimeKind.Local).AddTicks(8912), true, "Alexandrov", false, null, "Jack", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEHASEeJeS9aw3gm44OMIQbaRD8FUh2Zip0BKWqLVr+o7Pd/5y5/xUdpFa3LXgKZZOw==", "005707", true, "", false, "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "1202b47e-c444-4806-9610-f0d8639f58bb", "customer0@abv.bg", "Jane", false, "Johnson", "683123", null },
                    { "73b4727f-cc23-489a-b419-da9df5461a98", "customer1@abv.bg", "Jane", true, "Johnson", "875513", null },
                    { "ec85758b-b4cb-48ad-861c-7dfbdd697b3c", "customer2@abv.bg", "John", false, "Johnson", "230755", null },
                    { "b4fdf95c-0009-40ff-bba7-d5a2cb897e72", "customer3@abv.bg", "Jack", false, "Alexandrov", "986249", null },
                    { "b98d48e7-b28f-457c-9234-1a42e7953b06", "customer4@abv.bg", "Jane", false, "Alexandrov", "908070", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "5c12a362-f81b-4dc3-a655-8016da334ef5" },
                    { "454329d5-c889-4247-a4d8-2519ff138fea", "b4f508d1-2b96-4959-b2bd-de848903eee9" },
                    { "2a8aba74-977c-40c2-919e-d11a8b407cbe", "b4f508d1-2b96-4959-b2bd-de848903eee9" },
                    { "d0b251f0-76ec-4879-afdc-1730c201e01e", "b4f508d1-2b96-4959-b2bd-de848903eee9" },
                    { "bb074b8e-5b09-4fc1-8718-f426d91b2892", "b4f508d1-2b96-4959-b2bd-de848903eee9" },
                    { "08b8ffc9-068c-4f38-b937-53e9d117833f", "b4f508d1-2b96-4959-b2bd-de848903eee9" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "08b8ffc9-068c-4f38-b937-53e9d117833f", "b4f508d1-2b96-4959-b2bd-de848903eee9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2a8aba74-977c-40c2-919e-d11a8b407cbe", "b4f508d1-2b96-4959-b2bd-de848903eee9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "454329d5-c889-4247-a4d8-2519ff138fea", "b4f508d1-2b96-4959-b2bd-de848903eee9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "5c12a362-f81b-4dc3-a655-8016da334ef5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bb074b8e-5b09-4fc1-8718-f426d91b2892", "b4f508d1-2b96-4959-b2bd-de848903eee9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d0b251f0-76ec-4879-afdc-1730c201e01e", "b4f508d1-2b96-4959-b2bd-de848903eee9" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1202b47e-c444-4806-9610-f0d8639f58bb");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "73b4727f-cc23-489a-b419-da9df5461a98");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "b4fdf95c-0009-40ff-bba7-d5a2cb897e72");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "b98d48e7-b28f-457c-9234-1a42e7953b06");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "ec85758b-b4cb-48ad-861c-7dfbdd697b3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c12a362-f81b-4dc3-a655-8016da334ef5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4f508d1-2b96-4959-b2bd-de848903eee9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b8ffc9-068c-4f38-b937-53e9d117833f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a8aba74-977c-40c2-919e-d11a8b407cbe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "454329d5-c889-4247-a4d8-2519ff138fea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb074b8e-5b09-4fc1-8718-f426d91b2892");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0b251f0-76ec-4879-afdc-1730c201e01e");

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
    }
}
