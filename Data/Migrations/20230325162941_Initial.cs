using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    UCN = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    FireDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RoomId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    AccommodationDate = table.Column<DateTime>(nullable: false),
                    LeaveDate = table.Column<DateTime>(nullable: false),
                    HasBreakfast = table.Column<bool>(nullable: false),
                    HasAllInclusive = table.Column<bool>(nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IsAdult = table.Column<bool>(nullable: false),
                    ReservationId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    RoomType = table.Column<int>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    PricePerBedAdult = table.Column<decimal>(type: "money", nullable: false),
                    PricePerBedChild = table.Column<decimal>(type: "money", nullable: false),
                    ReservationId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "66f8c581-f6f0-406c-9af0-35e7d2567b09", "04d4e941-0686-4e51-89de-003129cfe1a0", "Admin", "ADMIN" },
                    { "f40d8b19-06cc-4554-b6cb-67414611c0df", "88ae0370-cfdb-49ed-b1ae-d9a3aa9ad35f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UCN", "UserName" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", 0, "b3140740-1bca-4f51-a5ea-833fcb5eccbc", "admin@abv.bg", true, null, "John", new DateTime(2023, 3, 25, 18, 29, 41, 20, DateTimeKind.Local).AddTicks(6698), true, "Johnson", false, null, "Johnny", "ADMIN@ABV.BG", "ADMIN@ABV.BG", "AQAAAAEAACcQAAAAEM4wCwlze62EoJsrcJwiclaxktm8ROCm8aVgy+R6pxJ2Z4rDSdFD36leZ40LxwalUA==", "1111111111", true, "", false, "8603129931", "admin@abv.bg" },
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ReservationId",
                table: "Customers",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_UserId",
                table: "Reservations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ReservationId",
                table: "Rooms",
                column: "ReservationId",
                unique: true,
                filter: "[ReservationId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
