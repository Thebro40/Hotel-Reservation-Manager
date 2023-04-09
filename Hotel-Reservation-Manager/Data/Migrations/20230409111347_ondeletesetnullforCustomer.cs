using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class ondeletesetnullforCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerHistory_Customers_CustomerId",
                table: "CustomerHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers");

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

            //migrationBuilder.DeleteData(
            //    table: "Customers",
            //    keyColumn: "Id",
            //    keyValue: "30eec48d-0d0f-4fea-9dfd-344bad649cd2");

            //migrationBuilder.DeleteData(
            //    table: "Customers",
            //    keyColumn: "Id",
            //    keyValue: "5f1681cc-931f-4544-ae5c-708bde0baa4e");

            //migrationBuilder.DeleteData(
            //    table: "Customers",
            //    keyColumn: "Id",
            //    keyValue: "6d8a40aa-c270-4744-9474-aaed1fbbe932");

            //migrationBuilder.DeleteData(
            //    table: "Customers",
            //    keyColumn: "Id",
            //    keyValue: "78e36fb3-d523-4651-a7eb-c402411037af");

            //migrationBuilder.DeleteData(
            //    table: "Customers",
            //    keyColumn: "Id",
            //    keyValue: "8b42ba23-f43c-4e47-a335-f50ea1525cdc");

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
                    { "0e01e14b-3d25-4d19-bf0a-743ed10be274", "959be020-b7a5-4555-bc9e-fe2108eecc20", "User", "USER" },
                    { "8e98f200-6332-4bf9-aa8b-38b47f044ef2", "f68528da-d3f1-4e98-87ec-0547af38c78a", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445864-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "PhoneNumber" },
                values: new object[] { "81b7a277-7bc5-4fcc-a3df-fc8d73e7ffcf", new DateTime(2023, 4, 9, 14, 13, 45, 579, DateTimeKind.Local).AddTicks(1956), "AQAAAAEAACcQAAAAEHwSo5e8gw1UzY55Jk9PVDIOMexmaBLX+Tm9ifPSXnreUr1Fo2xEHU3qZINfUiJ3BQ==", "0123456789" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "e707708d-55ea-4f54-8e2b-82175347e25a", 0, "e4c1f7a2-7d53-4f75-8c44-4fde884243f6", "user98@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 46, 481, DateTimeKind.Local).AddTicks(86), true, "Brown", false, null, "Jane", "user98@abv.bg", "user98@abv.bg", "AQAAAAEAACcQAAAAEKp8PxcAPEtk6GnFSEwQd90WP7qdf1aTbWGT8yumQ49lapJ5J5Fa8b3Nj9XYQPgQMg==", "0000001839", true, "", false, "0000005629", "user98@abv.bg" },
                    { "2129a2b9-dfeb-4243-ade7-85a10bbecdcc", 0, "581dde07-6a5f-4dc6-beb3-c80c775d2124", "user26@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 45, 802, DateTimeKind.Local).AddTicks(7660), true, "Brown", false, null, "William", "user26@abv.bg", "user26@abv.bg", "AQAAAAEAACcQAAAAEIWzUs1NayfaiVNT8lcIgyzuoRJV7ikHl7I/dKZtkCB4bALX5VcAn57j0IAFdQsRfg==", "0000007592", true, "", false, "0000005774", "user26@abv.bg" },
                    { "8d3318b9-fb06-487b-a236-93e87a97f76a", 0, "b9ad979a-4507-4f11-bc72-35118656909c", "user27@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 45, 813, DateTimeKind.Local).AddTicks(5557), true, "Brown", false, null, "Jane", "user27@abv.bg", "user27@abv.bg", "AQAAAAEAACcQAAAAEF45VyLjZgwAQHc7SiWhcfpKB1t0rMG2BcI4bAtXVaF1CwVSh4arKe/639uNEpVslQ==", "0000004262", true, "", false, "0000008358", "user27@abv.bg" },
                    { "a1ea2176-b04b-48f8-a275-f9ab538516b0", 0, "e532fc75-549f-4bdf-acf7-d32b3601987e", "user28@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 823, DateTimeKind.Local).AddTicks(517), true, "Alexandrov", false, null, "William", "user28@abv.bg", "user28@abv.bg", "AQAAAAEAACcQAAAAEFsx0wzXrmsWl4hK6Pte45CVPNOFX9BWc2gSnYEYION7sfmveteYShzQ02nT1vHb2A==", "0000005473", true, "", false, "0000002190", "user28@abv.bg" },
                    { "41d2dbb0-0285-4e2f-b4d3-afc94a72578d", 0, "37856f36-4e05-46de-9256-cf70e914ece0", "user29@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 831, DateTimeKind.Local).AddTicks(8496), true, "Martinez", false, null, "John", "user29@abv.bg", "user29@abv.bg", "AQAAAAEAACcQAAAAEML8pefUXaLnKbisvy2Tmd/mSKPmHh6rxGivJ2nFj7kxZIOHk6tDdfB5ganrjv8Jkg==", "0000003260", true, "", false, "0000003897", "user29@abv.bg" },
                    { "da76f0a1-168e-40e6-a33d-ab335b0ccf71", 0, "94316b74-4b2f-4299-8bec-61e56255bfc5", "user30@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 840, DateTimeKind.Local).AddTicks(4205), true, "Johnson", false, null, "John", "user30@abv.bg", "user30@abv.bg", "AQAAAAEAACcQAAAAEJrUVgHcIN8W09YuuY48pyMYl527AIk3PuKOM4M187e/BxabQ2kldOG63nwtaYvz0g==", "0000000949", true, "", false, "0000008813", "user30@abv.bg" },
                    { "a0ad2200-7670-47e6-9f3c-f436ae3563ff", 0, "91fb3f20-b0f9-439a-87a6-70d67cd8b702", "user31@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 45, 848, DateTimeKind.Local).AddTicks(5125), true, "Brown", false, null, "Jack", "user31@abv.bg", "user31@abv.bg", "AQAAAAEAACcQAAAAEK64EdjOmUTKgf7fSG5u0BIuBF8uXea/UNa+QFOuaPO39LU1Ft0ofAH6DJ2FIqv82w==", "0000002937", true, "", false, "0000003609", "user31@abv.bg" },
                    { "98a47581-d326-49e8-bec3-7056c034182f", 0, "fc16eb37-ca81-4444-a897-b1d62e177d54", "user32@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 45, 857, DateTimeKind.Local).AddTicks(3566), true, "Alexandrov", false, null, "Alex", "user32@abv.bg", "user32@abv.bg", "AQAAAAEAACcQAAAAENObN/jt7L+RJ7/rsPPus3M+zqMUSF5/g1m0q9y9yxK7pJaRaa4Gzo9/Ec6nLWpDzg==", "0000008399", true, "", false, "0000009940", "user32@abv.bg" },
                    { "eca2c45d-31e7-4b79-96dd-394baf21895a", 0, "2d80c1d7-e15f-4721-a1fc-9aee91910192", "user33@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 865, DateTimeKind.Local).AddTicks(3338), true, "Alexandrov", false, null, "John", "user33@abv.bg", "user33@abv.bg", "AQAAAAEAACcQAAAAEOGyXb9Es7EpbQYc8LTyIrjyFPiZqA0LPRQ+xXW1pk+T2VCBVEVmq3TgA+pUT9rHcA==", "0000002825", true, "", false, "0000004434", "user33@abv.bg" },
                    { "d8c7791f-35bc-45b9-b020-5b27c1363b1f", 0, "46c3abeb-6e6b-4045-8cb7-384018ed0e70", "user34@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 874, DateTimeKind.Local).AddTicks(9754), true, "Alexandrov", false, null, "Jane", "user34@abv.bg", "user34@abv.bg", "AQAAAAEAACcQAAAAEM406P5zyNVhh8Z7oZkRV0N1LcTR4wzUR7K7kaFdGi4dUuW0UF0buMqj1DluTjNFDg==", "0000001169", true, "", false, "0000006636", "user34@abv.bg" },
                    { "9050225d-0eea-48eb-8434-ccb042c43aad", 0, "3ccc041f-5d50-485f-9c11-d1e4a5baf7a8", "user35@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 45, 883, DateTimeKind.Local).AddTicks(1741), true, "Alexandrov", false, null, "Jack", "user35@abv.bg", "user35@abv.bg", "AQAAAAEAACcQAAAAEEo4qtQOF7CGZg1JbiUCmTbw1doRCYD6cqtsqlW/YsWMCAVhOOuKS8yQgy1qVbGiNQ==", "0000008790", true, "", false, "0000005934", "user35@abv.bg" },
                    { "ab323867-387f-478b-a591-d667efdb92a4", 0, "d6ec3ece-5b51-4e85-afca-4ec949660b8e", "user36@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 45, 891, DateTimeKind.Local).AddTicks(8109), true, "Brown", false, null, "William", "user36@abv.bg", "user36@abv.bg", "AQAAAAEAACcQAAAAEEMimetc1VJpbhNKtEtH/mMR8NKd/jqU6HBME6tc5yn+Bs2BwkS0Az/jPNaEgx8HvQ==", "0000001271", true, "", false, "0000004522", "user36@abv.bg" },
                    { "b272ba75-66b6-46f1-8c04-541325d919ad", 0, "6cab23fd-bcdb-4f5c-b74e-ad0c3e996fb6", "user37@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 45, 899, DateTimeKind.Local).AddTicks(9753), true, "Alexandrov", false, null, "Jane", "user37@abv.bg", "user37@abv.bg", "AQAAAAEAACcQAAAAEPObGGgpipMSjYelovMhHwhn+C2Zbneeo4Hg+aPCMD+oteax8+/2MKhrbF4v9olMeQ==", "0000002004", true, "", false, "0000008375", "user37@abv.bg" },
                    { "46dcdc15-6363-4095-9072-dac0c65be206", 0, "bb3d33a2-48e5-44b9-9f07-267228b440e0", "user38@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 907, DateTimeKind.Local).AddTicks(8423), true, "Alexandrov", false, null, "William", "user38@abv.bg", "user38@abv.bg", "AQAAAAEAACcQAAAAENtB1oqFx01+Q96rf30P4FdfnqfFnsCADKtIO8s+zUYlvHJwIe9Fhw4QX3x908jxYQ==", "0000002890", true, "", false, "0000009192", "user38@abv.bg" },
                    { "7067c928-b2e6-4424-8294-f8394f0aac96", 0, "f621f6af-ff4a-4e9b-b932-4be1957176a2", "user39@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 916, DateTimeKind.Local).AddTicks(2127), true, "Alexandrov", false, null, "Alex", "user39@abv.bg", "user39@abv.bg", "AQAAAAEAACcQAAAAEGa01JEdTjIKUuoydWhPgPudNtpyTJIudU1v2T3IO+4H59ML/hnUm9aCInCowIQFEg==", "0000004823", true, "", false, "0000009043", "user39@abv.bg" },
                    { "385ec2af-562a-483b-9b86-1a17c874c94a", 0, "8c7121d2-0a68-4208-b881-0d9d801dc08b", "user40@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 924, DateTimeKind.Local).AddTicks(4029), true, "Alexandrov", false, null, "Michael", "user40@abv.bg", "user40@abv.bg", "AQAAAAEAACcQAAAAEKcqycpBxSvvAK/+L4PO1Cuam9qRsLO2oj9U1kDwRC43PIs0EQske2yEtuDc/FASFg==", "0000004825", true, "", false, "0000001064", "user40@abv.bg" },
                    { "fd48e2ed-4b93-401a-a837-2266bc15217d", 0, "06eae571-d1cb-479b-b85e-20636c7a4f2b", "user41@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 45, 932, DateTimeKind.Local).AddTicks(8229), true, "Brown", false, null, "William", "user41@abv.bg", "user41@abv.bg", "AQAAAAEAACcQAAAAEAqmrbb2miP18G5g6HOh/z0AnGNqST3SfzkX2EdCxAVIcVPJcQYBD+Sl2Mr6+1dTSA==", "0000006074", true, "", false, "0000006458", "user41@abv.bg" },
                    { "fd00b185-e3aa-442d-9479-cae2d87ca93d", 0, "bcbf97f8-82e8-47ed-b3dd-14742da348f9", "user42@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 45, 942, DateTimeKind.Local).AddTicks(3781), true, "Alexandrov", false, null, "Jack", "user42@abv.bg", "user42@abv.bg", "AQAAAAEAACcQAAAAEDuac2OW3Ex6jqNgzj6ZBuEpYRtLdUxa9gSDmnK/QsyC4mm6XbPbZqfITjB+yxKlow==", "0000004419", true, "", false, "0000007399", "user42@abv.bg" },
                    { "9d53cc64-f9e7-4870-8fe0-5b8a82149f45", 0, "1dc15d2e-5119-4dfd-8588-223eae4492c5", "user43@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 45, 953, DateTimeKind.Local).AddTicks(4144), true, "Johnson", false, null, "Michael", "user43@abv.bg", "user43@abv.bg", "AQAAAAEAACcQAAAAEArLwecCAyUIqIa3TmhOcJPzZVhS2IOTadnk1N7t5/nIeFcDIdzVFFty1W9n3iZ/Ew==", "0000006255", true, "", false, "0000000560", "user43@abv.bg" },
                    { "56e7770c-8597-4cd7-aa1a-50db7d27dd1e", 0, "af57e319-375f-47ba-bb4e-2fd23302ea6e", "user44@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 45, 962, DateTimeKind.Local).AddTicks(496), true, "Johnson", false, null, "Michael", "user44@abv.bg", "user44@abv.bg", "AQAAAAEAACcQAAAAEM5H8a4Cof5dm62+3d3sTWNqoXqnvdzWFiGmVLHzwrITpYz8HvNwJbUlg+evKcK2LQ==", "0000002801", true, "", false, "0000004248", "user44@abv.bg" },
                    { "7c52b729-a82d-4bbd-bfe4-8388146301dd", 0, "117fb6a8-0456-40f4-9b3d-8779b996d66d", "user45@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 45, 971, DateTimeKind.Local).AddTicks(8729), true, "Martinez", false, null, "Jane", "user45@abv.bg", "user45@abv.bg", "AQAAAAEAACcQAAAAEOhJDtukx5whzWeZmlt2b31Fm4ti8wols9Wa4D8FSIbBt7JnFB9kl5WENqH2brHQ7A==", "0000008482", true, "", false, "0000006229", "user45@abv.bg" },
                    { "404b3246-4911-4150-a4fe-e4617d9f74c6", 0, "4c41faaf-157c-43a2-b111-cf6a41a0ce52", "user46@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 982, DateTimeKind.Local).AddTicks(725), true, "Johnson", false, null, "Michael", "user46@abv.bg", "user46@abv.bg", "AQAAAAEAACcQAAAAEIxHuSu+LQ3qZbAkhBSAdByuoqXMhHwINv0xmmHYAfLIhNlmFt3j9KHEgoQzZ/Yc4w==", "0000001228", true, "", false, "0000004011", "user46@abv.bg" },
                    { "6abb04c0-3008-4c59-a204-6d897dbd2fac", 0, "33264940-af8a-4fda-8e00-36a4cbdef8ca", "user25@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 45, 794, DateTimeKind.Local).AddTicks(6944), true, "Alexandrov", false, null, "William", "user25@abv.bg", "user25@abv.bg", "AQAAAAEAACcQAAAAEM1EnlEpvkL4fLBMMhYX4YZHADVXLJQUPm2BHVqrmD47qAZ9ewj87cOupUAR8WcIJg==", "0000002338", true, "", false, "0000009915", "user25@abv.bg" },
                    { "fd295e2f-c614-4cfa-8eca-44ad283c267f", 0, "549f5b07-90c5-4b72-b5ed-40d1bbef7778", "user47@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 45, 992, DateTimeKind.Local).AddTicks(2049), true, "Brown", false, null, "Michael", "user47@abv.bg", "user47@abv.bg", "AQAAAAEAACcQAAAAECmTHXHL2pxYWWkBTXC4ZMNRlvkpCDr7xMrCQry7sSUQbwG5zj2QUSX5GgbhXfeb2w==", "0000001002", true, "", false, "0000004564", "user47@abv.bg" },
                    { "3dca359f-af82-42e3-8718-ab43a4dd7b79", 0, "b78d82ba-f36a-49a7-b458-fc9dd9ad55b6", "user24@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 45, 786, DateTimeKind.Local).AddTicks(449), true, "Johnson", false, null, "Michael", "user24@abv.bg", "user24@abv.bg", "AQAAAAEAACcQAAAAECrVXs9ZqXAsrnYvVA9mBRuBxc+Zj8QJuZus/uXRZGUJjkNYaxzblZ5oZF2pwGSQqg==", "0000008885", true, "", false, "0000003513", "user24@abv.bg" },
                    { "df5ccd52-add9-42e7-9e1d-784b78598096", 0, "e18a5515-59df-439b-a28c-f043136e7302", "user22@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 768, DateTimeKind.Local).AddTicks(7659), true, "Martinez", false, null, "Jane", "user22@abv.bg", "user22@abv.bg", "AQAAAAEAACcQAAAAEPbEHt6qRaZR1S3yVR/vxCsDFNsujaBbzQoDb4iJ+/UE7NSuxm5l69DK6h6gBEsevA==", "0000001315", true, "", false, "0000009170", "user22@abv.bg" },
                    { "5072a61a-0188-4e40-967b-9ff75ae717be", 0, "5c46b2d2-e5c0-47f3-b5f6-74425644f9f7", "user1@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 45, 592, DateTimeKind.Local).AddTicks(6623), true, "Brown", false, null, "Jane", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEGlWwwUA2KfZFhArWDCmJ/fVtotXJL1GfgBlroF8D6iBFvumQJxEOxda/apf0Sc1FQ==", "0000007555", true, "", false, "0000001290", "user1@abv.bg" },
                    { "35fd1ea3-31c9-4a9b-8b5e-9473e2c04884", 0, "3436bb6e-2fa6-46e3-9afe-4f083de625b6", "user2@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 45, 600, DateTimeKind.Local).AddTicks(6669), true, "Alexandrov", false, null, "Jack", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEI4lehI6FEKYUze66waJi2kCvfQ5BFX8QYgqfVk1GeiMv1l4m/sVLv82IovTnarkPQ==", "0000004418", true, "", false, "0000000248", "user2@abv.bg" },
                    { "48da6289-de5d-4f06-8aff-baf65636c7dc", 0, "4610317b-3c8b-4204-8808-b10634c64728", "user3@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 608, DateTimeKind.Local).AddTicks(3577), true, "Alexandrov", false, null, "John", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEEEjTA67yr14iqQ2ij6BtECBDzIT8SgGIZDbuGq0wuQC2LqF7FfttAoPH6io9QJbNQ==", "0000007646", true, "", false, "0000004859", "user3@abv.bg" },
                    { "874606d9-81e0-40b3-881e-6fac16fea67b", 0, "afa981ae-0618-4e08-9730-09ba3354faf1", "user4@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 616, DateTimeKind.Local).AddTicks(4877), true, "Johnson", false, null, "Jane", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEAZYE0+d3YcituT79krY1qjogpAh6UO+Y7Zz9UEKHcJYdHW9NBP1+mTb6QdjbCCVfA==", "0000005336", true, "", false, "0000009276", "user4@abv.bg" },
                    { "6ad6fb11-8a2f-4f76-a046-8254fc448d55", 0, "5f185586-f80e-4a20-afe5-294831ce017f", "user5@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 624, DateTimeKind.Local).AddTicks(6915), true, "Martinez", false, null, "William", "user5@abv.bg", "user5@abv.bg", "AQAAAAEAACcQAAAAEM+5tt1z885Cr57+qNqZ7zVqYCPX5PBtyMCQf4kkBIJrGTbit2Cs1mjv044k1OVKLw==", "0000003064", true, "", false, "0000005580", "user5@abv.bg" },
                    { "63405cc4-6af0-4d79-a2fe-f5e6a9a51525", 0, "5f7df6fa-b86f-4146-8347-1e2881a1e687", "user6@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 45, 633, DateTimeKind.Local).AddTicks(7007), true, "Johnson", false, null, "Michael", "user6@abv.bg", "user6@abv.bg", "AQAAAAEAACcQAAAAENcOFbfhnOYbHD4RLdJzH+vSFgbRlyz+XPyEwG/WtFp8YooSjMXo9I9277ARpWvB/Q==", "0000009762", true, "", false, "0000008772", "user6@abv.bg" },
                    { "4638e0d7-ef8b-496c-a390-a185b30e46dc", 0, "2e9acbd3-569c-4f89-9e76-0744e6f058ad", "user7@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 45, 641, DateTimeKind.Local).AddTicks(9880), true, "Alexandrov", false, null, "Michael", "user7@abv.bg", "user7@abv.bg", "AQAAAAEAACcQAAAAEKjKaVcUV55cLLKg2Ik3YT11D/YrN4TyHrbQsI//MRMONVKtrXdteuxvVvQmsK3U7Q==", "0000000088", true, "", false, "0000008147", "user7@abv.bg" },
                    { "24247e8a-45e8-4eb4-8c1d-81077220c038", 0, "d39c6a22-1c61-48e4-b1dd-86501d4b67c3", "user8@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 45, 650, DateTimeKind.Local).AddTicks(4634), true, "Martinez", false, null, "William", "user8@abv.bg", "user8@abv.bg", "AQAAAAEAACcQAAAAEP1/wwHIPcSG4KUtyz7qZAiWakMxgXV3bIEHzzityIKZWpFjmjAUn7RbU+49DONDUg==", "0000003896", true, "", false, "0000009210", "user8@abv.bg" },
                    { "e006dbe0-d775-4407-9f86-37e78fb13fe4", 0, "491ea24e-3a4c-4aa9-8997-fb70689e506d", "user9@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 45, 659, DateTimeKind.Local).AddTicks(2000), true, "Alexandrov", false, null, "Jane", "user9@abv.bg", "user9@abv.bg", "AQAAAAEAACcQAAAAELJenkV8KRRT5g42KtKUdj4TfPLLhA9sF/ww8hN1LJ9pejEybh5jhYZE/dpX/ByEWg==", "0000005366", true, "", false, "0000003744", "user9@abv.bg" },
                    { "d1ee338a-16c0-4018-9ed5-34def9a14e54", 0, "54f4e432-6016-45c9-835e-0e57e210f48f", "user10@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 45, 667, DateTimeKind.Local).AddTicks(9099), true, "Alexandrov", false, null, "Alex", "user10@abv.bg", "user10@abv.bg", "AQAAAAEAACcQAAAAEIAizBA0LM+F8nQcF0dmlIaaV+mXlYNSDfWNYafDGuQ14eZp8EFpaSr1oTk52ZQoIA==", "0000001544", true, "", false, "0000009742", "user10@abv.bg" },
                    { "0db92686-118f-4aa5-ad6a-ff73d86fd925", 0, "db2f72aa-75d7-41e9-9101-9e9edc37a0d1", "user11@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 675, DateTimeKind.Local).AddTicks(7573), true, "Alexandrov", false, null, "William", "user11@abv.bg", "user11@abv.bg", "AQAAAAEAACcQAAAAEPKSKueql8F0OR4FVCXORgJxmBNLE6bqLtmXTCU2g27jIslCw3RAzP2VRGlBhqCHhw==", "0000003499", true, "", false, "0000000458", "user11@abv.bg" },
                    { "9d783968-80e6-492b-9eda-1ba5740419b4", 0, "5e8408f8-65e9-48c5-bbd9-63c17cb335ef", "user12@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 45, 684, DateTimeKind.Local).AddTicks(8232), true, "Brown", false, null, "John", "user12@abv.bg", "user12@abv.bg", "AQAAAAEAACcQAAAAEAlAIKMpZv6TMoBc1Pl6aD1hBPXeSBNQZqcho9DIxOrBZp6FeCsggVvnJ4jQwjCEsw==", "0000000103", true, "", false, "0000001812", "user12@abv.bg" },
                    { "72ef17b2-faa3-43a8-b5f1-b461021750fa", 0, "3f2e3774-f2d2-4a29-9d11-59e783208ef9", "user13@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 45, 693, DateTimeKind.Local).AddTicks(4110), true, "Alexandrov", false, null, "John", "user13@abv.bg", "user13@abv.bg", "AQAAAAEAACcQAAAAECD/Xq3saQ9XSVYogqrH0ZNP/PPYw0W2WzOcTSnKpzhgztktJUIeWy8KKcNaRw3scw==", "0000006750", true, "", false, "0000007091", "user13@abv.bg" },
                    { "b7eff9a7-a9f1-4424-8802-c62a2b8ab476", 0, "6d0eda49-d5fe-4f7d-b4f5-2736c533ef55", "user14@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 45, 702, DateTimeKind.Local).AddTicks(2396), true, "Alexandrov", false, null, "Jack", "user14@abv.bg", "user14@abv.bg", "AQAAAAEAACcQAAAAEA2RQ0koDvLRhOyCY7aetAS21VH2lzQLnPRxCOYbuDJIkKFQZ1OSw6i3Gea/cPX1Jw==", "0000007301", true, "", false, "0000008880", "user14@abv.bg" },
                    { "ac5888be-d6e3-4306-95dd-d559122e195a", 0, "cf9c65fe-54fe-4b4c-b5cf-252285f6bfe2", "user15@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 710, DateTimeKind.Local).AddTicks(5896), true, "Johnson", false, null, "William", "user15@abv.bg", "user15@abv.bg", "AQAAAAEAACcQAAAAEA1i5bMQrAKyVVpCXo4xN1p6DZ//ZF+kOBedfo9rfkYaATQ+yrXwIIP8OzQ/PN1TxQ==", "0000005835", true, "", false, "0000003138", "user15@abv.bg" },
                    { "e93685d4-550c-4ae4-881b-acb050079fe8", 0, "25c835e7-10e2-45dc-bc9c-85e51551a4c1", "user16@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 718, DateTimeKind.Local).AddTicks(4172), true, "Martinez", false, null, "Michael", "user16@abv.bg", "user16@abv.bg", "AQAAAAEAACcQAAAAEDxCOV2tLI7+zux05LKPCUWoC491X1RnzG55pMvbEP+WD/xJUMDjfwA0/+aJ6b6MiQ==", "0000001059", true, "", false, "0000007173", "user16@abv.bg" },
                    { "24da5029-5c73-40c7-86b7-07033a3000e2", 0, "7d9ddd8e-560e-4cac-90ca-e50ddb614306", "user17@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 726, DateTimeKind.Local).AddTicks(3467), true, "Martinez", false, null, "Alex", "user17@abv.bg", "user17@abv.bg", "AQAAAAEAACcQAAAAEGkt6HycA9kOu+PjubGP7lEfEmRgxijzcTGiYHCc/Pt5ES4LyblRqqgvJIUPaUM5NQ==", "0000007294", true, "", false, "0000002277", "user17@abv.bg" },
                    { "2bd1371b-7d27-4d85-ab7c-7b3aa598fc4b", 0, "5cf9166b-24e1-47ac-a5b6-193320f241f4", "user18@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 45, 734, DateTimeKind.Local).AddTicks(7755), true, "Johnson", false, null, "William", "user18@abv.bg", "user18@abv.bg", "AQAAAAEAACcQAAAAEMzyuenKeVQh5prPnWrBe6yoIyGvRnlDHkKB9tZ9WNV0Lrk/RCMyrRb7WyY6+OWM2w==", "0000006414", true, "", false, "0000006589", "user18@abv.bg" },
                    { "038286d3-6500-469e-b236-48112c6e71f1", 0, "bdf0add5-9612-4d6d-ba27-9d0570f79c3a", "user19@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 743, DateTimeKind.Local).AddTicks(519), true, "Alexandrov", false, null, "Jack", "user19@abv.bg", "user19@abv.bg", "AQAAAAEAACcQAAAAED2/Nce/WxIbOhbR2C4gxt9Z/v/baLY+r1j4Kn/tBOxn5SqXSVRVcpPF0nWzTjF6EA==", "0000001053", true, "", false, "0000005605", "user19@abv.bg" },
                    { "ba32c404-c8f9-4c72-8681-56bc32b6aba7", 0, "2305e76f-c69b-4fce-9793-6d3af216357f", "user20@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 751, DateTimeKind.Local).AddTicks(625), true, "Johnson", false, null, "John", "user20@abv.bg", "user20@abv.bg", "AQAAAAEAACcQAAAAELWyig+NhrjpeNra62dL+JJUVfsoB6HUp9mWpk7itn/aTTqiPMl7P8N4zVuoj50Msw==", "0000007188", true, "", false, "0000000234", "user20@abv.bg" },
                    { "b23e2869-44fd-4ef1-b7fd-31e4058a8ab9", 0, "e7d9034f-9448-4894-a2b5-1510ae985f94", "user21@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 45, 759, DateTimeKind.Local).AddTicks(4567), true, "Johnson", false, null, "William", "user21@abv.bg", "user21@abv.bg", "AQAAAAEAACcQAAAAEPV9Bfgg3LCsxplAUahzReGIhFaVRuEsQNKpP/brS55lCd1w9Y4IjojX8m9Sqi5Mog==", "0000000954", true, "", false, "0000009158", "user21@abv.bg" },
                    { "b09f1445-7113-4130-b4cf-d900c7dab2c6", 0, "9aa0ebf6-8f1f-4fe2-93bd-94ffc5b4234d", "user23@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 45, 777, DateTimeKind.Local).AddTicks(6425), true, "Brown", false, null, "Alex", "user23@abv.bg", "user23@abv.bg", "AQAAAAEAACcQAAAAEDTyKYH39wqJHTLfBjpR/m9V9M+wlVDQw2Mwymq0+EqreF7bi4cVUgssOsH5CdqoGg==", "0000005526", true, "", false, "0000008592", "user23@abv.bg" },
                    { "20e7c27b-e5e9-4fdd-a785-360f9f717bb3", 0, "60dab468-7c0b-4126-a1c9-0081209c2f2c", "user48@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 46, 3, DateTimeKind.Local).AddTicks(468), true, "Martinez", false, null, "Alex", "user48@abv.bg", "user48@abv.bg", "AQAAAAEAACcQAAAAEHV3eIwKwJd1aYFbedRsoFvmNkR8qBG9DPMg5iJOKutkUZ29NufyPh4Fm0FA1DFAlQ==", "0000005740", true, "", false, "0000003551", "user48@abv.bg" },
                    { "b33825e9-d336-47a2-be16-23a4e924d273", 0, "9c807a96-04fa-49fc-bc9c-9d2c8cf2c2dc", "user49@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 46, 14, DateTimeKind.Local).AddTicks(2546), true, "Alexandrov", false, null, "Jack", "user49@abv.bg", "user49@abv.bg", "AQAAAAEAACcQAAAAEB55eg76QGh4qy3FmVpL80NatTtGUWueiqy3yun/kSS+VcH5BHnvCQm9t49PA4MeHQ==", "0000009652", true, "", false, "0000008288", "user49@abv.bg" },
                    { "41b55b0e-72fb-4507-9aa8-0efb35fd37c9", 0, "cf952875-b167-4d7e-a995-97d6d40b6691", "user0@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 45, 584, DateTimeKind.Local).AddTicks(7334), true, "Johnson", false, null, "John", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAELipKvLNUBooFNMiv1P4nuQafxWc88SKybeEODnRZTAkbo5Qht1EySdZsMl8qPSIbA==", "0000008855", true, "", false, "0000006278", "user0@abv.bg" },
                    { "8ca94615-66e8-42b1-83dd-73e2ab0a34ca", 0, "4a91a7ed-4e23-4ff7-a129-566f23983693", "user77@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 282, DateTimeKind.Local).AddTicks(2934), true, "Brown", false, null, "Jane", "user77@abv.bg", "user77@abv.bg", "AQAAAAEAACcQAAAAELeoGpmVryoU74FgHaCg8tVZ5mxLbAFM/gsnpU8nk61baxUR4GrZrK5ar2WOOK43rQ==", "0000000641", true, "", false, "0000000670", "user77@abv.bg" },
                    { "b02bfa7c-772c-45ca-bc79-5dde983e926a", 0, "32d7efa3-58e0-4e13-8e22-3a0d04ef817d", "user78@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 46, 292, DateTimeKind.Local).AddTicks(4028), true, "Alexandrov", false, null, "Alex", "user78@abv.bg", "user78@abv.bg", "AQAAAAEAACcQAAAAEN7FzFj9Mg3t3rNDcu+e3IGFRf49Ilo8OB18GE9VOcuaw0E5hmaM7w+ao2TSbo+RMw==", "0000008306", true, "", false, "0000006404", "user78@abv.bg" },
                    { "64cbd81d-50bc-4476-8cf5-27ee22e5b38b", 0, "5f4a1c50-7edf-4ff4-a902-dcbe2d4d101b", "user79@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 300, DateTimeKind.Local).AddTicks(8335), true, "Johnson", false, null, "Alex", "user79@abv.bg", "user79@abv.bg", "AQAAAAEAACcQAAAAELu84EALCXmXCtNZDMXt1E+5fKIEmIfhhe/9jUKzp/QfhoMXTrG9ELuaZB6BlExJ9w==", "0000005984", true, "", false, "0000009344", "user79@abv.bg" },
                    { "12702a9e-9dfd-4a83-bcf8-a4a352fc6b62", 0, "8040facb-a924-4d05-89be-8d370094442f", "user80@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 46, 309, DateTimeKind.Local).AddTicks(2026), true, "Martinez", false, null, "William", "user80@abv.bg", "user80@abv.bg", "AQAAAAEAACcQAAAAEElCtshNwdN7rgp//NJA0DXZLHmFn4VmuXjmYzkb1Clz4pyzYiI7wfaAHCVT03DkVg==", "0000006692", true, "", false, "0000007964", "user80@abv.bg" },
                    { "2825d052-b8df-47d9-bc58-499c4b2bf212", 0, "44795b39-b91f-46f6-bc60-df9210a46625", "user81@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 46, 318, DateTimeKind.Local).AddTicks(7160), true, "Martinez", false, null, "William", "user81@abv.bg", "user81@abv.bg", "AQAAAAEAACcQAAAAEPj2a5fJZm0u+YOhrqkzLd4eOm+9+DtHYZqM647ctm1GJtBzlS4v4X9OmX+nHSYaLg==", "0000002172", true, "", false, "0000003270", "user81@abv.bg" },
                    { "679a5e06-47ba-4943-be8d-619b2b615ea2", 0, "7a39f91f-ce6f-4bf2-a7bc-77733557db47", "user82@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 327, DateTimeKind.Local).AddTicks(4154), true, "Brown", false, null, "William", "user82@abv.bg", "user82@abv.bg", "AQAAAAEAACcQAAAAEAWBfmMjJk1EKbpY6gODeclKzuI67OdnoFKL6FCOMQ8TE9aUj1iKS0Zdjq6X5iNZvQ==", "0000004103", true, "", false, "0000006867", "user82@abv.bg" },
                    { "06b613a2-618a-47f2-bc2e-245eaeb57948", 0, "1638b33f-2e7f-46d9-a81a-743c527ff3c9", "user83@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 46, 336, DateTimeKind.Local).AddTicks(1573), true, "Brown", false, null, "John", "user83@abv.bg", "user83@abv.bg", "AQAAAAEAACcQAAAAEEKvvmyefm2ardptQkLlg7ieNtIlD0ePZWkXciO/gGH1DF7UJatz4zoSyD5EkEn2TQ==", "0000001402", true, "", false, "0000005961", "user83@abv.bg" },
                    { "f6aba4f1-0099-4ffc-b4a1-e1e55332e0f4", 0, "cba68e89-e255-4977-8804-93fefb792556", "user84@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 46, 344, DateTimeKind.Local).AddTicks(7698), true, "Brown", false, null, "John", "user84@abv.bg", "user84@abv.bg", "AQAAAAEAACcQAAAAEOM7SLId39FKyHyX62suJeROqhY6YTdz5MJnFuFjubpuhgxCvvOIr9fN8U8NEciGsA==", "0000008100", true, "", false, "0000003220", "user84@abv.bg" },
                    { "03d7f0af-94da-46f9-8953-ddd3f2912815", 0, "ed3eb285-77c1-4e5b-8901-55c87a21422a", "user85@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 354, DateTimeKind.Local).AddTicks(1295), true, "Brown", false, null, "Jack", "user85@abv.bg", "user85@abv.bg", "AQAAAAEAACcQAAAAEOnwG0UnoKRC87lQbaTiyfx145aBB58rcg2alj6wP/SV7voYbYdoK439hugF2TqMPQ==", "0000004286", true, "", false, "0000002720", "user85@abv.bg" },
                    { "91d8a0a5-e369-41d2-a00b-053cb26bf748", 0, "b8e80219-7029-4c15-a253-29617c02b5cf", "user86@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 46, 362, DateTimeKind.Local).AddTicks(5307), true, "Alexandrov", false, null, "Jane", "user86@abv.bg", "user86@abv.bg", "AQAAAAEAACcQAAAAEP5hsn2d/M3X7WuvAkiR/v9UsZdk6JCNaP5jvb6RXpgLevRT5MfkAgD3cmjKVEsDag==", "0000004142", true, "", false, "0000006914", "user86@abv.bg" },
                    { "1ba2c572-d545-44be-bc79-c994d66612fe", 0, "60769ff7-f6f7-41e8-91f6-bfa718e0a6a9", "user87@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 46, 378, DateTimeKind.Local).AddTicks(7805), true, "Johnson", false, null, "Jack", "user87@abv.bg", "user87@abv.bg", "AQAAAAEAACcQAAAAECmIGDAydkLb07DyMFCyzbTTFAcxFHPXIY0NE6yZ0leZfbigleCkOGmkJIJCcXHe+g==", "0000001918", true, "", false, "0000002196", "user87@abv.bg" },
                    { "862625e2-3122-45d3-a1b6-4f47cca4897a", 0, "2d7e6c45-31b0-4d9f-a2d0-7365068d4458", "user88@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 390, DateTimeKind.Local).AddTicks(3037), true, "Brown", false, null, "Michael", "user88@abv.bg", "user88@abv.bg", "AQAAAAEAACcQAAAAEP0UBl2O1jVlxCgv8KHlFCxxAvkLQoES7sY+w4kHvWCscdQ9FPYGY7+DtuCZg/ZYWA==", "0000002380", true, "", false, "0000001928", "user88@abv.bg" },
                    { "b86ff162-8694-43e0-ae9e-2f4fce1119d7", 0, "b960d624-c937-4996-aafc-90594b69db1e", "user89@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 46, 398, DateTimeKind.Local).AddTicks(9550), true, "Johnson", false, null, "Alex", "user89@abv.bg", "user89@abv.bg", "AQAAAAEAACcQAAAAEFd21SIUUbw6+O5h1poe+r7JC8f5uV2qiwtKQe7uvMz8IsBnWoPF1kAonZ9d6EKS0A==", "0000003269", true, "", false, "0000009516", "user89@abv.bg" },
                    { "213eb9d7-36fb-4e5b-83ee-60b81791c1c5", 0, "07f7a488-2c65-4c51-80e5-a58b9acc5061", "user90@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 407, DateTimeKind.Local).AddTicks(6373), true, "Brown", false, null, "Jane", "user90@abv.bg", "user90@abv.bg", "AQAAAAEAACcQAAAAELU1Lh5bGW9+BAMGvyCRIX1Zvmm8i8n+CYBtVWQyb9Xm5XRxaqn+iNqBvL2T2P2qIA==", "0000002551", true, "", false, "0000003814", "user90@abv.bg" },
                    { "5008c1e8-e54f-4de0-825e-1edf69f68e30", 0, "8033ecd1-29f2-4e73-a400-2c984e0dc36f", "user91@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 46, 416, DateTimeKind.Local).AddTicks(5107), true, "Johnson", false, null, "Michael", "user91@abv.bg", "user91@abv.bg", "AQAAAAEAACcQAAAAEC8mua6jgcM7+gmH0WpAu/bVuHav5kXDqRFkjL+0ozbQ2VdqvIZZiolMbcifJPoX4w==", "0000002378", true, "", false, "0000002866", "user91@abv.bg" },
                    { "e93ec1d2-860a-4e3d-ad5e-2598d1637b81", 0, "01627ea1-e9a7-4dc0-aef0-1914da7247e6", "user92@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 46, 425, DateTimeKind.Local).AddTicks(6688), true, "Johnson", false, null, "John", "user92@abv.bg", "user92@abv.bg", "AQAAAAEAACcQAAAAEIwUgFqP26I822zSZ5nU5x3B6yQFaXijB+arfR9ZtdVZd7e0+aTXIycYHUxX7MXwCw==", "0000003243", true, "", false, "0000007029", "user92@abv.bg" },
                    { "2de80c77-854e-4c44-98e6-9fffed4b1abc", 0, "18f56179-0fe2-4ccd-ad9e-d26119179412", "user93@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 46, 435, DateTimeKind.Local).AddTicks(9033), true, "Brown", false, null, "Alex", "user93@abv.bg", "user93@abv.bg", "AQAAAAEAACcQAAAAEDZ/mpa4pfizyRfwE5txGTf9dl4/kwuw8HRaGrGl4JgEGz5nS4BqbnzJdhjUD9GEaw==", "0000009892", true, "", false, "0000009831", "user93@abv.bg" },
                    { "2351a037-3c9a-4289-92d6-521aecaca0fd", 0, "64fddd88-8f4b-48bf-9545-1e1e7b6ed6e9", "user94@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 444, DateTimeKind.Local).AddTicks(4106), true, "Johnson", false, null, "Alex", "user94@abv.bg", "user94@abv.bg", "AQAAAAEAACcQAAAAEF3tD9uY2whH/h+SRRP+9A+55NDdVzBgfXm/c3cNkRyRRO1S4j8Ni9qtUwuPWl54OQ==", "0000009352", true, "", false, "0000009236", "user94@abv.bg" },
                    { "082951a3-d6c7-4089-bf00-235cc72a3eb5", 0, "eb245f9a-3c2b-44eb-ab56-29bf52f82619", "user95@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 46, 453, DateTimeKind.Local).AddTicks(7200), true, "Martinez", false, null, "Jane", "user95@abv.bg", "user95@abv.bg", "AQAAAAEAACcQAAAAEIToL20PEW6jwawOS/pXjwIGlK19LsLzqVRs7AB62EPnTlncB3J1esiSMWe1MOTCEA==", "0000009325", true, "", false, "0000000650", "user95@abv.bg" },
                    { "f09aceda-f3a5-43f9-9681-0f9164daf1cd", 0, "fc198ec0-0477-4f81-b3ef-a16438c66ade", "user96@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 46, 462, DateTimeKind.Local).AddTicks(1761), true, "Brown", false, null, "Alex", "user96@abv.bg", "user96@abv.bg", "AQAAAAEAACcQAAAAEGBQiFB8ElVGlMBr0pSZdTl7xfNT7eks8EqyMUlkF7o1Y0WECLk2hiJJ/PBvQLifMg==", "0000001459", true, "", false, "0000000501", "user96@abv.bg" },
                    { "2d285200-f79d-4bed-9e22-d38a18158689", 0, "ef74811c-a70a-48b3-ade3-ab2bc1046d40", "user97@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 46, 471, DateTimeKind.Local).AddTicks(6072), true, "Alexandrov", false, null, "Michael", "user97@abv.bg", "user97@abv.bg", "AQAAAAEAACcQAAAAEC/hJoi7PbPQheCvUoax72NoEtykNjur3IhXbwjCMJhsPjAHjUEULH1p3vUWvlu9tA==", "0000003783", true, "", false, "0000002086", "user97@abv.bg" },
                    { "80e9a736-3e85-46d3-b6d4-27b4b3eaf965", 0, "6f8d5712-749b-47f0-99b3-b1c6ecd5ac19", "user76@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 272, DateTimeKind.Local).AddTicks(3379), true, "Brown", false, null, "John", "user76@abv.bg", "user76@abv.bg", "AQAAAAEAACcQAAAAEKiZmYJ9MmTeCtxG+PKmDL1xRKQANb7Yydx/ah6jeRXBPDwQ2H2ro1IoFAAPJeGTKQ==", "0000002117", true, "", false, "0000003818", "user76@abv.bg" },
                    { "cbe647b9-31a4-47a5-ad56-af6a6d9bbfd3", 0, "3f86ef9c-bf79-467b-b46b-4008b16b57c4", "user75@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 46, 262, DateTimeKind.Local).AddTicks(5466), true, "Alexandrov", false, null, "William", "user75@abv.bg", "user75@abv.bg", "AQAAAAEAACcQAAAAEOhuCrr7KyJEPDw7dPICYqqv/XGfytcZKKRkmEeHfZVsQTG2pipi368v1vNlqrN5eg==", "0000006695", true, "", false, "0000005835", "user75@abv.bg" },
                    { "4de40bd8-9e75-49cc-b531-25b52e084b15", 0, "4e35806d-13c0-4f77-a5b7-b2998d4ad559", "user74@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 250, DateTimeKind.Local).AddTicks(9593), true, "Martinez", false, null, "Jack", "user74@abv.bg", "user74@abv.bg", "AQAAAAEAACcQAAAAEFcJslzACd4p44Ls1rvimyl/xHWS5sgQnQTQK8PT07bm9cY6PoU4P4iUx299t5Qz6g==", "0000001809", true, "", false, "0000006600", "user74@abv.bg" },
                    { "9322fce0-b592-446e-9eaf-638af8c71467", 0, "cacac6e2-4829-40f3-9f89-b2d5520620cb", "user73@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 241, DateTimeKind.Local).AddTicks(7003), true, "Brown", false, null, "Jack", "user73@abv.bg", "user73@abv.bg", "AQAAAAEAACcQAAAAECdEocF/MPVpPo5J5xePovyNc8JBkf9Z8z4NyPN0bY2GSj4XOS0txoXjQux6GOcyQQ==", "0000007172", true, "", false, "0000009607", "user73@abv.bg" },
                    { "4d5ca831-5a95-46c6-a77d-325b81f994fb", 0, "05caa214-82ce-49a5-a541-d340b19577bb", "user51@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 36, DateTimeKind.Local).AddTicks(6784), true, "Johnson", false, null, "Alex", "user51@abv.bg", "user51@abv.bg", "AQAAAAEAACcQAAAAEE5f1Fg/WMQkrlXSm1IWN+dx+Fr8NvYuqQMI0DeN5o6zYWqS6j0OcU8R2dSZtTepug==", "0000002245", true, "", false, "0000008152", "user51@abv.bg" },
                    { "8dea4423-582d-4bb0-bb5a-43770a836bbc", 0, "22d17d1c-8298-439c-9963-726c14d72300", "user52@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 46, 46, DateTimeKind.Local).AddTicks(695), true, "Johnson", false, null, "John", "user52@abv.bg", "user52@abv.bg", "AQAAAAEAACcQAAAAEOsaV347r/y/FSXZwUeOFeejA01wCLZT8orPpXh4n6mYT2PFKZcYzeo5JaYx4u0qmw==", "0000004376", true, "", false, "0000008755", "user52@abv.bg" },
                    { "5cd9a2ba-c1f7-46f7-aa35-668daab9e67f", 0, "fc25d650-aec9-4ef4-9cbe-97a9faf63df6", "user53@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 57, DateTimeKind.Local).AddTicks(5334), true, "Johnson", false, null, "Jack", "user53@abv.bg", "user53@abv.bg", "AQAAAAEAACcQAAAAELtyoKKTGEDJgVJEI2h6uYRPKxTnmqzRM7+SsgAk0y4TqfzwF6K590xdEcusCH2JFw==", "0000002061", true, "", false, "0000009803", "user53@abv.bg" },
                    { "15c271d8-7225-468b-b2b0-6e2823974543", 0, "1d24b928-169c-4d5f-9b59-dd1a4f91a443", "user54@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 46, 69, DateTimeKind.Local).AddTicks(7686), true, "Brown", false, null, "John", "user54@abv.bg", "user54@abv.bg", "AQAAAAEAACcQAAAAEEyNbgzCqXj2xC9bTonMmE+IpJw39vcfehMYI/8NsuqrANmj0HEoOQLFIJsnzBrzsQ==", "0000006026", true, "", false, "0000004566", "user54@abv.bg" },
                    { "8c73d9c0-5453-46a9-9746-9252cec73b7e", 0, "9a08fa7c-03da-4c34-832c-83fd3f4c7728", "user55@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 46, 82, DateTimeKind.Local).AddTicks(1872), true, "Martinez", false, null, "John", "user55@abv.bg", "user55@abv.bg", "AQAAAAEAACcQAAAAEJdO0wFcgrjUNdFrg7mkfE/vmJD+WAA9tSw9Ujc0CbSTU1OAeNotLmAoYhk8SQLECA==", "0000003481", true, "", false, "0000009180", "user55@abv.bg" },
                    { "f312c2cb-5444-466a-9541-cc10d157cf80", 0, "da659a77-7229-46bd-b58b-999e550b9583", "user56@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 46, 92, DateTimeKind.Local).AddTicks(1397), true, "Alexandrov", false, null, "William", "user56@abv.bg", "user56@abv.bg", "AQAAAAEAACcQAAAAEO+tBTdyBdOju2/BAhycxW2xAg+byKf7MrIW4Ih7aMXPhw+ab1Vw4RLq43ug3PVhTw==", "0000001821", true, "", false, "0000004180", "user56@abv.bg" },
                    { "8efd331c-927a-4b5e-a245-17bc5e177bfd", 0, "aa8b58ea-a8ea-4d0e-a323-84623aa2d202", "user57@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 46, 102, DateTimeKind.Local).AddTicks(3659), true, "Alexandrov", false, null, "John", "user57@abv.bg", "user57@abv.bg", "AQAAAAEAACcQAAAAENQBBJNgvKHdgmcq+FsFES+txbSIzeAuCZ0ItKmCOnYejCrZtl2laUxGYlG3WTs1Bg==", "0000004473", true, "", false, "0000003716", "user57@abv.bg" },
                    { "41d79197-dd2f-4b04-b5c4-fd446a11db42", 0, "a4e8e875-ede7-4812-bf59-0e3c2eb75152", "user58@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 46, 112, DateTimeKind.Local).AddTicks(4150), true, "Johnson", false, null, "John", "user58@abv.bg", "user58@abv.bg", "AQAAAAEAACcQAAAAEBsAVhEDFx9IJMSbddLwmNvnYgZ6+V453gIFeNTb/KFU3IuqcaEik1WesOq68GxIew==", "0000004342", true, "", false, "0000003406", "user58@abv.bg" },
                    { "d1f4a0bd-4195-4140-80de-8a3061963e53", 0, "856c5d65-9049-4194-87d1-7f88537681f6", "user59@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 46, 125, DateTimeKind.Local).AddTicks(2255), true, "Brown", false, null, "Jane", "user59@abv.bg", "user59@abv.bg", "AQAAAAEAACcQAAAAEFO9uu2Y+6aOQ0TYanA8xVffP7UC4aVk45psfhhTopCnl/Sj/yPJ0wGqD1d7mk78MQ==", "0000008579", true, "", false, "0000001420", "user59@abv.bg" },
                    { "f00ca476-a43e-4573-83c1-368a82495fa7", 0, "3ac8ecf4-249c-4dfe-898e-044cd88ece17", "user60@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 133, DateTimeKind.Local).AddTicks(7380), true, "Johnson", false, null, "William", "user60@abv.bg", "user60@abv.bg", "AQAAAAEAACcQAAAAELZm3oW3EOhPeNn/jT7kZCSydvfLMs8BTDgAbOk6ZbTiqNbsyxNGHfcfZNLSI0Kuyg==", "0000001053", true, "", false, "0000001866", "user60@abv.bg" },
                    { "ba280834-71e5-4c5c-921a-4ecc62912c25", 0, "4c84d8fd-dd7d-4d26-894c-0c937d08919c", "user99@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 46, 490, DateTimeKind.Local).AddTicks(3221), true, "Alexandrov", false, null, "William", "user99@abv.bg", "user99@abv.bg", "AQAAAAEAACcQAAAAEO/zaCF3IeT+Iyru5Y6utB94RR6J90Xa/l14CbBp+rgLsb4aXSXsvGSTYiQHRLx7aA==", "0000004194", true, "", false, "0000008115", "user99@abv.bg" },
                    { "3c79e282-037e-4ef8-8837-803d1d616d63", 0, "7d3a74c6-8833-4309-a7ef-dae34a988896", "user61@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 46, 142, DateTimeKind.Local).AddTicks(2524), true, "Johnson", false, null, "John", "user61@abv.bg", "user61@abv.bg", "AQAAAAEAACcQAAAAEJSdNYQhQigTJjp+EV5QkyHy8ZoqZUP5f0rnu86uWNJd1+UEbIjNwX/YeXIhTk7drw==", "0000001081", true, "", false, "0000002474", "user61@abv.bg" },
                    { "2b5d59b4-b58e-425f-85cd-055d1d19b1a0", 0, "bb761456-e375-417c-bd58-eaf848406ba1", "user63@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 158, DateTimeKind.Local).AddTicks(5254), true, "Martinez", false, null, "Jack", "user63@abv.bg", "user63@abv.bg", "AQAAAAEAACcQAAAAEGZjQdeHxF1yZ64d89NmchlD4MsJQnXpDGGBJAnn09jRLc51Oqbi04CkkxAqdYr1YA==", "0000006217", true, "", false, "0000007373", "user63@abv.bg" },
                    { "bffa2008-b90f-4f06-8618-80dd2ad1b7eb", 0, "b8b2f186-3bcd-4dd0-9314-5e30e94f9ae0", "user64@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 46, 166, DateTimeKind.Local).AddTicks(7191), true, "Johnson", false, null, "John", "user64@abv.bg", "user64@abv.bg", "AQAAAAEAACcQAAAAEJGtQMhwaIJ41jroR8x5hxMk5WcYLT/65pkgeM13Uo8BCNJqPjllDxG7/n0cFg+WFA==", "0000009998", true, "", false, "0000006991", "user64@abv.bg" },
                    { "c6b35e10-a2e5-4dd0-94a1-f16c3f1f1cbd", 0, "8b79beaa-41f2-4db6-9d77-5c96273e7ce9", "user65@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 175, DateTimeKind.Local).AddTicks(3478), true, "Brown", false, null, "Jack", "user65@abv.bg", "user65@abv.bg", "AQAAAAEAACcQAAAAEG58G+wja8SS8oIUX1hGqZzdTUmOmXfUqWDGaBF1pXF/wkTQn3f4ALqpfWHfUhD//A==", "0000004188", true, "", false, "0000008193", "user65@abv.bg" },
                    { "3b981167-3f08-418a-8054-e9181e075e8f", 0, "3e7b0769-c698-4630-85fb-3dc35dae6893", "user66@abv.bg", true, null, "Alex", new DateTime(2023, 4, 9, 14, 13, 46, 183, DateTimeKind.Local).AddTicks(2821), true, "Brown", false, null, "Jane", "user66@abv.bg", "user66@abv.bg", "AQAAAAEAACcQAAAAEHv6Pvh9GjJ2uA98UBSwbtaa7tnSNLWOWzOvf3+gCSpluvTh9ID0xwRz6/2/Vx7NaA==", "0000000682", true, "", false, "0000002578", "user66@abv.bg" },
                    { "d805da1c-3fda-49aa-8050-97e6e515b3bc", 0, "ef978619-2269-4642-bf5d-f48cfd97106a", "user67@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 46, 191, DateTimeKind.Local).AddTicks(1027), true, "Johnson", false, null, "William", "user67@abv.bg", "user67@abv.bg", "AQAAAAEAACcQAAAAECZWspqSvYX/31QU+ALo3kPcmGXNRWzBvvjpCyYkuQDZK+kmifZ74+zlVT+6yxpodg==", "0000002859", true, "", false, "0000009437", "user67@abv.bg" },
                    { "b57ba01f-08ec-4fa6-8d36-64972a53f0cb", 0, "dbae770b-3d20-479a-8e9f-893f86c1f405", "user68@abv.bg", true, null, "Jack", new DateTime(2023, 4, 9, 14, 13, 46, 200, DateTimeKind.Local).AddTicks(3128), true, "Martinez", false, null, "Jane", "user68@abv.bg", "user68@abv.bg", "AQAAAAEAACcQAAAAELVn2fh+EXcHg5NELaiLNubBM2W2jkjt0EpqXV72etie3kFteaVGXegQtoO/+gV+7g==", "0000001162", true, "", false, "0000002514", "user68@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "567dafee-3715-42d4-bcb9-26acb1990871", 0, "2b699a39-f9ab-44f9-874d-def319157377", "user69@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 208, DateTimeKind.Local).AddTicks(3464), true, "Martinez", false, null, "Michael", "user69@abv.bg", "user69@abv.bg", "AQAAAAEAACcQAAAAEBqP1aTd2sYfBH0+Cuq77GQa6L0OBPMYaIBnNFlx1ZZbTEVk0/j5EOmj8eiE2FA4XA==", "0000004092", true, "", false, "0000005006", "user69@abv.bg" },
                    { "5aef87e7-d892-49a7-8250-6c174b3eec38", 0, "32090cf9-596d-4d4f-b763-1a829c2cc542", "user70@abv.bg", true, null, "Jane", new DateTime(2023, 4, 9, 14, 13, 46, 216, DateTimeKind.Local).AddTicks(5416), true, "Johnson", false, null, "Michael", "user70@abv.bg", "user70@abv.bg", "AQAAAAEAACcQAAAAEFm/wD3RFMA1sIbY5bULF1C/0pMsH/MTbUn+fJEwKmxDp6w06/ZvWHP9NvuB3dbf4w==", "0000000146", true, "", false, "0000000675", "user70@abv.bg" },
                    { "0a42a68e-daa3-4dc4-9994-c0db945027d6", 0, "0bfa625e-62ba-4075-b695-718dc6cac9c5", "user71@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 46, 224, DateTimeKind.Local).AddTicks(7648), true, "Johnson", false, null, "John", "user71@abv.bg", "user71@abv.bg", "AQAAAAEAACcQAAAAEBxFA56AbTBXo9OfYTMvM6W/M7w79F2qW+ACg55ql9rb+BuEa0G1Yc6monWxWvS5Zg==", "0000004636", true, "", false, "0000000858", "user71@abv.bg" },
                    { "c2480e50-fe0f-4605-ad71-abf5d2bc5652", 0, "2bd12143-8c74-476c-a086-1b39bd7c52a3", "user72@abv.bg", true, null, "Michael", new DateTime(2023, 4, 9, 14, 13, 46, 233, DateTimeKind.Local).AddTicks(3284), true, "Johnson", false, null, "Alex", "user72@abv.bg", "user72@abv.bg", "AQAAAAEAACcQAAAAEASr/zkrVT0XWKKIaO8YVqw5xvUQIdB/phfnRQW74Oda3VlEFPgG95WNLIlOsLXymA==", "0000009985", true, "", false, "0000005145", "user72@abv.bg" },
                    { "0d9847ec-e72c-4ec2-8b1a-a7d8593442f5", 0, "f1a85434-e0d9-4828-b37c-5b1f75b8e032", "user62@abv.bg", true, null, "John", new DateTime(2023, 4, 9, 14, 13, 46, 150, DateTimeKind.Local).AddTicks(7117), true, "Martinez", false, null, "Jack", "user62@abv.bg", "user62@abv.bg", "AQAAAAEAACcQAAAAELyHEFLftnkH3CHUGYYacBa3OgnwZ0MS4UN1gU/xaYSE6CuhUMbnVOiFDQUg6fM5Qg==", "0000000196", true, "", false, "0000008017", "user62@abv.bg" },
                    { "8c93b03f-d461-4abc-9af2-474308c7b4be", 0, "0d473934-6c02-4758-8d13-a5c97611f5b6", "user50@abv.bg", true, null, "William", new DateTime(2023, 4, 9, 14, 13, 46, 25, DateTimeKind.Local).AddTicks(1034), true, "Johnson", false, null, "Michael", "user50@abv.bg", "user50@abv.bg", "AQAAAAEAACcQAAAAEGNOWpQilddpGUcbWlh7Pco1oNf3YUWwW2m/ngOgmgjAp2hxtGmDwIarSPw2/tATNw==", "0000000741", true, "", false, "0000002737", "user50@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsAdult", "LastName", "PhoneNumber", "ReservationId" },
                values: new object[,]
                {
                    { "17d7e2ac-f65f-42f6-b536-2d115c94cbef", "customer0@abv.bg", "John", false, "Alexandrov", "0000369132", null },
                    { "1fe88426-a706-477d-8dd2-ca98bc36b388", "customer56@abv.bg", "Jack", false, "Alexandrov", "0000273229", null },
                    { "af2ce2b9-74d5-405a-bebe-4c2290b5f24f", "customer41@abv.bg", "Michael", false, "Brown", "0000492117", null },
                    { "8b8d140e-9ff5-40f9-9202-4f65e92f5c78", "customer42@abv.bg", "William", false, "Johnson", "0000101014", null },
                    { "a7b6e0a9-9b54-43f2-86f2-e3da84f8d7d8", "customer43@abv.bg", "Jack", false, "Alexandrov", "0000764216", null },
                    { "beb4694d-2823-47a6-bc57-be782010ed42", "customer44@abv.bg", "William", true, "Johnson", "0000967749", null },
                    { "9cec7c63-4bb6-462e-badf-96f644bef0ba", "customer45@abv.bg", "William", false, "Johnson", "0000424094", null },
                    { "9b9d08b6-19a3-4223-8c1b-801fe1700a3a", "customer46@abv.bg", "William", false, "Brown", "0000311194", null },
                    { "4e296d48-f222-4ab9-bf1c-cdefcb78d0b3", "customer47@abv.bg", "Alex", true, "Alexandrov", "0000364796", null },
                    { "1a8934fa-9301-49dd-8140-e3bb2e382d29", "customer48@abv.bg", "John", false, "Martinez", "0000580917", null },
                    { "01896e30-7887-4382-a097-5c079581bfa9", "customer49@abv.bg", "William", true, "Johnson", "0000548193", null },
                    { "680a2156-dcd7-40a2-abb2-2e6aaedd1bd8", "customer50@abv.bg", "Jack", true, "Johnson", "0000971674", null },
                    { "e16dd06f-da1d-45cc-a7de-3ead0e87015a", "customer51@abv.bg", "Jane", false, "Alexandrov", "0000608031", null },
                    { "86b31582-6802-4c96-81c9-74f2d4189f35", "customer52@abv.bg", "John", true, "Brown", "0000775466", null },
                    { "259b5d40-c083-4da5-bfc8-5b66951ce305", "customer53@abv.bg", "Alex", false, "Brown", "0000332014", null },
                    { "83bedbf5-efdf-4820-8ff9-d5271c0ec21e", "customer54@abv.bg", "John", false, "Alexandrov", "0000058581", null },
                    { "dcd8503c-f86f-4c7f-85d5-7545dc9a087b", "customer55@abv.bg", "Jane", false, "Alexandrov", "0000123543", null },
                    { "b6cc5610-6f8d-4615-b218-c61793de8ba9", "customer13@abv.bg", "Michael", false, "Alexandrov", "0000566409", null },
                    { "8dc692bc-b1df-4c18-ad43-2f579f49a83b", "customer57@abv.bg", "William", false, "Martinez", "0000812409", null },
                    { "33cffdc6-869d-4fb9-afd3-c5693ae9918b", "customer58@abv.bg", "Jane", true, "Brown", "0000346372", null },
                    { "71a3385a-41f5-42d2-8757-d09cfdf14efb", "customer59@abv.bg", "Michael", false, "Brown", "0000780316", null },
                    { "bddaf49a-e3df-4953-8664-d452b1e11bfa", "customer60@abv.bg", "Michael", false, "Johnson", "0000629009", null },
                    { "e0cc7f1b-f719-462f-a896-6196f8018c04", "customer61@abv.bg", "Jack", true, "Martinez", "0000369641", null },
                    { "8c363b03-43e2-4e2e-91d8-e7a5b4ded5aa", "customer40@abv.bg", "Jane", false, "Johnson", "0000656872", null },
                    { "8c39b228-aa13-459e-814e-88ca0b38fd1d", "customer62@abv.bg", "Michael", false, "Alexandrov", "0000142006", null },
                    { "d14faee4-0585-437e-82cf-38a90f5fda1a", "customer39@abv.bg", "Jack", true, "Johnson", "0000168584", null },
                    { "7730570e-b19a-4b87-834a-188f636f7de6", "customer37@abv.bg", "William", false, "Johnson", "0000738438", null },
                    { "60b22e31-93cd-4821-8e1d-a1f5290b7464", "customer16@abv.bg", "John", false, "Alexandrov", "0000535166", null },
                    { "420789a5-d876-4975-a5a2-a8553537d07e", "customer17@abv.bg", "William", true, "Alexandrov", "0000823412", null },
                    { "0b71220c-1162-449e-bdfa-e5403f15c3c3", "customer18@abv.bg", "William", true, "Alexandrov", "0000158554", null },
                    { "4164ae64-f615-4b6c-8268-3dea4a157295", "customer19@abv.bg", "Alex", true, "Johnson", "0000974867", null },
                    { "b40342df-c7c9-43b5-b412-cdddf3d8f42b", "customer20@abv.bg", "John", true, "Brown", "0000280901", null },
                    { "4c9241ad-e3dd-4fbf-b7d5-5e3d9a388dbd", "customer21@abv.bg", "Jane", false, "Alexandrov", "0000971832", null },
                    { "b16d8da4-652b-42c4-ad9f-c6ff6bf20090", "customer22@abv.bg", "John", false, "Brown", "0000407308", null },
                    { "23d781ba-8448-437b-819e-2d375d890250", "customer23@abv.bg", "Jane", true, "Alexandrov", "0000584211", null },
                    { "7d925ba8-a0db-498f-a853-23b0c01f4036", "customer24@abv.bg", "John", true, "Brown", "0000808655", null },
                    { "3adc44fb-b0f3-4341-be3c-8060a6c92723", "customer25@abv.bg", "William", false, "Alexandrov", "0000210462", null },
                    { "5192e028-a60f-4640-9257-b8b1baae0a27", "customer26@abv.bg", "Michael", false, "Brown", "0000595609", null },
                    { "96421790-af60-4b13-bacd-4c53062d0a52", "customer27@abv.bg", "John", false, "Brown", "0000773079", null },
                    { "dfd0d5d8-cd1e-4515-a727-2c798e3c5a45", "customer28@abv.bg", "Jane", true, "Alexandrov", "0000730477", null },
                    { "ccf43d56-3c35-4c3f-b159-87e8d8de6c3d", "customer29@abv.bg", "Michael", true, "Martinez", "0000391703", null },
                    { "1be89763-5fb1-4d5f-85b1-72617f4a5e9f", "customer30@abv.bg", "Jane", false, "Johnson", "0000994798", null },
                    { "f2f07afd-651c-4e5f-b3ed-448a2836ab58", "customer31@abv.bg", "William", true, "Alexandrov", "0000967267", null },
                    { "14af96f2-909e-476a-90de-9c45c798f729", "customer32@abv.bg", "Michael", false, "Alexandrov", "0000498302", null },
                    { "8ec5793d-9fce-47c2-ba3d-dd337b711332", "customer33@abv.bg", "Michael", true, "Martinez", "0000707653", null },
                    { "4b51d0c5-2fb6-49d3-a612-786b80d0977c", "customer34@abv.bg", "William", true, "Martinez", "0000788795", null },
                    { "8149a1ff-b61d-4aff-9c14-52a090992fb0", "customer35@abv.bg", "Jack", true, "Martinez", "0000865744", null },
                    { "30266e9d-a19a-4b54-a5c7-c0a8536cb421", "customer36@abv.bg", "John", false, "Johnson", "0000667398", null },
                    { "945a5dbd-aaad-459e-929b-6f17c86a9b2b", "customer38@abv.bg", "Jane", true, "Johnson", "0000374696", null },
                    { "4a00b39f-80aa-4ea5-acfd-e36619126229", "customer15@abv.bg", "William", false, "Alexandrov", "0000540186", null },
                    { "6c684772-2d91-4587-974d-13268153f199", "customer63@abv.bg", "William", false, "Alexandrov", "0000997940", null },
                    { "f0163094-4daa-4e2b-9893-f21a6285b02e", "customer65@abv.bg", "William", false, "Martinez", "0000220734", null },
                    { "9dbabd2b-2ee9-4a3a-beec-c423aee0f295", "customer91@abv.bg", "John", false, "Johnson", "0000581232", null },
                    { "61ca664b-b99c-4119-82fc-19b94e452041", "customer92@abv.bg", "Alex", true, "Johnson", "0000118309", null },
                    { "46a34f6e-ebd2-41e5-b371-d0257d9d0a83", "customer93@abv.bg", "Jane", false, "Johnson", "0000320622", null },
                    { "d7db312e-1f1e-477d-baa4-1a57929f853d", "customer94@abv.bg", "Jack", false, "Brown", "0000265817", null },
                    { "6f50ebec-ff26-49b9-b3a3-500a9fd4ae2a", "customer95@abv.bg", "Michael", true, "Martinez", "0000013474", null },
                    { "f89320fa-9722-4952-8934-236f09fe4ae2", "customer96@abv.bg", "William", false, "Martinez", "0000076354", null },
                    { "3020977b-444c-4521-a357-2b17c11b70e0", "customer97@abv.bg", "Michael", false, "Alexandrov", "0000829317", null },
                    { "a8cae39f-89a8-4265-a323-537058221329", "customer98@abv.bg", "John", true, "Martinez", "0000384677", null },
                    { "76ba56aa-8fc8-4810-b9bb-c7099a74235e", "customer99@abv.bg", "Michael", false, "Martinez", "0000473257", null },
                    { "4e189a4b-b35d-44f7-ac56-ba0714c550a4", "customer12@abv.bg", "William", false, "Johnson", "0000346260", null },
                    { "228885ae-2a65-4df7-bee8-0438c6dbcf78", "customer11@abv.bg", "Jack", true, "Brown", "0000643716", null },
                    { "e61b81a9-9a2e-4e7b-8838-8f06de7b0e69", "customer10@abv.bg", "John", false, "Brown", "0000461759", null },
                    { "fb0dfa5a-e093-4954-b887-38f057c48010", "customer9@abv.bg", "William", false, "Alexandrov", "0000374338", null },
                    { "002d0f99-8a68-483b-b5bb-86b28eead710", "customer8@abv.bg", "William", false, "Brown", "0000663400", null },
                    { "3fa61417-d6bb-4bc1-8023-b58bf58559d3", "customer7@abv.bg", "Alex", true, "Alexandrov", "0000146240", null },
                    { "620841b3-f20b-4b53-b66b-adbf21214f72", "customer6@abv.bg", "William", false, "Martinez", "0000416477", null },
                    { "f1adc53f-3db7-4c04-a631-e280bd92a4c4", "customer5@abv.bg", "Michael", false, "Johnson", "0000498375", null },
                    { "a316347b-cb6c-4454-8127-cdf1caa8b63c", "customer4@abv.bg", "William", false, "Brown", "0000264535", null },
                    { "ad9e152d-27fd-4859-939f-2daa6d742d40", "customer3@abv.bg", "Jack", true, "Brown", "0000428785", null },
                    { "2e81b0a1-4f9b-45ce-a1fd-ead53b8923af", "customer2@abv.bg", "Jack", true, "Brown", "0000670377", null },
                    { "a2aad56a-03ce-488c-a585-b991c5897d6e", "customer1@abv.bg", "William", false, "Alexandrov", "0000954295", null },
                    { "7b15e98a-c858-467a-aacb-0f01216de3d6", "customer90@abv.bg", "Michael", true, "Johnson", "0000318758", null },
                    { "6f2f53d8-2ec4-40a7-ae34-857e9f7fe1a9", "customer64@abv.bg", "Alex", true, "Martinez", "0000105782", null },
                    { "c2e25f3f-7444-4010-986d-942101bae393", "customer89@abv.bg", "Alex", true, "Martinez", "0000391495", null },
                    { "9b3222f0-70d1-40ff-8eed-b4dbde879f3a", "customer87@abv.bg", "Alex", false, "Alexandrov", "0000892532", null },
                    { "e8e65c53-de56-4c33-ab7d-eba319780a93", "customer66@abv.bg", "Jack", true, "Martinez", "0000871656", null },
                    { "232f6a59-e614-437b-9152-aed62f65204c", "customer67@abv.bg", "William", true, "Martinez", "0000364850", null },
                    { "06895b4d-17e8-478a-9ab9-7bbbd0131ce1", "customer68@abv.bg", "Jack", true, "Johnson", "0000503857", null },
                    { "a021d8c1-f638-4fa3-a2ff-ca7a5a61b894", "customer69@abv.bg", "Jack", false, "Alexandrov", "0000722669", null },
                    { "35b575f2-c1a5-472b-ba00-34947ff18a75", "customer70@abv.bg", "Jack", false, "Martinez", "0000599031", null },
                    { "79eb93a3-e688-41ff-a6c0-3449d427b88a", "customer71@abv.bg", "John", true, "Brown", "0000522971", null },
                    { "e74de9a0-28ea-40ac-ba92-8c92be1f659d", "customer72@abv.bg", "Alex", false, "Martinez", "0000174959", null },
                    { "aabf13a5-b2df-477b-a44f-6c316dac0c54", "customer73@abv.bg", "Alex", false, "Brown", "0000716213", null },
                    { "80ded51f-a845-41a1-843b-02694788aaea", "customer74@abv.bg", "Jack", false, "Alexandrov", "0000044238", null },
                    { "b2786f57-4e86-4e1a-b868-d32655faae38", "customer75@abv.bg", "John", true, "Alexandrov", "0000515026", null },
                    { "dbc438c6-dd67-40c9-b02f-16b6679c46ca", "customer76@abv.bg", "Alex", false, "Martinez", "0000597060", null },
                    { "cb85c5c5-8aea-480b-a897-6686ded78d5f", "customer77@abv.bg", "Alex", true, "Martinez", "0000369335", null },
                    { "d379181d-4916-403c-a3b5-892252f7163c", "customer78@abv.bg", "Alex", false, "Brown", "0000342705", null },
                    { "95a01234-5be6-48a6-956f-09a70bd318bf", "customer79@abv.bg", "William", false, "Johnson", "0000110804", null },
                    { "d5f964a6-5f16-4edc-a9cd-f804b0f93f65", "customer80@abv.bg", "William", false, "Alexandrov", "0000625511", null },
                    { "56687101-ebc7-487d-bb8c-6be7f9d72e47", "customer81@abv.bg", "Alex", true, "Martinez", "0000957056", null },
                    { "6e6d1f53-3e3b-4814-84ca-2a959ec89937", "customer82@abv.bg", "William", false, "Alexandrov", "0000918405", null },
                    { "5627cf54-1e6a-4ce8-bb82-e4f396aed246", "customer83@abv.bg", "John", false, "Martinez", "0000908527", null },
                    { "f226c1d2-ed5b-4f00-9fe9-6d1c7b025775", "customer84@abv.bg", "William", false, "Johnson", "0000146271", null },
                    { "889bf973-d989-4b20-9413-c33f82f5b581", "customer85@abv.bg", "Michael", true, "Alexandrov", "0000113011", null },
                    { "9b2bce92-690a-4d15-98d2-ddc9c9e35a4d", "customer86@abv.bg", "Jack", false, "Alexandrov", "0000918044", null },
                    { "04e381f9-b066-42ba-a1ff-cc4fd8b3fa4d", "customer88@abv.bg", "Jane", true, "Johnson", "0000375314", null },
                    { "80dccaf0-8d68-4cda-8abf-3a22d4b6059d", "customer14@abv.bg", "Jane", true, "Brown", "0000862170", null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "IsAvailable", "Number", "PricePerBedAdult", "PricePerBedChild", "ReservationId", "RoomType" },
                values: new object[,]
                {
                    { "1e6ac703-8b06-49e9-849f-b60181b259b8", 4, true, 101, 675m, 337.5m, null, 1 },
                    { "1854f3a1-b53c-4b83-9ac6-e0b3bae23173", 6, true, 101, 278m, 139m, null, 0 },
                    { "d1755971-51b8-4815-9cd7-bab7be479d96", 4, true, 101, 672m, 336m, null, 3 },
                    { "8e570f87-5260-44f0-a8eb-e0d9116e5169", 5, true, 101, 881m, 440.5m, null, 3 },
                    { "848e9e4a-1b8b-4855-9a0b-ba9c113ddefd", 1, true, 101, 961m, 480.5m, null, 1 },
                    { "a540e96b-3aaf-4dc1-b330-21c0ff34a842", 0, true, 101, 195m, 97.5m, null, 2 },
                    { "0088f986-b81d-4dc6-af91-e93f5edec833", 4, true, 101, 630m, 315m, null, 0 },
                    { "1ef1c9e4-2d70-4c43-860e-0af11a72f37e", 8, true, 101, 252m, 126m, null, 4 },
                    { "7165d03e-f435-40ec-a981-d5e9aa8109c0", 5, true, 101, 269m, 134.5m, null, 3 },
                    { "741c2970-0555-4598-bcd1-3a4b41986d75", 7, true, 101, 587m, 293.5m, null, 2 },
                    { "ecf3e9f3-44d3-4124-bd40-baa62a27cab8", 4, true, 101, 785m, 392.5m, null, 3 },
                    { "8693e5d8-4fc3-4ff8-8fc2-ec0a37391f23", 9, true, 101, 159m, 79.5m, null, 4 },
                    { "33c00c4d-26b9-47a7-b964-ffef74c7a10b", 7, true, 101, 174m, 87m, null, 1 },
                    { "995c5d81-cc22-4285-ab47-486d22ca820f", 7, true, 101, 584m, 292m, null, 0 },
                    { "01861ad9-5c7e-4f53-9263-6edfb152c405", 8, true, 101, 14m, 7m, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "8e98f200-6332-4bf9-aa8b-38b47f044ef2" },
                    { "0a42a68e-daa3-4dc4-9994-c0db945027d6", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "5aef87e7-d892-49a7-8250-6c174b3eec38", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "567dafee-3715-42d4-bcb9-26acb1990871", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "b57ba01f-08ec-4fa6-8d36-64972a53f0cb", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "d805da1c-3fda-49aa-8050-97e6e515b3bc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "3b981167-3f08-418a-8054-e9181e075e8f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "c6b35e10-a2e5-4dd0-94a1-f16c3f1f1cbd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "bffa2008-b90f-4f06-8618-80dd2ad1b7eb", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "2b5d59b4-b58e-425f-85cd-055d1d19b1a0", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "0d9847ec-e72c-4ec2-8b1a-a7d8593442f5", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "3c79e282-037e-4ef8-8837-803d1d616d63", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "f00ca476-a43e-4573-83c1-368a82495fa7", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "d1f4a0bd-4195-4140-80de-8a3061963e53", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "41d79197-dd2f-4b04-b5c4-fd446a11db42", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "8efd331c-927a-4b5e-a245-17bc5e177bfd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "f312c2cb-5444-466a-9541-cc10d157cf80", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "8c73d9c0-5453-46a9-9746-9252cec73b7e", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "15c271d8-7225-468b-b2b0-6e2823974543", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "5cd9a2ba-c1f7-46f7-aa35-668daab9e67f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "8dea4423-582d-4bb0-bb5a-43770a836bbc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "4d5ca831-5a95-46c6-a77d-325b81f994fb", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "c2480e50-fe0f-4605-ad71-abf5d2bc5652", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "9322fce0-b592-446e-9eaf-638af8c71467", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "4de40bd8-9e75-49cc-b531-25b52e084b15", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "cbe647b9-31a4-47a5-ad56-af6a6d9bbfd3", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "2d285200-f79d-4bed-9e22-d38a18158689", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "f09aceda-f3a5-43f9-9681-0f9164daf1cd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "082951a3-d6c7-4089-bf00-235cc72a3eb5", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "2351a037-3c9a-4289-92d6-521aecaca0fd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "2de80c77-854e-4c44-98e6-9fffed4b1abc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "e93ec1d2-860a-4e3d-ad5e-2598d1637b81", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "5008c1e8-e54f-4de0-825e-1edf69f68e30", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "213eb9d7-36fb-4e5b-83ee-60b81791c1c5", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "b86ff162-8694-43e0-ae9e-2f4fce1119d7", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "862625e2-3122-45d3-a1b6-4f47cca4897a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "8c93b03f-d461-4abc-9af2-474308c7b4be", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "1ba2c572-d545-44be-bc79-c994d66612fe", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "03d7f0af-94da-46f9-8953-ddd3f2912815", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "f6aba4f1-0099-4ffc-b4a1-e1e55332e0f4", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "06b613a2-618a-47f2-bc2e-245eaeb57948", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "679a5e06-47ba-4943-be8d-619b2b615ea2", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "2825d052-b8df-47d9-bc58-499c4b2bf212", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "12702a9e-9dfd-4a83-bcf8-a4a352fc6b62", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "64cbd81d-50bc-4476-8cf5-27ee22e5b38b", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "b02bfa7c-772c-45ca-bc79-5dde983e926a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "8ca94615-66e8-42b1-83dd-73e2ab0a34ca", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "80e9a736-3e85-46d3-b6d4-27b4b3eaf965", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "91d8a0a5-e369-41d2-a00b-053cb26bf748", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "e707708d-55ea-4f54-8e2b-82175347e25a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "b33825e9-d336-47a2-be16-23a4e924d273", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "fd295e2f-c614-4cfa-8eca-44ad283c267f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "ba32c404-c8f9-4c72-8681-56bc32b6aba7", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "038286d3-6500-469e-b236-48112c6e71f1", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "2bd1371b-7d27-4d85-ab7c-7b3aa598fc4b", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "24da5029-5c73-40c7-86b7-07033a3000e2", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "e93685d4-550c-4ae4-881b-acb050079fe8", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "ac5888be-d6e3-4306-95dd-d559122e195a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "b7eff9a7-a9f1-4424-8802-c62a2b8ab476", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "72ef17b2-faa3-43a8-b5f1-b461021750fa", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "9d783968-80e6-492b-9eda-1ba5740419b4", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "0db92686-118f-4aa5-ad6a-ff73d86fd925", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "d1ee338a-16c0-4018-9ed5-34def9a14e54", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "e006dbe0-d775-4407-9f86-37e78fb13fe4", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "24247e8a-45e8-4eb4-8c1d-81077220c038", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "4638e0d7-ef8b-496c-a390-a185b30e46dc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "63405cc4-6af0-4d79-a2fe-f5e6a9a51525", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "6ad6fb11-8a2f-4f76-a046-8254fc448d55", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "874606d9-81e0-40b3-881e-6fac16fea67b", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "48da6289-de5d-4f06-8aff-baf65636c7dc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "35fd1ea3-31c9-4a9b-8b5e-9473e2c04884", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "5072a61a-0188-4e40-967b-9ff75ae717be", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "41b55b0e-72fb-4507-9aa8-0efb35fd37c9", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "b23e2869-44fd-4ef1-b7fd-31e4058a8ab9", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "df5ccd52-add9-42e7-9e1d-784b78598096", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "b09f1445-7113-4130-b4cf-d900c7dab2c6", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "3dca359f-af82-42e3-8718-ab43a4dd7b79", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "404b3246-4911-4150-a4fe-e4617d9f74c6", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "7c52b729-a82d-4bbd-bfe4-8388146301dd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "56e7770c-8597-4cd7-aa1a-50db7d27dd1e", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "9d53cc64-f9e7-4870-8fe0-5b8a82149f45", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "fd00b185-e3aa-442d-9479-cae2d87ca93d", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "fd48e2ed-4b93-401a-a837-2266bc15217d", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "385ec2af-562a-483b-9b86-1a17c874c94a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "7067c928-b2e6-4424-8294-f8394f0aac96", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "46dcdc15-6363-4095-9072-dac0c65be206", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "b272ba75-66b6-46f1-8c04-541325d919ad", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "20e7c27b-e5e9-4fdd-a785-360f9f717bb3", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "ab323867-387f-478b-a591-d667efdb92a4", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "d8c7791f-35bc-45b9-b020-5b27c1363b1f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "eca2c45d-31e7-4b79-96dd-394baf21895a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "98a47581-d326-49e8-bec3-7056c034182f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "a0ad2200-7670-47e6-9f3c-f436ae3563ff", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "da76f0a1-168e-40e6-a33d-ab335b0ccf71", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "41d2dbb0-0285-4e2f-b4d3-afc94a72578d", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "a1ea2176-b04b-48f8-a275-f9ab538516b0", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "8d3318b9-fb06-487b-a236-93e87a97f76a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "2129a2b9-dfeb-4243-ade7-85a10bbecdcc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "6abb04c0-3008-4c59-a204-6d897dbd2fac", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "9050225d-0eea-48eb-8434-ccb042c43aad", "0e01e14b-3d25-4d19-bf0a-743ed10be274" },
                    { "ba280834-71e5-4c5c-921a-4ecc62912c25", "0e01e14b-3d25-4d19-bf0a-743ed10be274" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerHistory_Customers_CustomerId",
                table: "CustomerHistory",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerHistory_Customers_CustomerId",
                table: "CustomerHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "038286d3-6500-469e-b236-48112c6e71f1", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "03d7f0af-94da-46f9-8953-ddd3f2912815", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "06b613a2-618a-47f2-bc2e-245eaeb57948", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "082951a3-d6c7-4089-bf00-235cc72a3eb5", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0a42a68e-daa3-4dc4-9994-c0db945027d6", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0d9847ec-e72c-4ec2-8b1a-a7d8593442f5", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0db92686-118f-4aa5-ad6a-ff73d86fd925", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "12702a9e-9dfd-4a83-bcf8-a4a352fc6b62", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "15c271d8-7225-468b-b2b0-6e2823974543", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1ba2c572-d545-44be-bc79-c994d66612fe", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "20e7c27b-e5e9-4fdd-a785-360f9f717bb3", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2129a2b9-dfeb-4243-ade7-85a10bbecdcc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "213eb9d7-36fb-4e5b-83ee-60b81791c1c5", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2351a037-3c9a-4289-92d6-521aecaca0fd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "24247e8a-45e8-4eb4-8c1d-81077220c038", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "24da5029-5c73-40c7-86b7-07033a3000e2", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2825d052-b8df-47d9-bc58-499c4b2bf212", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2b5d59b4-b58e-425f-85cd-055d1d19b1a0", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2bd1371b-7d27-4d85-ab7c-7b3aa598fc4b", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2d285200-f79d-4bed-9e22-d38a18158689", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2de80c77-854e-4c44-98e6-9fffed4b1abc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "35fd1ea3-31c9-4a9b-8b5e-9473e2c04884", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "385ec2af-562a-483b-9b86-1a17c874c94a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3b981167-3f08-418a-8054-e9181e075e8f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3c79e282-037e-4ef8-8837-803d1d616d63", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3dca359f-af82-42e3-8718-ab43a4dd7b79", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "404b3246-4911-4150-a4fe-e4617d9f74c6", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "41b55b0e-72fb-4507-9aa8-0efb35fd37c9", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "41d2dbb0-0285-4e2f-b4d3-afc94a72578d", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "41d79197-dd2f-4b04-b5c4-fd446a11db42", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4638e0d7-ef8b-496c-a390-a185b30e46dc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "46dcdc15-6363-4095-9072-dac0c65be206", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "48da6289-de5d-4f06-8aff-baf65636c7dc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4d5ca831-5a95-46c6-a77d-325b81f994fb", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4de40bd8-9e75-49cc-b531-25b52e084b15", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5008c1e8-e54f-4de0-825e-1edf69f68e30", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5072a61a-0188-4e40-967b-9ff75ae717be", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "567dafee-3715-42d4-bcb9-26acb1990871", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "56e7770c-8597-4cd7-aa1a-50db7d27dd1e", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5aef87e7-d892-49a7-8250-6c174b3eec38", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5cd9a2ba-c1f7-46f7-aa35-668daab9e67f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "63405cc4-6af0-4d79-a2fe-f5e6a9a51525", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "64cbd81d-50bc-4476-8cf5-27ee22e5b38b", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "679a5e06-47ba-4943-be8d-619b2b615ea2", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6abb04c0-3008-4c59-a204-6d897dbd2fac", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6ad6fb11-8a2f-4f76-a046-8254fc448d55", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7067c928-b2e6-4424-8294-f8394f0aac96", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "72ef17b2-faa3-43a8-b5f1-b461021750fa", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7c52b729-a82d-4bbd-bfe4-8388146301dd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "80e9a736-3e85-46d3-b6d4-27b4b3eaf965", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "862625e2-3122-45d3-a1b6-4f47cca4897a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "874606d9-81e0-40b3-881e-6fac16fea67b", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8c73d9c0-5453-46a9-9746-9252cec73b7e", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8c93b03f-d461-4abc-9af2-474308c7b4be", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8ca94615-66e8-42b1-83dd-73e2ab0a34ca", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8d3318b9-fb06-487b-a236-93e87a97f76a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8dea4423-582d-4bb0-bb5a-43770a836bbc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e445864-a24d-4543-a6c6-9443d048cdb9", "8e98f200-6332-4bf9-aa8b-38b47f044ef2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8efd331c-927a-4b5e-a245-17bc5e177bfd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9050225d-0eea-48eb-8434-ccb042c43aad", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "91d8a0a5-e369-41d2-a00b-053cb26bf748", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9322fce0-b592-446e-9eaf-638af8c71467", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "98a47581-d326-49e8-bec3-7056c034182f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9d53cc64-f9e7-4870-8fe0-5b8a82149f45", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9d783968-80e6-492b-9eda-1ba5740419b4", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a0ad2200-7670-47e6-9f3c-f436ae3563ff", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a1ea2176-b04b-48f8-a275-f9ab538516b0", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ab323867-387f-478b-a591-d667efdb92a4", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ac5888be-d6e3-4306-95dd-d559122e195a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b02bfa7c-772c-45ca-bc79-5dde983e926a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b09f1445-7113-4130-b4cf-d900c7dab2c6", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b23e2869-44fd-4ef1-b7fd-31e4058a8ab9", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b272ba75-66b6-46f1-8c04-541325d919ad", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b33825e9-d336-47a2-be16-23a4e924d273", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b57ba01f-08ec-4fa6-8d36-64972a53f0cb", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b7eff9a7-a9f1-4424-8802-c62a2b8ab476", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b86ff162-8694-43e0-ae9e-2f4fce1119d7", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ba280834-71e5-4c5c-921a-4ecc62912c25", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ba32c404-c8f9-4c72-8681-56bc32b6aba7", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bffa2008-b90f-4f06-8618-80dd2ad1b7eb", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c2480e50-fe0f-4605-ad71-abf5d2bc5652", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c6b35e10-a2e5-4dd0-94a1-f16c3f1f1cbd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cbe647b9-31a4-47a5-ad56-af6a6d9bbfd3", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d1ee338a-16c0-4018-9ed5-34def9a14e54", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d1f4a0bd-4195-4140-80de-8a3061963e53", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d805da1c-3fda-49aa-8050-97e6e515b3bc", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d8c7791f-35bc-45b9-b020-5b27c1363b1f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "da76f0a1-168e-40e6-a33d-ab335b0ccf71", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "df5ccd52-add9-42e7-9e1d-784b78598096", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e006dbe0-d775-4407-9f86-37e78fb13fe4", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e707708d-55ea-4f54-8e2b-82175347e25a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e93685d4-550c-4ae4-881b-acb050079fe8", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e93ec1d2-860a-4e3d-ad5e-2598d1637b81", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "eca2c45d-31e7-4b79-96dd-394baf21895a", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f00ca476-a43e-4573-83c1-368a82495fa7", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f09aceda-f3a5-43f9-9681-0f9164daf1cd", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f312c2cb-5444-466a-9541-cc10d157cf80", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f6aba4f1-0099-4ffc-b4a1-e1e55332e0f4", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fd00b185-e3aa-442d-9479-cae2d87ca93d", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fd295e2f-c614-4cfa-8eca-44ad283c267f", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fd48e2ed-4b93-401a-a837-2266bc15217d", "0e01e14b-3d25-4d19-bf0a-743ed10be274" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "002d0f99-8a68-483b-b5bb-86b28eead710");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "01896e30-7887-4382-a097-5c079581bfa9");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "04e381f9-b066-42ba-a1ff-cc4fd8b3fa4d");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "06895b4d-17e8-478a-9ab9-7bbbd0131ce1");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "0b71220c-1162-449e-bdfa-e5403f15c3c3");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "14af96f2-909e-476a-90de-9c45c798f729");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "17d7e2ac-f65f-42f6-b536-2d115c94cbef");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1a8934fa-9301-49dd-8140-e3bb2e382d29");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1be89763-5fb1-4d5f-85b1-72617f4a5e9f");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "1fe88426-a706-477d-8dd2-ca98bc36b388");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "228885ae-2a65-4df7-bee8-0438c6dbcf78");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "232f6a59-e614-437b-9152-aed62f65204c");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "23d781ba-8448-437b-819e-2d375d890250");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "259b5d40-c083-4da5-bfc8-5b66951ce305");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "2e81b0a1-4f9b-45ce-a1fd-ead53b8923af");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3020977b-444c-4521-a357-2b17c11b70e0");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "30266e9d-a19a-4b54-a5c7-c0a8536cb421");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "33cffdc6-869d-4fb9-afd3-c5693ae9918b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "35b575f2-c1a5-472b-ba00-34947ff18a75");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3adc44fb-b0f3-4341-be3c-8060a6c92723");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "3fa61417-d6bb-4bc1-8023-b58bf58559d3");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4164ae64-f615-4b6c-8268-3dea4a157295");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "420789a5-d876-4975-a5a2-a8553537d07e");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "46a34f6e-ebd2-41e5-b371-d0257d9d0a83");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4a00b39f-80aa-4ea5-acfd-e36619126229");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4b51d0c5-2fb6-49d3-a612-786b80d0977c");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4c9241ad-e3dd-4fbf-b7d5-5e3d9a388dbd");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4e189a4b-b35d-44f7-ac56-ba0714c550a4");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "4e296d48-f222-4ab9-bf1c-cdefcb78d0b3");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5192e028-a60f-4640-9257-b8b1baae0a27");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "5627cf54-1e6a-4ce8-bb82-e4f396aed246");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "56687101-ebc7-487d-bb8c-6be7f9d72e47");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "60b22e31-93cd-4821-8e1d-a1f5290b7464");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "61ca664b-b99c-4119-82fc-19b94e452041");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "620841b3-f20b-4b53-b66b-adbf21214f72");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "680a2156-dcd7-40a2-abb2-2e6aaedd1bd8");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6c684772-2d91-4587-974d-13268153f199");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6e6d1f53-3e3b-4814-84ca-2a959ec89937");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6f2f53d8-2ec4-40a7-ae34-857e9f7fe1a9");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "6f50ebec-ff26-49b9-b3a3-500a9fd4ae2a");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "71a3385a-41f5-42d2-8757-d09cfdf14efb");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "76ba56aa-8fc8-4810-b9bb-c7099a74235e");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7730570e-b19a-4b87-834a-188f636f7de6");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "79eb93a3-e688-41ff-a6c0-3449d427b88a");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7b15e98a-c858-467a-aacb-0f01216de3d6");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "7d925ba8-a0db-498f-a853-23b0c01f4036");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "80dccaf0-8d68-4cda-8abf-3a22d4b6059d");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "80ded51f-a845-41a1-843b-02694788aaea");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8149a1ff-b61d-4aff-9c14-52a090992fb0");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "83bedbf5-efdf-4820-8ff9-d5271c0ec21e");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "86b31582-6802-4c96-81c9-74f2d4189f35");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "889bf973-d989-4b20-9413-c33f82f5b581");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8b8d140e-9ff5-40f9-9202-4f65e92f5c78");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8c363b03-43e2-4e2e-91d8-e7a5b4ded5aa");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8c39b228-aa13-459e-814e-88ca0b38fd1d");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8dc692bc-b1df-4c18-ad43-2f579f49a83b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "8ec5793d-9fce-47c2-ba3d-dd337b711332");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "945a5dbd-aaad-459e-929b-6f17c86a9b2b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "95a01234-5be6-48a6-956f-09a70bd318bf");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "96421790-af60-4b13-bacd-4c53062d0a52");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9b2bce92-690a-4d15-98d2-ddc9c9e35a4d");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9b3222f0-70d1-40ff-8eed-b4dbde879f3a");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9b9d08b6-19a3-4223-8c1b-801fe1700a3a");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9cec7c63-4bb6-462e-badf-96f644bef0ba");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "9dbabd2b-2ee9-4a3a-beec-c423aee0f295");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a021d8c1-f638-4fa3-a2ff-ca7a5a61b894");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a2aad56a-03ce-488c-a585-b991c5897d6e");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a316347b-cb6c-4454-8127-cdf1caa8b63c");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a7b6e0a9-9b54-43f2-86f2-e3da84f8d7d8");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "a8cae39f-89a8-4265-a323-537058221329");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "aabf13a5-b2df-477b-a44f-6c316dac0c54");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "ad9e152d-27fd-4859-939f-2daa6d742d40");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "af2ce2b9-74d5-405a-bebe-4c2290b5f24f");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "b16d8da4-652b-42c4-ad9f-c6ff6bf20090");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "b2786f57-4e86-4e1a-b868-d32655faae38");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "b40342df-c7c9-43b5-b412-cdddf3d8f42b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "b6cc5610-6f8d-4615-b218-c61793de8ba9");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "bddaf49a-e3df-4953-8664-d452b1e11bfa");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "beb4694d-2823-47a6-bc57-be782010ed42");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "c2e25f3f-7444-4010-986d-942101bae393");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "cb85c5c5-8aea-480b-a897-6686ded78d5f");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "ccf43d56-3c35-4c3f-b159-87e8d8de6c3d");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "d14faee4-0585-437e-82cf-38a90f5fda1a");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "d379181d-4916-403c-a3b5-892252f7163c");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "d5f964a6-5f16-4edc-a9cd-f804b0f93f65");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "d7db312e-1f1e-477d-baa4-1a57929f853d");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "dbc438c6-dd67-40c9-b02f-16b6679c46ca");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "dcd8503c-f86f-4c7f-85d5-7545dc9a087b");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "dfd0d5d8-cd1e-4515-a727-2c798e3c5a45");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "e0cc7f1b-f719-462f-a896-6196f8018c04");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "e16dd06f-da1d-45cc-a7de-3ead0e87015a");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "e61b81a9-9a2e-4e7b-8838-8f06de7b0e69");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "e74de9a0-28ea-40ac-ba92-8c92be1f659d");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "e8e65c53-de56-4c33-ab7d-eba319780a93");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "f0163094-4daa-4e2b-9893-f21a6285b02e");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "f1adc53f-3db7-4c04-a631-e280bd92a4c4");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "f226c1d2-ed5b-4f00-9fe9-6d1c7b025775");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "f2f07afd-651c-4e5f-b3ed-448a2836ab58");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "f89320fa-9722-4952-8934-236f09fe4ae2");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: "fb0dfa5a-e093-4954-b887-38f057c48010");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "0088f986-b81d-4dc6-af91-e93f5edec833");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "01861ad9-5c7e-4f53-9263-6edfb152c405");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1854f3a1-b53c-4b83-9ac6-e0b3bae23173");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1e6ac703-8b06-49e9-849f-b60181b259b8");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "1ef1c9e4-2d70-4c43-860e-0af11a72f37e");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "33c00c4d-26b9-47a7-b964-ffef74c7a10b");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "7165d03e-f435-40ec-a981-d5e9aa8109c0");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "741c2970-0555-4598-bcd1-3a4b41986d75");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "848e9e4a-1b8b-4855-9a0b-ba9c113ddefd");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8693e5d8-4fc3-4ff8-8fc2-ec0a37391f23");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "8e570f87-5260-44f0-a8eb-e0d9116e5169");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "995c5d81-cc22-4285-ab47-486d22ca820f");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "a540e96b-3aaf-4dc1-b330-21c0ff34a842");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "d1755971-51b8-4815-9cd7-bab7be479d96");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: "ecf3e9f3-44d3-4124-bd40-baa62a27cab8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e01e14b-3d25-4d19-bf0a-743ed10be274");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e98f200-6332-4bf9-aa8b-38b47f044ef2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "038286d3-6500-469e-b236-48112c6e71f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03d7f0af-94da-46f9-8953-ddd3f2912815");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06b613a2-618a-47f2-bc2e-245eaeb57948");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "082951a3-d6c7-4089-bf00-235cc72a3eb5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a42a68e-daa3-4dc4-9994-c0db945027d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d9847ec-e72c-4ec2-8b1a-a7d8593442f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0db92686-118f-4aa5-ad6a-ff73d86fd925");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12702a9e-9dfd-4a83-bcf8-a4a352fc6b62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15c271d8-7225-468b-b2b0-6e2823974543");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ba2c572-d545-44be-bc79-c994d66612fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20e7c27b-e5e9-4fdd-a785-360f9f717bb3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2129a2b9-dfeb-4243-ade7-85a10bbecdcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "213eb9d7-36fb-4e5b-83ee-60b81791c1c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2351a037-3c9a-4289-92d6-521aecaca0fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24247e8a-45e8-4eb4-8c1d-81077220c038");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24da5029-5c73-40c7-86b7-07033a3000e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2825d052-b8df-47d9-bc58-499c4b2bf212");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b5d59b4-b58e-425f-85cd-055d1d19b1a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bd1371b-7d27-4d85-ab7c-7b3aa598fc4b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d285200-f79d-4bed-9e22-d38a18158689");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2de80c77-854e-4c44-98e6-9fffed4b1abc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35fd1ea3-31c9-4a9b-8b5e-9473e2c04884");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "385ec2af-562a-483b-9b86-1a17c874c94a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b981167-3f08-418a-8054-e9181e075e8f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c79e282-037e-4ef8-8837-803d1d616d63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dca359f-af82-42e3-8718-ab43a4dd7b79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "404b3246-4911-4150-a4fe-e4617d9f74c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41b55b0e-72fb-4507-9aa8-0efb35fd37c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41d2dbb0-0285-4e2f-b4d3-afc94a72578d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41d79197-dd2f-4b04-b5c4-fd446a11db42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4638e0d7-ef8b-496c-a390-a185b30e46dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46dcdc15-6363-4095-9072-dac0c65be206");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48da6289-de5d-4f06-8aff-baf65636c7dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d5ca831-5a95-46c6-a77d-325b81f994fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4de40bd8-9e75-49cc-b531-25b52e084b15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5008c1e8-e54f-4de0-825e-1edf69f68e30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5072a61a-0188-4e40-967b-9ff75ae717be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "567dafee-3715-42d4-bcb9-26acb1990871");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56e7770c-8597-4cd7-aa1a-50db7d27dd1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5aef87e7-d892-49a7-8250-6c174b3eec38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cd9a2ba-c1f7-46f7-aa35-668daab9e67f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63405cc4-6af0-4d79-a2fe-f5e6a9a51525");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64cbd81d-50bc-4476-8cf5-27ee22e5b38b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "679a5e06-47ba-4943-be8d-619b2b615ea2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6abb04c0-3008-4c59-a204-6d897dbd2fac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ad6fb11-8a2f-4f76-a046-8254fc448d55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7067c928-b2e6-4424-8294-f8394f0aac96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72ef17b2-faa3-43a8-b5f1-b461021750fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c52b729-a82d-4bbd-bfe4-8388146301dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80e9a736-3e85-46d3-b6d4-27b4b3eaf965");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "862625e2-3122-45d3-a1b6-4f47cca4897a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "874606d9-81e0-40b3-881e-6fac16fea67b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c73d9c0-5453-46a9-9746-9252cec73b7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c93b03f-d461-4abc-9af2-474308c7b4be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ca94615-66e8-42b1-83dd-73e2ab0a34ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d3318b9-fb06-487b-a236-93e87a97f76a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8dea4423-582d-4bb0-bb5a-43770a836bbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8efd331c-927a-4b5e-a245-17bc5e177bfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9050225d-0eea-48eb-8434-ccb042c43aad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91d8a0a5-e369-41d2-a00b-053cb26bf748");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9322fce0-b592-446e-9eaf-638af8c71467");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98a47581-d326-49e8-bec3-7056c034182f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d53cc64-f9e7-4870-8fe0-5b8a82149f45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d783968-80e6-492b-9eda-1ba5740419b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0ad2200-7670-47e6-9f3c-f436ae3563ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1ea2176-b04b-48f8-a275-f9ab538516b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab323867-387f-478b-a591-d667efdb92a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac5888be-d6e3-4306-95dd-d559122e195a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b02bfa7c-772c-45ca-bc79-5dde983e926a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b09f1445-7113-4130-b4cf-d900c7dab2c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b23e2869-44fd-4ef1-b7fd-31e4058a8ab9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b272ba75-66b6-46f1-8c04-541325d919ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b33825e9-d336-47a2-be16-23a4e924d273");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b57ba01f-08ec-4fa6-8d36-64972a53f0cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7eff9a7-a9f1-4424-8802-c62a2b8ab476");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b86ff162-8694-43e0-ae9e-2f4fce1119d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba280834-71e5-4c5c-921a-4ecc62912c25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba32c404-c8f9-4c72-8681-56bc32b6aba7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bffa2008-b90f-4f06-8618-80dd2ad1b7eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2480e50-fe0f-4605-ad71-abf5d2bc5652");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6b35e10-a2e5-4dd0-94a1-f16c3f1f1cbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbe647b9-31a4-47a5-ad56-af6a6d9bbfd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1ee338a-16c0-4018-9ed5-34def9a14e54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1f4a0bd-4195-4140-80de-8a3061963e53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d805da1c-3fda-49aa-8050-97e6e515b3bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8c7791f-35bc-45b9-b020-5b27c1363b1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da76f0a1-168e-40e6-a33d-ab335b0ccf71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df5ccd52-add9-42e7-9e1d-784b78598096");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e006dbe0-d775-4407-9f86-37e78fb13fe4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e707708d-55ea-4f54-8e2b-82175347e25a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e93685d4-550c-4ae4-881b-acb050079fe8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e93ec1d2-860a-4e3d-ad5e-2598d1637b81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eca2c45d-31e7-4b79-96dd-394baf21895a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f00ca476-a43e-4573-83c1-368a82495fa7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f09aceda-f3a5-43f9-9681-0f9164daf1cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f312c2cb-5444-466a-9541-cc10d157cf80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6aba4f1-0099-4ffc-b4a1-e1e55332e0f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd00b185-e3aa-442d-9479-cae2d87ca93d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd295e2f-c614-4cfa-8eca-44ad283c267f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd48e2ed-4b93-401a-a837-2266bc15217d");

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
                columns: new[] { "ConcurrencyStamp", "HireDate", "PasswordHash", "PhoneNumber" },
                values: new object[] { "a44a053f-b9cc-425d-9e1a-a381b95e6d5e", new DateTime(2023, 3, 25, 18, 55, 33, 790, DateTimeKind.Local).AddTicks(4976), "AQAAAAEAACcQAAAAEOUcBAXjU/cl59ObvoZ7dYiVZkwcZoLLSWK7K98jTmRrTEj6gN9MVfyTFHN4gP6T0Q==", "1111111111" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerHistory_Customers_CustomerId",
                table: "CustomerHistory",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Reservations_ReservationId",
                table: "Customers",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
