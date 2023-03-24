using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.data.migrations
{
    public partial class RenamedEGNtoUCN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rooms_Number",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UCN",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4bf4cbd8-0e0d-401b-8877-a77f62dd4514", "35c13ede-e46f-4157-b461-e98e21b9ffe5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "42201e87-7678-4118-bdfd-8bfc358782af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "95d73d2e-c463-4322-8151-1de8629d5f8b", "35c13ede-e46f-4157-b461-e98e21b9ffe5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c3b9522b-040f-49fb-bff7-6c7120d5962a", "35c13ede-e46f-4157-b461-e98e21b9ffe5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c78ca057-4f8f-4898-9bac-09eca4a31d15", "35c13ede-e46f-4157-b461-e98e21b9ffe5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f1772de5-677f-4ba7-be75-a12c67428b5f", "35c13ede-e46f-4157-b461-e98e21b9ffe5" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "28709e6c-9fe1-499b-93a9-1555bcd71b27");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "66602531-b498-4949-bb33-e6bf804c97ec");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6ebb0ed8-abd6-4f4b-ab72-0ea64343b384");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "72851029-0e39-4afc-913f-baf98153b3a8");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "d4298615-697d-4a75-a481-4683d7f28034");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35c13ede-e46f-4157-b461-e98e21b9ffe5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42201e87-7678-4118-bdfd-8bfc358782af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4bf4cbd8-0e0d-401b-8877-a77f62dd4514");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95d73d2e-c463-4322-8151-1de8629d5f8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3b9522b-040f-49fb-bff7-6c7120d5962a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c78ca057-4f8f-4898-9bac-09eca4a31d15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1772de5-677f-4ba7-be75-a12c67428b5f");

            migrationBuilder.AlterColumn<string>(
                name: "UCN",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "735c9bdf-7979-4891-a8c7-57b20039f54c", "87c141d7-6260-4dd6-8293-31184ddd94ea", "Admin", "ADMIN" },
                    { "bf5ef909-e344-4383-a563-b09f259928a6", "b2a00ea8-5050-4d43-94ff-c84120c39705", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "d780548b-d4ec-4844-86cf-d0889f52a49c", new DateTime(2023, 3, 24, 21, 10, 43, 69, DateTimeKind.Local).AddTicks(9824), "AQAAAAEAACcQAAAAEEMYQBVBAF7ROMVZXAIKs1XeGaXWu/FALq/CeRwWZasI19DYO1xLNn87WqLjhIKwHw==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "af6d324c-f366-4c8e-8746-302aacfed1f3", 0, "021272dd-9229-442c-bafc-5a77ecf9bd31", "user0@abv.bg", true, null, "John", new DateTime(2023, 3, 24, 21, 10, 43, 76, DateTimeKind.Local).AddTicks(5978), true, "Johnson", false, null, "Jack", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEJssXhmbYrfE0sF1CaMyzRc6BAVodPgdZ+TQY0ShE3lnMT8IkbzrF7ltPuXpEuM4jA==", "001715", true, "", false, "006204", "user0@abv.bg" },
                    { "b7ba7229-d592-4b02-9d1d-37db54511f4d", 0, "33f24356-f09c-4e0b-bd3d-2f5b234b2bf8", "user1@abv.bg", true, null, "Alex", new DateTime(2023, 3, 24, 21, 10, 43, 85, DateTimeKind.Local).AddTicks(1905), true, "Johnson", false, null, "Alex", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEGi0Dj3N58qVnUaGmCeaAOgBaZ+dPLnBhCLRMpgJjfwZYcs2qXO2Keznw16QHQXR+Q==", "009673", true, "", false, "009695", "user1@abv.bg" },
                    { "1cdde740-25f6-41df-9d01-c00278f24c35", 0, "fcac4dc9-4aea-42dc-9ca2-47e77504c699", "user2@abv.bg", true, null, "Alex", new DateTime(2023, 3, 24, 21, 10, 43, 93, DateTimeKind.Local).AddTicks(1260), true, "Alexandrov", false, null, "Jack", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEMev3JIBsJ4qinSoOuSIX2iUDz4d9yxgOECivMNRBK0BQYeqU86DTz0iwyFEr2PTeg==", "004502", true, "", false, "005371", "user2@abv.bg" },
                    { "68d93d33-181e-4313-bc4d-6c264cce77d1", 0, "0b696888-c46f-4e6b-9c32-5019bd4b63d1", "user3@abv.bg", true, null, "Jack", new DateTime(2023, 3, 24, 21, 10, 43, 101, DateTimeKind.Local).AddTicks(3137), true, "Johnson", false, null, "John", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEAsGMO/V0fTHWMcHevm2aP6VhtYSJZd3bk0zfboERQ/BOHU7TQsAtTK/DaqeNd7x9Q==", "002768", true, "", false, "001100", "user3@abv.bg" },
                    { "92f2783e-baa7-46fa-8a0b-565ffb70b3d9", 0, "f758585f-e6b4-4d79-baff-2c05725fae95", "user4@abv.bg", true, null, "Alex", new DateTime(2023, 3, 24, 21, 10, 43, 109, DateTimeKind.Local).AddTicks(4019), true, "Johnson", false, null, "Alex", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEIatIzkBnMV+XiMd8mVVsTiDPPGnsCzoB8AebOHbJjzmKXT3hWWLAwKSqXmYqfcS4g==", "003676", true, "", false, "002372", "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "480b301b-e461-48ab-9741-c2e11b1e2df2", "customer0@abv.bg", "John", false, "Johnson", "739296", null },
                    { "0a825efc-5b41-4877-9f53-89c817683050", "customer1@abv.bg", "Alex", false, "Johnson", "936085", null },
                    { "fb5ee98f-bee2-4a8e-8bd8-5e75327f6e14", "customer2@abv.bg", "Jane", true, "Alexandrov", "754923", null },
                    { "94afd613-898b-4225-8e1f-5a5bce021517", "customer3@abv.bg", "Jane", false, "Alexandrov", "467388", null },
                    { "3196e2bf-e3e0-4daa-bf52-af12e22211ac", "customer4@abv.bg", "Jack", true, "Johnson", "787033", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "735c9bdf-7979-4891-a8c7-57b20039f54c" },
                    { "af6d324c-f366-4c8e-8746-302aacfed1f3", "bf5ef909-e344-4383-a563-b09f259928a6" },
                    { "b7ba7229-d592-4b02-9d1d-37db54511f4d", "bf5ef909-e344-4383-a563-b09f259928a6" },
                    { "1cdde740-25f6-41df-9d01-c00278f24c35", "bf5ef909-e344-4383-a563-b09f259928a6" },
                    { "68d93d33-181e-4313-bc4d-6c264cce77d1", "bf5ef909-e344-4383-a563-b09f259928a6" },
                    { "92f2783e-baa7-46fa-8a0b-565ffb70b3d9", "bf5ef909-e344-4383-a563-b09f259928a6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1cdde740-25f6-41df-9d01-c00278f24c35", "bf5ef909-e344-4383-a563-b09f259928a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "68d93d33-181e-4313-bc4d-6c264cce77d1", "bf5ef909-e344-4383-a563-b09f259928a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "735c9bdf-7979-4891-a8c7-57b20039f54c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "92f2783e-baa7-46fa-8a0b-565ffb70b3d9", "bf5ef909-e344-4383-a563-b09f259928a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "af6d324c-f366-4c8e-8746-302aacfed1f3", "bf5ef909-e344-4383-a563-b09f259928a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b7ba7229-d592-4b02-9d1d-37db54511f4d", "bf5ef909-e344-4383-a563-b09f259928a6" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "0a825efc-5b41-4877-9f53-89c817683050");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3196e2bf-e3e0-4daa-bf52-af12e22211ac");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "480b301b-e461-48ab-9741-c2e11b1e2df2");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "94afd613-898b-4225-8e1f-5a5bce021517");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "fb5ee98f-bee2-4a8e-8bd8-5e75327f6e14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "735c9bdf-7979-4891-a8c7-57b20039f54c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf5ef909-e344-4383-a563-b09f259928a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cdde740-25f6-41df-9d01-c00278f24c35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68d93d33-181e-4313-bc4d-6c264cce77d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92f2783e-baa7-46fa-8a0b-565ffb70b3d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af6d324c-f366-4c8e-8746-302aacfed1f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7ba7229-d592-4b02-9d1d-37db54511f4d");

            migrationBuilder.AlterColumn<string>(
                name: "UCN",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42201e87-7678-4118-bdfd-8bfc358782af", "940c2ea5-be08-4181-ba45-2510458d4f79", "Admin", "ADMIN" },
                    { "35c13ede-e46f-4157-b461-e98e21b9ffe5", "c90826e1-591a-41de-bc0c-ab4a1ba738ff", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash" },
                values: new object[] { "3d0ca4b3-c0c1-472d-b233-88bb5466e693", new DateTime(2023, 3, 24, 21, 9, 35, 822, DateTimeKind.Local).AddTicks(9263), "AQAAAAEAACcQAAAAENslwDvuG5XtHfTNQVmgqrSxG+uqE+j09rN9OBfLlUX0KnjZwEK1GoWvQf4wbGw84A==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "95d73d2e-c463-4322-8151-1de8629d5f8b", 0, "e944fd63-6a11-4b80-a3a4-63aabfdd5b0b", "user0@abv.bg", true, null, "Jane", new DateTime(2023, 3, 24, 21, 9, 35, 829, DateTimeKind.Local).AddTicks(1593), true, "Johnson", false, null, "Alex", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEALgr1vYmYqaBEXg+HClcTtWyG2Eoa9ywt/HNLaI4dV47qY4HuXBZDFSxOmlM6BkqQ==", "007515", true, "", false, "001873", "user0@abv.bg" },
                    { "4bf4cbd8-0e0d-401b-8877-a77f62dd4514", 0, "10808e5f-7085-42da-b63b-14dbeefaafbd", "user1@abv.bg", true, null, "Alex", new DateTime(2023, 3, 24, 21, 9, 35, 837, DateTimeKind.Local).AddTicks(6139), true, "Alexandrov", false, null, "Jane", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEEkg35gXZ0cNVNiK3C+lFx1qkR57uofDLiPJajs7Iz9N9XCnSRLGRJykHIIfmerevw==", "006030", true, "", false, "006721", "user1@abv.bg" },
                    { "c3b9522b-040f-49fb-bff7-6c7120d5962a", 0, "d9ee0476-6988-4cbd-8eb0-8546efa3c345", "user2@abv.bg", true, null, "Jane", new DateTime(2023, 3, 24, 21, 9, 35, 845, DateTimeKind.Local).AddTicks(8538), true, "Johnson", false, null, "Alex", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEM3X9+ZpNFEDV7sSVKyHFbUDxtQ/OV0GZ2ZccTRTHyNYqXa/PB4DOhqGfs2adQzIPw==", "007224", true, "", false, "002719", "user2@abv.bg" },
                    { "f1772de5-677f-4ba7-be75-a12c67428b5f", 0, "d5b44598-f555-4159-bd37-0e88c8278bf0", "user3@abv.bg", true, null, "Alex", new DateTime(2023, 3, 24, 21, 9, 35, 855, DateTimeKind.Local).AddTicks(906), true, "Johnson", false, null, "Jane", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEIUjy++qDAnq5hNfuyPuPocfQ9o7cYzFQGA/w4WjY68baNlIKsdZZNXfSLGaveBeUw==", "000116", true, "", false, "001788", "user3@abv.bg" },
                    { "c78ca057-4f8f-4898-9bac-09eca4a31d15", 0, "14fef854-3dec-49a8-a513-9ed6712b6baa", "user4@abv.bg", true, null, "Jack", new DateTime(2023, 3, 24, 21, 9, 35, 870, DateTimeKind.Local).AddTicks(886), true, "Alexandrov", false, null, "John", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEDJDSsApUzL+htX6eMHy9y3EHBD0hzlgz4JobvmTodpYJmBEVr7JXhd0FNAhvyoKdQ==", "008865", true, "", false, "003904", "user4@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "72851029-0e39-4afc-913f-baf98153b3a8", "customer0@abv.bg", "Alex", false, "Johnson", "394241", null },
                    { "28709e6c-9fe1-499b-93a9-1555bcd71b27", "customer1@abv.bg", "Jack", false, "Alexandrov", "353403", null },
                    { "66602531-b498-4949-bb33-e6bf804c97ec", "customer2@abv.bg", "Jack", true, "Alexandrov", "495018", null },
                    { "6ebb0ed8-abd6-4f4b-ab72-0ea64343b384", "customer3@abv.bg", "John", true, "Alexandrov", "031908", null },
                    { "d4298615-697d-4a75-a481-4683d7f28034", "customer4@abv.bg", "Jane", false, "Johnson", "867936", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "42201e87-7678-4118-bdfd-8bfc358782af" },
                    { "95d73d2e-c463-4322-8151-1de8629d5f8b", "35c13ede-e46f-4157-b461-e98e21b9ffe5" },
                    { "4bf4cbd8-0e0d-401b-8877-a77f62dd4514", "35c13ede-e46f-4157-b461-e98e21b9ffe5" },
                    { "c3b9522b-040f-49fb-bff7-6c7120d5962a", "35c13ede-e46f-4157-b461-e98e21b9ffe5" },
                    { "f1772de5-677f-4ba7-be75-a12c67428b5f", "35c13ede-e46f-4157-b461-e98e21b9ffe5" },
                    { "c78ca057-4f8f-4898-9bac-09eca4a31d15", "35c13ede-e46f-4157-b461-e98e21b9ffe5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Number",
                table: "Rooms",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UCN",
                table: "AspNetUsers",
                column: "UCN",
                unique: true,
                filter: "[UCN] IS NOT NULL");
        }
    }
}
