using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Reservation_Manager.data.migrations
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
                    EGN = table.Column<string>(nullable: true),
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
                    UserId = table.Column<string>(nullable: true),
                    AccommodationDate = table.Column<DateTime>(nullable: false),
                    LeaveDate = table.Column<DateTime>(nullable: false),
                    HasBreakfast = table.Column<bool>(nullable: false),
                    HasAllInclusive = table.Column<bool>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
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
                    PricePerBedAdult = table.Column<decimal>(nullable: false),
                    PricePerBedChild = table.Column<decimal>(nullable: false),
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
                    { "863f63b8-943c-40a1-bae5-529fc38ce420", "0939480b-aa97-4966-83f2-5fe931068b83", "User", "USER" },
                    { "6ecf672a-137e-4458-91b1-120bd23252c4", "515aa90f-60c7-4b34-9445-f8a05799c543", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "310a0bf1-44fa-45ef-9cc2-c80291d88f15", 0, "33f27e9e-9b57-436f-bc37-a957a360d621", "004886", "user98@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 333, DateTimeKind.Local).AddTicks(1368), true, "Alexandrov", false, null, "Jane", "user98@abv.bg", "user98@abv.bg", "AQAAAAEAACcQAAAAEESoCLB/gktYS43iOJjMvnRQcNkNA7v3N5TpJS2CiPA75wkc7dnxZVLsxDXoymPN8g==", "008783", true, "", false, "user98@abv.bg" },
                    { "40055042-e587-4376-a14c-f42d858661a1", 0, "df9fa0da-c700-466f-b334-91ffb14625b3", "001516", "user72@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 110, DateTimeKind.Local).AddTicks(3549), true, "Alexandrov", false, null, "John", "user72@abv.bg", "user72@abv.bg", "AQAAAAEAACcQAAAAEBPzubqt71ZOkL5W2A3S2zikG8mroVa9YXJOdE3zc68Ppf93PtS6N0I6DKfvxZCqXw==", "009866", true, "", false, "user72@abv.bg" },
                    { "22b970d9-a138-441b-876e-906a2a80494a", 0, "ef29281c-a61d-49e0-8169-e85caf3432be", "009276", "user71@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 101, DateTimeKind.Local).AddTicks(9657), true, "Johnson", false, null, "Jane", "user71@abv.bg", "user71@abv.bg", "AQAAAAEAACcQAAAAEGvqgPMX99jK24phBti4k3GgtLls4+uqo1kTL5wmHUxvjBAuFiEVoFoJsPDU81WGzA==", "005682", true, "", false, "user71@abv.bg" },
                    { "6f02b90d-5286-48e0-afeb-4f4b9f51d471", 0, "1ee3ca9a-5949-43c9-b79f-b0bcedb64a56", "001540", "user70@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 92, DateTimeKind.Local).AddTicks(146), true, "Johnson", false, null, "Jack", "user70@abv.bg", "user70@abv.bg", "AQAAAAEAACcQAAAAEIofA9G+eghp29hm6FFvzju+n8ZXsWEm/Afr3ERA2vSdxhLetKH6pdw08fpyA5ssog==", "003179", true, "", false, "user70@abv.bg" },
                    { "691c2734-906d-4244-bc38-34b8f1c422c4", 0, "71a155a0-4be0-4e6b-b012-901ba4ec653e", "002844", "user69@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 83, DateTimeKind.Local).AddTicks(5808), true, "Alexandrov", false, null, "Alex", "user69@abv.bg", "user69@abv.bg", "AQAAAAEAACcQAAAAEELQ/gjLZw4iLeN7fB4/aqRIa+GBjCPswpZaoHtcbA1rbgj1thood5fyBRyO8k5UpA==", "003834", true, "", false, "user69@abv.bg" },
                    { "973b3385-2c52-4e43-973e-742c5359bb10", 0, "6ade9eeb-1e82-411b-88c2-111532f7a005", "008897", "user68@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 74, DateTimeKind.Local).AddTicks(9644), true, "Alexandrov", false, null, "Jane", "user68@abv.bg", "user68@abv.bg", "AQAAAAEAACcQAAAAEEhuaPp8fMfL8vxwMAIO1tvR9Vcfl+mgLRFm+J9s7ZUbv6H5mj77YLRIPEKL5w0hIA==", "007390", true, "", false, "user68@abv.bg" },
                    { "6ec19c6b-7ae7-4df0-bb7a-1110d4b3671a", 0, "3d1d8714-cafe-4573-bbdc-0762cc7b02f8", "002147", "user67@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 66, DateTimeKind.Local).AddTicks(2440), true, "Alexandrov", false, null, "Jane", "user67@abv.bg", "user67@abv.bg", "AQAAAAEAACcQAAAAECJb2X6d3uvjHGXWeMBAudO2T6RpklWkFCB46AetHd377GOblUDdicpXJjUi+dnFtg==", "008185", true, "", false, "user67@abv.bg" },
                    { "bfee186b-8f7f-47bf-ac1a-c96c31f43885", 0, "e594c3c2-46c3-4807-b41a-5386ce836c68", "003748", "user66@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 58, DateTimeKind.Local).AddTicks(424), true, "Johnson", false, null, "Alex", "user66@abv.bg", "user66@abv.bg", "AQAAAAEAACcQAAAAEAdDVo9ZSexDaxW4uWwZ7jTHS2gS7ufG8ZjAR5O/uBKvwxdjQEbV+1w22LPK8n5PXA==", "002097", true, "", false, "user66@abv.bg" },
                    { "2e2e8e50-23a6-4e49-8188-8f074f7fb7a7", 0, "b15aa6ef-66b1-4cc7-8461-11c59bd5ccb1", "003209", "user65@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 49, DateTimeKind.Local).AddTicks(9429), true, "Johnson", false, null, "John", "user65@abv.bg", "user65@abv.bg", "AQAAAAEAACcQAAAAECH5am/cOuaQmwAMMJbw4Ql0ANp8cz1zBaGAxbaK5mVtBtT9R0gNRDM3fePaCmiYrQ==", "003534", true, "", false, "user65@abv.bg" },
                    { "56711d20-388a-4f66-86ad-18adccc6f80d", 0, "64bfc2b8-8396-4af7-8f74-28ba0049b44f", "000776", "user64@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 42, DateTimeKind.Local).AddTicks(668), true, "Alexandrov", false, null, "Jack", "user64@abv.bg", "user64@abv.bg", "AQAAAAEAACcQAAAAEOkBesB4Maj2/lvzTysT5S2f9/5++65tQaLAUSsFNgS135Ns5V8Y+LIx1yWpBtUNUg==", "007157", true, "", false, "user64@abv.bg" },
                    { "ed024312-f08c-42a3-9352-0a99fe6a67ab", 0, "e456bb5b-6063-4563-8c56-d5acee8351fe", "009836", "user63@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 34, DateTimeKind.Local).AddTicks(2186), true, "Alexandrov", false, null, "Jack", "user63@abv.bg", "user63@abv.bg", "AQAAAAEAACcQAAAAEB0bfeeWRcnF84nnkWoeFOn8nw9kwCnEfFuY2P/gv0TjzjSrxZ9sZ0dx2Q82xTlhDQ==", "007885", true, "", false, "user63@abv.bg" },
                    { "f355fbfe-827d-4f58-84df-89fe35f5cde9", 0, "fe26a57d-e704-41d7-8076-a4e2007aa96c", "006980", "user62@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 26, DateTimeKind.Local).AddTicks(2722), true, "Johnson", false, null, "John", "user62@abv.bg", "user62@abv.bg", "AQAAAAEAACcQAAAAEG/AWxi6eo6idaY2HHk67Ht34BJl1Ufn0kas+92YaVq0BqQSM7/SNGhtF6FT+owxzw==", "002457", true, "", false, "user62@abv.bg" },
                    { "5368e623-15e5-468f-9520-709495f69c6b", 0, "d3d0e135-d615-46df-aa98-13efcf6fb360", "006436", "user61@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 18, DateTimeKind.Local).AddTicks(8377), true, "Johnson", false, null, "Jane", "user61@abv.bg", "user61@abv.bg", "AQAAAAEAACcQAAAAECVwO3NUIT8N28xMQEcqfJ9x45/g68HfnnuKuRnkwo7f4GjR25ntoFiSk212dtUDCQ==", "009610", true, "", false, "user61@abv.bg" },
                    { "24d6c12c-8d02-4e5a-8090-7e9c56e18095", 0, "40ad7137-97db-45f9-bd27-01eb37b27775", "007843", "user60@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 11, DateTimeKind.Local).AddTicks(3173), true, "Johnson", false, null, "Jack", "user60@abv.bg", "user60@abv.bg", "AQAAAAEAACcQAAAAEKRufzwzHVGbP21i9VqEUY22JbEogrkGTvuDMktTrxqh5rOMHa80watD/8S+8qfYjw==", "001942", true, "", false, "user60@abv.bg" },
                    { "5385dbad-b1b3-4b2d-8b32-cbe801d10aac", 0, "c9355627-13a6-47b6-afb2-311b5a866ad8", "009437", "user59@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 3, DateTimeKind.Local).AddTicks(5839), true, "Alexandrov", false, null, "Alex", "user59@abv.bg", "user59@abv.bg", "AQAAAAEAACcQAAAAEJPYcX75+MSsiCOhJTsROdTFodQs+uXjQOjFIR0QcEqB8ZaEOF7bUAFBX/J4PMXFxw==", "005056", true, "", false, "user59@abv.bg" },
                    { "d5bbd992-b8a9-470a-948f-1806318c7807", 0, "c4a5d3ff-49e0-48e2-b17d-0e1aa5b58d6a", "009931", "user58@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 995, DateTimeKind.Local).AddTicks(350), true, "Alexandrov", false, null, "Jack", "user58@abv.bg", "user58@abv.bg", "AQAAAAEAACcQAAAAEH+YFkFH0/ZYPWbQTWrgRpnCZeWjOc/w3jdN34E5ysASRUlNec0eWExIn10SBygQcg==", "004959", true, "", false, "user58@abv.bg" },
                    { "9ab9700e-aab5-4987-9bd9-20b19d0bac0a", 0, "8686f01c-c134-4602-ba4b-e396fdae9e15", "003454", "user57@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 986, DateTimeKind.Local).AddTicks(9730), true, "Johnson", false, null, "Jack", "user57@abv.bg", "user57@abv.bg", "AQAAAAEAACcQAAAAEOYLOuOzJMIU3XujOkirzNXuF5jlCTv1655iJJiXx+MBp1cOMUO0Xv0tiK6R5BwkQA==", "002320", true, "", false, "user57@abv.bg" },
                    { "171b17a3-bdf5-4e8b-a973-9695a905a338", 0, "9746fe39-2d4e-4274-81ae-09089ba2cd4e", "008226", "user56@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 978, DateTimeKind.Local).AddTicks(7576), true, "Alexandrov", false, null, "Jack", "user56@abv.bg", "user56@abv.bg", "AQAAAAEAACcQAAAAEB6vSwGlET3sUen99OZ0LaN1N+A1jR119f0QpYHId4//uVaFsVP2PCLy3sGZ0+1nWg==", "005424", true, "", false, "user56@abv.bg" },
                    { "7865dbbc-2034-45ef-924f-a19c6a7f5c8a", 0, "988725d7-68fd-41cf-bdce-d874815603c1", "000464", "user55@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 970, DateTimeKind.Local).AddTicks(6644), true, "Johnson", false, null, "Jane", "user55@abv.bg", "user55@abv.bg", "AQAAAAEAACcQAAAAEIHqJcAq/RMylu186xaf9n+Uby8YSMMS8Ei0mKfK95C1+cQPwz4uMYAIpf61PvUd1g==", "009959", true, "", false, "user55@abv.bg" },
                    { "83bd512b-329e-4f95-b7c1-9e7b45cc485b", 0, "4f9ef728-f0e6-4c6a-8d5a-0e7cfddafdbf", "005791", "user54@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 962, DateTimeKind.Local).AddTicks(5752), true, "Alexandrov", false, null, "John", "user54@abv.bg", "user54@abv.bg", "AQAAAAEAACcQAAAAEFactMre2xlSpa7PWV8zzz4/5dY7ST0uW2FzHQIOpMg3IyY4Q07/uqHQi4U/cSTOsA==", "008415", true, "", false, "user54@abv.bg" },
                    { "ff2a668d-148a-42fa-82a6-58f5f7cbb15e", 0, "30ec3596-35dc-4ab5-ba2a-5bf1dbe27367", "004213", "user53@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 954, DateTimeKind.Local).AddTicks(6494), true, "Alexandrov", false, null, "John", "user53@abv.bg", "user53@abv.bg", "AQAAAAEAACcQAAAAEDwQA/TUpdBgJz5+o7/9f/LzSZrkDxffqbWndsLe1gP8aX6p1ogsooe6gRA1lCPdmA==", "006754", true, "", false, "user53@abv.bg" },
                    { "0545f90a-70d8-4935-a049-95cf2d764afc", 0, "d6bbef62-d84b-40dc-9220-49fd435f89c9", "002122", "user52@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 946, DateTimeKind.Local).AddTicks(6112), true, "Johnson", false, null, "Jack", "user52@abv.bg", "user52@abv.bg", "AQAAAAEAACcQAAAAEBaKHqaJV4BuNTrYOueGKZWtPGeOl9SMTJ9R9hVBXcbYD/PpoRbHedG6xe3qXbdMZg==", "002890", true, "", false, "user52@abv.bg" },
                    { "9f1b6d0f-d448-4d04-998b-dfad94deb32a", 0, "d574d571-6fbe-4050-8511-b275d084909b", "000432", "user73@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 118, DateTimeKind.Local).AddTicks(4688), true, "Alexandrov", false, null, "Alex", "user73@abv.bg", "user73@abv.bg", "AQAAAAEAACcQAAAAELE3A7B6jDpLO0EBtbOktNhEM4K0/fO1uTigaZc0AAVmcVSePWZbYBmUtbtGFd8bHQ==", "009073", true, "", false, "user73@abv.bg" },
                    { "36939b51-52e7-4b14-b3de-f5b2f1465bbb", 0, "109aa763-bc3f-4ee1-b5ff-b0e859aa570a", "009477", "user99@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 340, DateTimeKind.Local).AddTicks(9161), true, "Alexandrov", false, null, "Jack", "user99@abv.bg", "user99@abv.bg", "AQAAAAEAACcQAAAAEE9QR6gqeYJRzIFW5SJp+SOERMdFhOjYPEedqt5mOQMM33DjXbQEvcFv98CzvlbjIA==", "003978", true, "", false, "user99@abv.bg" },
                    { "3844a9df-77a3-4109-8ec9-eb8b50b77aaf", 0, "7ce084d1-6dcf-4c96-b65a-487aa775da61", "007924", "user74@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 127, DateTimeKind.Local).AddTicks(5990), true, "Alexandrov", false, null, "Alex", "user74@abv.bg", "user74@abv.bg", "AQAAAAEAACcQAAAAEB4/RzbEcGZX2k0AbB12Zbo+XfwmUfLYk/rHeXhZpE3skWbWMUHgrZh50OsHyNJ1xQ==", "000572", true, "", false, "user74@abv.bg" },
                    { "ece9887d-2925-4beb-95a1-8f6860452b07", 0, "31c25e36-9a81-48e6-989f-b774edc44043", "003312", "user76@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 144, DateTimeKind.Local).AddTicks(7714), true, "Alexandrov", false, null, "Jane", "user76@abv.bg", "user76@abv.bg", "AQAAAAEAACcQAAAAEHfS/Pe7NQ9y8hmyf7XKbTVWrVGuGvO3njRDTFNUImXSWV0IIxXusu5npC2n01j93Q==", "009299", true, "", false, "user76@abv.bg" },
                    { "2138aa1f-9037-41f4-955c-7f218c5b0c87", 0, "dbc147b0-4375-4ebe-a1cf-d419a3671390", "004697", "user97@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 325, DateTimeKind.Local).AddTicks(5348), true, "Alexandrov", false, null, "Jane", "user97@abv.bg", "user97@abv.bg", "AQAAAAEAACcQAAAAEJ8FL0Mu1BQD8JUajj91SfETbzdpF0KVzj/DdT4rnyvdLpAdhkM+LyAdk60hf1lyTQ==", "004507", true, "", false, "user97@abv.bg" },
                    { "c806d3d2-b999-49f6-98a8-5e4beca42e4f", 0, "87fe72a5-69e8-47c0-ad83-16fda09cba80", "002258", "user96@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 317, DateTimeKind.Local).AddTicks(3107), true, "Alexandrov", false, null, "Jane", "user96@abv.bg", "user96@abv.bg", "AQAAAAEAACcQAAAAEK+4M5j2XwK1Hows106CRkRFmjpjaMRzc7VzCK29dbtlzBEgtQwpWcZJj5QPrc+f0A==", "004953", true, "", false, "user96@abv.bg" },
                    { "ebfbfc66-bd23-4aaa-8a8a-6e6d4cc3bed0", 0, "e2ec44ad-4da5-4baf-bc30-2f18b98854f4", "005356", "user95@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 309, DateTimeKind.Local).AddTicks(3558), true, "Alexandrov", false, null, "Jack", "user95@abv.bg", "user95@abv.bg", "AQAAAAEAACcQAAAAEJqCRqPsYX8IxXPkvCr6SiYuyMx/JCosC2My/iGwWdfFf+9Sw5eK2Iib6KwgIiLReQ==", "005137", true, "", false, "user95@abv.bg" },
                    { "bab17fa2-ff82-4dea-babc-527f16db3e78", 0, "720ea2ef-faff-4b9d-a1b6-f7f88340ec27", "007500", "user94@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 300, DateTimeKind.Local).AddTicks(9708), true, "Johnson", false, null, "Alex", "user94@abv.bg", "user94@abv.bg", "AQAAAAEAACcQAAAAEK3bTGObM4yU6PdC+A8+Fts1lS9Y7jlaYmopnoR9P7t50aEV+2bO+ZIhu4vWKL2dAw==", "008182", true, "", false, "user94@abv.bg" },
                    { "81c2396b-664d-4725-aea3-111cb1668a14", 0, "faeede65-75d8-46fa-b454-e76e6a59969f", "005403", "user93@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 292, DateTimeKind.Local).AddTicks(760), true, "Johnson", false, null, "Jack", "user93@abv.bg", "user93@abv.bg", "AQAAAAEAACcQAAAAEFOSonNpJsV44djhEQBN3DbOCgSJQ92O+CkzejDI3ZClA3taq7KGEK7Ke5F982SKXQ==", "003398", true, "", false, "user93@abv.bg" },
                    { "5d7e0bc8-c6f8-4b3f-93e8-05b2d99e061e", 0, "59e05b24-8729-4d8b-9bc8-06d325db22b8", "001582", "user92@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 283, DateTimeKind.Local).AddTicks(7761), true, "Alexandrov", false, null, "Jack", "user92@abv.bg", "user92@abv.bg", "AQAAAAEAACcQAAAAEKw+stq4fP0dhDWDRJUTp+aCrOn71VJoOF3nDHCOTNkKZcbyqlYY1UdaXzZfsuDcKQ==", "009947", true, "", false, "user92@abv.bg" },
                    { "1c84c71d-a231-4b0a-92f0-97569eff3cc7", 0, "5c4a921f-cc11-4728-aa1e-0ff140eb107a", "002837", "user91@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 275, DateTimeKind.Local).AddTicks(5949), true, "Alexandrov", false, null, "Jack", "user91@abv.bg", "user91@abv.bg", "AQAAAAEAACcQAAAAEIcY1n8RJDnkox017IWXAK+WjtM0QfAUp4+vNXE5eLw18XAZ3PEM21ro/fpB9JWi2Q==", "009914", true, "", false, "user91@abv.bg" },
                    { "be539df8-60ce-4dec-a1d0-e86bd541fe12", 0, "b6a53d0b-a0ae-4894-92b6-6eaaf6db1ea4", "006191", "user90@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 267, DateTimeKind.Local).AddTicks(3005), true, "Johnson", false, null, "Jack", "user90@abv.bg", "user90@abv.bg", "AQAAAAEAACcQAAAAEB8ZsEInskQTeQDnCJ7oJa0sENuzkCwrA/nSBjNghBHeyWzR3qD7+GE13xKKs9D+PQ==", "007950", true, "", false, "user90@abv.bg" },
                    { "7f82a25e-b33f-4bb6-b038-819eccf813ae", 0, "768c4534-8496-4bd2-af7c-e8f229061bdb", "000958", "user89@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 258, DateTimeKind.Local).AddTicks(7477), true, "Johnson", false, null, "Jane", "user89@abv.bg", "user89@abv.bg", "AQAAAAEAACcQAAAAEBS6qmH8qI4KnfRP81JgAz0rxEtwpDE7g+ToZdGhM3sj8FUkegpLvP0aSMLITnV8Cg==", "004520", true, "", false, "user89@abv.bg" },
                    { "4f8f4799-ffe4-47da-9e85-7df893f60687", 0, "cec65fed-ce4a-47d6-bdf8-33a8b265dad0", "003698", "user88@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 249, DateTimeKind.Local).AddTicks(5381), true, "Alexandrov", false, null, "John", "user88@abv.bg", "user88@abv.bg", "AQAAAAEAACcQAAAAELQ4peK1m40htmcXFKBXrEux0wjEXkF8b+uqfre0AUiFMTXgpg0ip65cNmQofdcaUw==", "004890", true, "", false, "user88@abv.bg" },
                    { "12c49bdf-8b79-46fa-93bd-9c806a42a146", 0, "662f4655-e30e-4ca3-bc1f-8d91456e63d4", "004397", "user87@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 241, DateTimeKind.Local).AddTicks(1936), true, "Johnson", false, null, "Jack", "user87@abv.bg", "user87@abv.bg", "AQAAAAEAACcQAAAAEN39Iav0Zi3vuZJHxRxfX0fROtjvmjFhEvwd5HJr400liOX0O5AiXMhEfIHrU+Gcgg==", "004355", true, "", false, "user87@abv.bg" },
                    { "b5e3b998-84e8-4fea-898f-4a02df84fb50", 0, "58fe2a3e-a166-45b7-8b5e-22c290a6202e", "008234", "user86@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 232, DateTimeKind.Local).AddTicks(6363), true, "Alexandrov", false, null, "Alex", "user86@abv.bg", "user86@abv.bg", "AQAAAAEAACcQAAAAEHINZ0mCgswxwK7UbPWRJDq7moju1HO3A8mtN+EajXNtRGEIu7/LaRcpvyrSSgeL2w==", "002803", true, "", false, "user86@abv.bg" },
                    { "30d582e8-70e8-4e53-a189-ff87f6d4ff52", 0, "b263c82d-3d60-4c5b-883a-097b29f48226", "004825", "user85@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 223, DateTimeKind.Local).AddTicks(8345), true, "Alexandrov", false, null, "Jack", "user85@abv.bg", "user85@abv.bg", "AQAAAAEAACcQAAAAEAnt0Uw7Lp8Y4IQ4qNKeI3kUTNqlG5JiwE+C99hCjMpcjzZmj51yOHgunMQL5Oq30A==", "004893", true, "", false, "user85@abv.bg" },
                    { "b0cd465c-70a4-41ed-84da-865165952cbf", 0, "c8771cbc-22bc-4451-b0bb-f1fe860141c6", "009846", "user84@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 215, DateTimeKind.Local).AddTicks(408), true, "Johnson", false, null, "Jane", "user84@abv.bg", "user84@abv.bg", "AQAAAAEAACcQAAAAEKMeFZ2lgmpRjH/NQLqnewRMZb+dHbLqDXW5PSXGjfeIptCNnZceOWk6k+CTGSDDGg==", "007001", true, "", false, "user84@abv.bg" },
                    { "42835c46-e5ec-4229-aac3-08225ff7459e", 0, "15da1801-3ea2-4e07-b5f9-db32636bbbfe", "009713", "user83@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 31, 206, DateTimeKind.Local).AddTicks(5310), true, "Johnson", false, null, "Alex", "user83@abv.bg", "user83@abv.bg", "AQAAAAEAACcQAAAAEMrO5tk3xymywsmFCPzENPVNWzOXPwmzx+OQkBtRMQfJpRa04VxH+0yYq6X6+1Lq+w==", "000322", true, "", false, "user83@abv.bg" },
                    { "317f785b-6bf7-474e-8293-a8ee6d8a797f", 0, "7895e9de-fe4e-47b7-be4f-25831ddb9f1d", "004486", "user82@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 31, 198, DateTimeKind.Local).AddTicks(181), true, "Alexandrov", false, null, "Jack", "user82@abv.bg", "user82@abv.bg", "AQAAAAEAACcQAAAAEApwytza/MX3fpkZJdN0kQUiz9LVIm//JjFOBTPtZpDeEvrlhxrecBu7h5j1Tyj9ew==", "008452", true, "", false, "user82@abv.bg" },
                    { "cb235131-5172-4c2e-a910-423583f1979c", 0, "099ed8f1-b80f-4656-a6b3-b87f8bdd6607", "002074", "user81@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 189, DateTimeKind.Local).AddTicks(5933), true, "Alexandrov", false, null, "Alex", "user81@abv.bg", "user81@abv.bg", "AQAAAAEAACcQAAAAELCNtVDlhvY2VeSR+HTrnSj3gD/7XJyyzOFqM0OSJ0HZIjDpvHn9RbGX7grkmrw03g==", "007251", true, "", false, "user81@abv.bg" },
                    { "3141bfe2-4ea1-4703-9e76-9480aa913aeb", 0, "3ab0e858-35bd-4679-888e-96f2dce8a1e5", "006187", "user80@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 181, DateTimeKind.Local).AddTicks(1075), true, "Johnson", false, null, "Jack", "user80@abv.bg", "user80@abv.bg", "AQAAAAEAACcQAAAAEINyGKcQJK0IcuRxhPXMbckrvjr77Y8KLF4I6kvGjE8WIueIkgoFh4Z/YN1Y6KUibQ==", "009164", true, "", false, "user80@abv.bg" },
                    { "e69ff9b9-7034-451a-a9af-f01929d6c682", 0, "abc76b45-3329-4777-b896-187de715c5b0", "002400", "user79@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 172, DateTimeKind.Local).AddTicks(2802), true, "Johnson", false, null, "Alex", "user79@abv.bg", "user79@abv.bg", "AQAAAAEAACcQAAAAEKBwY4Rtuw83Dkbs0fg8NDuv7vU8VtNhGs8jk95jN4tengccZP471RyFw4GbMBl9Vw==", "001875", true, "", false, "user79@abv.bg" },
                    { "5f310e6e-f60f-49d8-aade-521799d45867", 0, "73890619-59cd-4366-be8f-bb641e703c9e", "001028", "user78@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 162, DateTimeKind.Local).AddTicks(6815), true, "Alexandrov", false, null, "Alex", "user78@abv.bg", "user78@abv.bg", "AQAAAAEAACcQAAAAELCVqmS5TOlannASuDNhHZfibi+021yQPjJuWN8OPFkjvoNVezcbLgscYkJ/sOzi4w==", "007454", true, "", false, "user78@abv.bg" },
                    { "f7868b05-734f-4a3a-9844-fc4baef6c192", 0, "acca3802-3505-4834-90c2-f0230bef5adc", "002600", "user77@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 31, 153, DateTimeKind.Local).AddTicks(8330), true, "Johnson", false, null, "Jack", "user77@abv.bg", "user77@abv.bg", "AQAAAAEAACcQAAAAEGFUd/zFxqR7uydTTKlxsdGDO+2QoZJeYacvKzCWOvq5/tb6ODKH3I3546EvaaKupw==", "006028", true, "", false, "user77@abv.bg" },
                    { "8817f1a3-c1f8-458e-9174-89014698e0aa", 0, "2bed117c-e4d1-486f-9d78-dc7f5fde4fd4", "009085", "user51@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 938, DateTimeKind.Local).AddTicks(7841), true, "Alexandrov", false, null, "Jack", "user51@abv.bg", "user51@abv.bg", "AQAAAAEAACcQAAAAEOtw8GoTcsHToriEfnn0iVMflY9Saf02MX0t6SIJWLEB5JdYy2YeMGlNMtVIomKGgw==", "005170", true, "", false, "user51@abv.bg" },
                    { "f5f75346-834c-465c-a299-72f791085292", 0, "d330a766-ff2c-4872-bdc4-81ebd3ba0676", "004335", "user75@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 31, 136, DateTimeKind.Local).AddTicks(6438), true, "Alexandrov", false, null, "Jack", "user75@abv.bg", "user75@abv.bg", "AQAAAAEAACcQAAAAEMV2EcwsWhtk4r3gp9XJtlnJpKrZ8EKOd0s12HAyDRx6FYlYCtD14fsWAka89bbOWw==", "003818", true, "", false, "user75@abv.bg" },
                    { "e96d0d8a-6a34-4d26-afd4-f7fa9c9af648", 0, "8499d104-83da-4b84-b680-ee118e4ffd98", "004397", "user50@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 930, DateTimeKind.Local).AddTicks(5260), true, "Johnson", false, null, "Jane", "user50@abv.bg", "user50@abv.bg", "AQAAAAEAACcQAAAAEK78VsIBu4D+eKRGCNYKsYBpGK66D5/7tZL5yMP6zaON/9fHA3KtBADGUTh0fQXYbQ==", "003368", true, "", false, "user50@abv.bg" },
                    { "699d13d3-6e14-44e9-959d-30e13c24e3b6", 0, "1edbfb49-a764-453e-834b-8d1344112ac8", "005145", "user48@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 911, DateTimeKind.Local).AddTicks(8782), true, "Alexandrov", false, null, "Alex", "user48@abv.bg", "user48@abv.bg", "AQAAAAEAACcQAAAAEOpEbmjZko29hS2zuIBlyp5+3glyGBB+vPO0gCNTyGihloCCnL3XwC3+BLaeAv0y1w==", "004426", true, "", false, "user48@abv.bg" },
                    { "e5685cfe-3f9e-4366-aca6-0ddc300f4115", 0, "4ee7cefd-7511-486c-9a94-ec72dfe6bf57", "003726", "user21@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 678, DateTimeKind.Local).AddTicks(2403), true, "Alexandrov", false, null, "Jane", "user21@abv.bg", "user21@abv.bg", "AQAAAAEAACcQAAAAECcxpMDyAHDDkwSn7QiNEgq+Jc0B9x9lFU2ql7Xz1tFg7BWU75NH2serfEJHiryFSQ==", "000529", true, "", false, "user21@abv.bg" },
                    { "a7109c8e-6c15-48b2-bdf0-594301c41e95", 0, "8e98620c-12c0-45d3-8b25-59b38daf582b", "009454", "user20@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 670, DateTimeKind.Local).AddTicks(3907), true, "Johnson", false, null, "John", "user20@abv.bg", "user20@abv.bg", "AQAAAAEAACcQAAAAEGP0CldP/czJBAxZ56c1m8ijPt5O38RN4YzvbcPknD0mmmcCU2HkWRQUJeuMedg+ww==", "000066", true, "", false, "user20@abv.bg" },
                    { "30204ffa-f756-411d-be05-b7efae209e0c", 0, "a4439447-410c-4ed1-a36d-3a7a279f7b45", "005597", "user19@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 662, DateTimeKind.Local).AddTicks(2639), true, "Johnson", false, null, "John", "user19@abv.bg", "user19@abv.bg", "AQAAAAEAACcQAAAAEPk6z4JtS8uFndjm9/vYqeYcs0aFUEOZmSALeOTukAu8SEbjyUmz3aI9kOTsBtWQvg==", "004156", true, "", false, "user19@abv.bg" },
                    { "04a8ec0f-249c-4013-b104-6dcd9906fcf0", 0, "308a8c3c-d865-4f9a-8c34-4f2dc45f5d9d", "001656", "user18@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 654, DateTimeKind.Local).AddTicks(6299), true, "Alexandrov", false, null, "Jack", "user18@abv.bg", "user18@abv.bg", "AQAAAAEAACcQAAAAEMquZTHOKujk1S1006eK6dxlRoY+XvykwQCTXGY6jvORlI+P5wcDcILHtiX+CgEOuA==", "008035", true, "", false, "user18@abv.bg" },
                    { "49349abd-1cb6-4022-86fd-fbbbe7ec0c63", 0, "fd5d3528-558d-41bc-8d66-b561a36bf1eb", "002236", "user17@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 646, DateTimeKind.Local).AddTicks(7204), true, "Johnson", false, null, "Jack", "user17@abv.bg", "user17@abv.bg", "AQAAAAEAACcQAAAAEJ38qLb+CuEJRcSPwuiHobz2qs8/DVcj/APvnDERxpJqAl7snw6z7VAY7u2+Z2fzqA==", "007158", true, "", false, "user17@abv.bg" },
                    { "c97b2b92-476b-4882-bace-338e944a07f8", 0, "83d1f1a3-d6d7-438f-8aea-750a766a9139", "006670", "user16@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 638, DateTimeKind.Local).AddTicks(7733), true, "Johnson", false, null, "Jack", "user16@abv.bg", "user16@abv.bg", "AQAAAAEAACcQAAAAEOJn22NLKgpygoRL00O8Wvy5CyJE32OT2s6kNqgS/CzGIJLL/b7cqPGR5J/Z79eCeg==", "009426", true, "", false, "user16@abv.bg" },
                    { "1be25721-5914-4520-8741-b46dcbddfaa6", 0, "4af10038-7507-4e31-b4a6-423723c762ed", "003710", "user15@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 630, DateTimeKind.Local).AddTicks(5864), true, "Alexandrov", false, null, "John", "user15@abv.bg", "user15@abv.bg", "AQAAAAEAACcQAAAAEEj2gv0CwitN3ey0e5K9O3/AiHE83aD4thJ01I0x44KjjQ6wWy22sn0ha4QEO8jQWQ==", "004251", true, "", false, "user15@abv.bg" },
                    { "55759b4a-ea02-4314-8736-52c4a1ff9a17", 0, "5561c86d-ce1a-429e-82a9-e763802b93b9", "003141", "user14@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 621, DateTimeKind.Local).AddTicks(8895), true, "Alexandrov", false, null, "Jane", "user14@abv.bg", "user14@abv.bg", "AQAAAAEAACcQAAAAEMYhfd4kv2wPOraLV2si9mxkVgnPRppn/gw9RXS+1mXnzKOz20oapsFaLCevpcotVw==", "006045", true, "", false, "user14@abv.bg" },
                    { "9c250e9b-8343-4dfa-8d94-f650bda4e60d", 0, "56d70cad-5acf-4022-9149-8414b4eca9ac", "006198", "user13@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 613, DateTimeKind.Local).AddTicks(5236), true, "Alexandrov", false, null, "Alex", "user13@abv.bg", "user13@abv.bg", "AQAAAAEAACcQAAAAEBCjDIGI9SbF2WuADOPhrBR/q7jfMXBgz4D2exErdSPnXtUL3qYjyFbEHNi2LajFHw==", "000707", true, "", false, "user13@abv.bg" },
                    { "7a1e3e1d-5eb6-4c94-8081-25620210fce3", 0, "b0f4ea18-46c9-4577-a548-291691b759bb", "007517", "user12@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 602, DateTimeKind.Local).AddTicks(7739), true, "Alexandrov", false, null, "Alex", "user12@abv.bg", "user12@abv.bg", "AQAAAAEAACcQAAAAEBtifmF/BzChF/aQ4pbOoYXnZj8vNzdZmI24Koh7BwvYEn4QTZ8iS0dHbqdoRlHRUg==", "000327", true, "", false, "user12@abv.bg" },
                    { "ac39ebb6-dd26-4157-88f3-2b3e617a4b77", 0, "06d6f043-9903-46ea-a204-e4d1299b9099", "004142", "user22@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 687, DateTimeKind.Local).AddTicks(173), true, "Alexandrov", false, null, "Alex", "user22@abv.bg", "user22@abv.bg", "AQAAAAEAACcQAAAAEPFWkwxUE8SAV1HlIWPISmSei9t0pvidJHhWQu34Ok0i/Jwe0o9fJgfRdgZLb87/+A==", "000806", true, "", false, "user22@abv.bg" },
                    { "9d4d1efa-6fac-454c-8dbd-492ab1e5f64f", 0, "09375a80-2ea2-499f-877b-e89610a4330c", "008238", "user11@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 593, DateTimeKind.Local).AddTicks(6862), true, "Johnson", false, null, "Jack", "user11@abv.bg", "user11@abv.bg", "AQAAAAEAACcQAAAAEPACVHWUzeJ+VSZvxRN8XQsy7AXmgthxEZY03ch8kx2WKBUh5f3RscwxnOWGofsesg==", "002045", true, "", false, "user11@abv.bg" },
                    { "d20dfd6b-8d25-4e9c-947c-6feb1333d483", 0, "c518a6ea-a168-49ec-8815-0e56b605690c", "000567", "user9@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 572, DateTimeKind.Local).AddTicks(2727), true, "Alexandrov", false, null, "Jack", "user9@abv.bg", "user9@abv.bg", "AQAAAAEAACcQAAAAEFyaYFr9E213a2m6WmjibsfrblAP7MXgw1Uy0YVMob7JmfaAtTegdfjg2JdwYZhdGQ==", "006058", true, "", false, "user9@abv.bg" },
                    { "3b2b43e2-6a06-41fc-a23b-997ffe1d5a86", 0, "a3cf17c0-30b5-46d5-9b5f-aa90078f3eeb", "009960", "user8@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 561, DateTimeKind.Local).AddTicks(7609), true, "Johnson", false, null, "Jane", "user8@abv.bg", "user8@abv.bg", "AQAAAAEAACcQAAAAEERUUzK78Jq6Ey/YS4yRVo0u+XUFVRH+gA+e2KsiAMiNc1Je5xHT7gIh/1qmYyzkKg==", "007092", true, "", false, "user8@abv.bg" },
                    { "72bae118-1a8e-4b6d-9a22-ff1c06f7a48d", 0, "a8bfd21d-8fa7-478b-a345-256aaa81c87d", "009232", "user7@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 553, DateTimeKind.Local).AddTicks(3477), true, "Johnson", false, null, "Alex", "user7@abv.bg", "user7@abv.bg", "AQAAAAEAACcQAAAAEDxJ3eIKMO22DY7fJSnO6GDXN30PX6S5YeS4T488AC22rXcP/jZ8GKPxyRDGX11yyw==", "007284", true, "", false, "user7@abv.bg" },
                    { "b800df25-389b-464d-8a05-5ef5c5c43e96", 0, "aa3846be-8a35-45d7-baef-fe203210be7b", "001947", "user6@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 543, DateTimeKind.Local).AddTicks(3811), true, "Johnson", false, null, "Alex", "user6@abv.bg", "user6@abv.bg", "AQAAAAEAACcQAAAAEHnBta1q6HGGTPk9g+M5GtUL5yUV2cd/wNZza5CJ5jXIC/7lCCOvFIFQVcQT0pkyow==", "001326", true, "", false, "user6@abv.bg" },
                    { "5dcea69b-a35a-4033-a4ca-515e41778834", 0, "129d20d5-f226-417b-a489-7fdab1936748", "003305", "user5@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 535, DateTimeKind.Local).AddTicks(3302), true, "Johnson", false, null, "Jane", "user5@abv.bg", "user5@abv.bg", "AQAAAAEAACcQAAAAEOGMPujvqmSflC96Xc39V03Yh1Oq2daLpG+VEp/KTPz9YnAUlOolMmrT0N+kgHmFKg==", "001076", true, "", false, "user5@abv.bg" },
                    { "4264826e-90e0-421a-bddc-4a2c3e70433c", 0, "6b91e84d-1c20-446e-bee4-42bfc693b607", "008466", "user4@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 526, DateTimeKind.Local).AddTicks(1873), true, "Alexandrov", false, null, "Jane", "user4@abv.bg", "user4@abv.bg", "AQAAAAEAACcQAAAAEHq2vO2P34Hz7alubgBG/4yZ2UovntRHLoBHmRgFWe9fDLZMAM+a5Oif8s6LZj0xGw==", "003889", true, "", false, "user4@abv.bg" },
                    { "9349cb3d-2c32-4922-9ae8-f9c12e2f6574", 0, "4f040ae3-61fd-452f-8e03-7d6abe861c83", "008054", "user3@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 518, DateTimeKind.Local).AddTicks(2347), true, "Johnson", false, null, "Jane", "user3@abv.bg", "user3@abv.bg", "AQAAAAEAACcQAAAAEFeNtidnGuaUz2b0VMNfTBbRHjNHsUHny6ljJmQfMPyQhKK3KybBgZO7Ia4BijVOOg==", "008385", true, "", false, "user3@abv.bg" },
                    { "e967aedd-34ec-42d5-aabb-fe64a99a480b", 0, "40da15c5-0546-4ebb-ad0e-938303fd95f6", "000988", "user2@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 509, DateTimeKind.Local).AddTicks(3552), true, "Alexandrov", false, null, "John", "user2@abv.bg", "user2@abv.bg", "AQAAAAEAACcQAAAAEI2PCDc1ti12ekNpSUzFOhcJkrUEQGXDb8xdMb7RrgPr+PrD74FFn/xLjc+SmzKPtA==", "000543", true, "", false, "user2@abv.bg" },
                    { "e46f9d0c-a7d3-405a-9493-94d75f6c52dd", 0, "06c6b29d-8290-4baa-b16b-429a113a19ed", "000309", "user1@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 501, DateTimeKind.Local).AddTicks(469), true, "Alexandrov", false, null, "Jane", "user1@abv.bg", "user1@abv.bg", "AQAAAAEAACcQAAAAEBH29clWc3f1wU1PQejbxkTHYJpycGv2JpXFCGNSbSTu5mWnEaGsh99yZ5QV5825/g==", "000649", true, "", false, "user1@abv.bg" },
                    { "a976ff9e-2c2a-4ec2-bf1a-4e45dc48164e", 0, "7990e678-5a6c-49f8-9a1f-3d9db1edfab0", "002130", "user0@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 492, DateTimeKind.Local).AddTicks(6189), true, "Johnson", false, null, "Alex", "user0@abv.bg", "user0@abv.bg", "AQAAAAEAACcQAAAAEDaRl0vvmW0jrNwOtO4YchtlEbSdfX+YdAd9c0y4SAiFU23wKyzyuHCamd/hnojAdw==", "004907", true, "", false, "user0@abv.bg" },
                    { "8880a31f-9062-49c8-97d3-5d0ff02e3b37", 0, "8d3f3963-2875-4e76-9791-e29a0e744416", "009444", "user10@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 582, DateTimeKind.Local).AddTicks(6450), true, "Alexandrov", false, null, "Jack", "user10@abv.bg", "user10@abv.bg", "AQAAAAEAACcQAAAAEKDp0ZxsZuAYRv+b++eJ1quZV0s6+WhZwnphIEqIQ2eMP+zui0i96A7KcDWNMT64jQ==", "008065", true, "", false, "user10@abv.bg" },
                    { "515df932-7769-4581-b590-032eb391309d", 0, "0b5bd052-9836-4aae-a0e6-0f592f4aca48", "006658", "user49@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 921, DateTimeKind.Local).AddTicks(1574), true, "Johnson", false, null, "Alex", "user49@abv.bg", "user49@abv.bg", "AQAAAAEAACcQAAAAEOyrW65TCGiSR9/FHlSg/tRDRYeuF+Rjv+ZJcIxMAAma4n3sehShscKkQ5RBhNl0aw==", "005667", true, "", false, "user49@abv.bg" },
                    { "40dee55d-c036-4c00-8122-3fbe18a08291", 0, "56af1c44-c7ed-49c9-a5ee-62dbcb399b54", "009594", "user23@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 695, DateTimeKind.Local).AddTicks(83), true, "Johnson", false, null, "Jack", "user23@abv.bg", "user23@abv.bg", "AQAAAAEAACcQAAAAEFRkEOcRWKf7K/hhHe5aEwF18txfJ8Lsb5DzLkCrW15LDKdEC7Oi9ZJypgjr6tN1Tw==", "003804", true, "", false, "user23@abv.bg" },
                    { "441e75fc-9c7e-458d-b9b5-602d2ac24fff", 0, "06ef83c7-f0bc-4879-8802-4f9030ecbaa4", "001089", "user25@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 711, DateTimeKind.Local).AddTicks(6372), true, "Johnson", false, null, "John", "user25@abv.bg", "user25@abv.bg", "AQAAAAEAACcQAAAAENaVDw5gDUHxW1KfxGnxAE4LOjOxeDfsIEyFrYjq2bO0ZTJC9tkpV+duTQtdToMoUA==", "004414", true, "", false, "user25@abv.bg" },
                    { "6ef61d9e-67a3-410d-8e79-2f4ef2e73923", 0, "20649858-6c2f-4e12-b8d2-b8a57bc3a14f", "007508", "user47@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 902, DateTimeKind.Local).AddTicks(8315), true, "Alexandrov", false, null, "Jack", "user47@abv.bg", "user47@abv.bg", "AQAAAAEAACcQAAAAEGDiPsaXdaYdCGUIzhJrj5RfQ3SVwpNvPvebPWPym26J5NlCF3s5Ytbqs0ZVGA7qFw==", "003045", true, "", false, "user47@abv.bg" },
                    { "01ad6a6a-0e57-4dad-a9dd-d6f9520a0f0f", 0, "3930c605-518c-41f9-ace3-906cfcc17732", "006962", "user46@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 894, DateTimeKind.Local).AddTicks(3084), true, "Alexandrov", false, null, "Jack", "user46@abv.bg", "user46@abv.bg", "AQAAAAEAACcQAAAAEORuEk3yZonOBYyFKbvyu9lzLmdmvAPRfs36qkizTPVDY7fw4TBByGBW4BpadnV0Hw==", "000831", true, "", false, "user46@abv.bg" },
                    { "c601ea23-624b-450c-9579-0d1b7bba71be", 0, "84523d8e-6992-4316-80f6-5a573fdf9653", "009843", "user45@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 885, DateTimeKind.Local).AddTicks(5637), true, "Alexandrov", false, null, "John", "user45@abv.bg", "user45@abv.bg", "AQAAAAEAACcQAAAAEE3yemfifb0dpeBAmKxqS9iumNoR8zc6Iskl746PN0ZG7bHHz/OUTU+4diMfrbCejg==", "002713", true, "", false, "user45@abv.bg" },
                    { "82feddcd-2cfb-495a-a05e-fb55a4936ab9", 0, "c4163dd0-226d-4782-b7fc-2aa2b9711494", "000626", "user44@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 877, DateTimeKind.Local).AddTicks(617), true, "Johnson", false, null, "Alex", "user44@abv.bg", "user44@abv.bg", "AQAAAAEAACcQAAAAEMwd4vnHh8NsuXJmfYUatDdX7Os2lnuyxBJ/kuwOTtYRYJ6g0Q8E9q74np15KVN1ug==", "001931", true, "", false, "user44@abv.bg" },
                    { "2225cf23-2c7b-4035-94fe-4ef508c2da67", 0, "f2ac6a86-8d7a-48ee-8231-f378984dc314", "003602", "user43@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 868, DateTimeKind.Local).AddTicks(101), true, "Johnson", false, null, "Alex", "user43@abv.bg", "user43@abv.bg", "AQAAAAEAACcQAAAAEJCl35rgfHNEoA6qyCgluRpaI2rwpLHEova8wTyytfqTsVRyJoBKDW3P4DI/uMDbIA==", "000359", true, "", false, "user43@abv.bg" },
                    { "32a5628d-7679-48d4-b81e-92ef61d50b81", 0, "ef386015-59dc-4857-b483-0c9c80f8e5dc", "002473", "user42@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 859, DateTimeKind.Local).AddTicks(7408), true, "Alexandrov", false, null, "Jane", "user42@abv.bg", "user42@abv.bg", "AQAAAAEAACcQAAAAEO1BBCZmESAXIZWC/YvPm2ahUopX9Hv60gmj28UaW8E9zzt8P1jFOlOQTLFeZvZm2Q==", "006811", true, "", false, "user42@abv.bg" },
                    { "f706bf8c-ffba-4985-a1c4-5458b05cb7e9", 0, "d0e05202-fdbe-4e77-86c4-39bf35cf0174", "007178", "user41@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 850, DateTimeKind.Local).AddTicks(8542), true, "Johnson", false, null, "Jack", "user41@abv.bg", "user41@abv.bg", "AQAAAAEAACcQAAAAEIa9vUdZShOaAyTGEisgZQSCfSPEKprUMhMLevWQzhcqFYlGhFo4DZZ2blfC/hfZFQ==", "001829", true, "", false, "user41@abv.bg" },
                    { "744619b6-8c7f-4a8a-a1c9-767df6828f83", 0, "b8a68569-bff4-4f34-9610-93b4ef41df0e", "009733", "user40@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 841, DateTimeKind.Local).AddTicks(3464), true, "Johnson", false, null, "Jane", "user40@abv.bg", "user40@abv.bg", "AQAAAAEAACcQAAAAEJ8fGTasLx51VjxMdJRUYJliJVIJqXtM0oF1uVxXeExGsA8GMS0oR7vfo8UhUHqdng==", "009166", true, "", false, "user40@abv.bg" },
                    { "90bf7e12-ba0d-4529-ac3d-10408a10b48e", 0, "9e376df0-a432-4c52-bd30-57962d3c4fbc", "003284", "user39@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 831, DateTimeKind.Local).AddTicks(7694), true, "Johnson", false, null, "Alex", "user39@abv.bg", "user39@abv.bg", "AQAAAAEAACcQAAAAEK8XP42X7U69ZWOa0JficsjNixs72R1kW9d2fDP0JOpAih98I/g9whtd7zr+OR5OEQ==", "004542", true, "", false, "user39@abv.bg" },
                    { "89bfc529-d0b8-480f-9194-5fb38d831e4d", 0, "c8723a77-f3c3-4b2d-9579-7ebf80bc5ef5", "002780", "user38@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 821, DateTimeKind.Local).AddTicks(194), true, "Johnson", false, null, "Alex", "user38@abv.bg", "user38@abv.bg", "AQAAAAEAACcQAAAAENkBxJrJ4yd5myGoYUHER8pDJYhGjw4yMv5OChLg9tYR0VGQsMkabAmhBrFk+giW1A==", "002873", true, "", false, "user38@abv.bg" },
                    { "999daf2b-0bf0-4f99-820e-009c1da8a85b", 0, "175fabf6-99fc-47d0-b878-cf851c8ab6f3", "000183", "user24@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 703, DateTimeKind.Local).AddTicks(5301), true, "Johnson", false, null, "Jane", "user24@abv.bg", "user24@abv.bg", "AQAAAAEAACcQAAAAEO3vTvpN4Q8AlCrFLGLXB4Dy+UMJhfhb7OBJLSegMAxmd3Jgg2ahEqkH4j/3X6LM4A==", "009007", true, "", false, "user24@abv.bg" },
                    { "8f76f16c-b419-466c-a699-a381f5dbbb42", 0, "e72eb565-cf1e-444d-8d40-3022ecacba2c", "009453", "user37@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 812, DateTimeKind.Local).AddTicks(9308), true, "Alexandrov", false, null, "Jack", "user37@abv.bg", "user37@abv.bg", "AQAAAAEAACcQAAAAEJSV1/CzHF7S2vAhBEI4Q/tBmWQz/R07Ocb0X3QeashRIIBvgy0Fb5maSUWKriLBVQ==", "009325", true, "", false, "user37@abv.bg" },
                    { "87a7ecc6-d13f-4bad-b2b0-a026ae797c81", 0, "2c217f9e-cf34-4992-b1d4-45295a3cf2e2", "002358", "user35@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 796, DateTimeKind.Local).AddTicks(294), true, "Alexandrov", false, null, "John", "user35@abv.bg", "user35@abv.bg", "AQAAAAEAACcQAAAAEDiN0hmSjZKAvTZ5gFz7G9TmfD0PrVCQ2GAYmUlnzdrFYO3l6AtKgwqnt4NfcQf57w==", "007793", true, "", false, "user35@abv.bg" },
                    { "23cf7c2f-acd3-45c1-9ea5-b59eb515db2e", 0, "54e633e0-072d-42b2-9494-3327e451838c", "009361", "user34@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 787, DateTimeKind.Local).AddTicks(8682), true, "Alexandrov", false, null, "Jane", "user34@abv.bg", "user34@abv.bg", "AQAAAAEAACcQAAAAEIUeyNqFyACGssdJbQPS4Ce3edD7mvZv521CIRFpF8fvWhJRLPPA1yrSZ79UwhIiZA==", "008898", true, "", false, "user34@abv.bg" },
                    { "a8fd7085-15b7-4388-ad92-d0a7f8dfac02", 0, "6b96aa97-c353-4e04-bd7c-4a5840b185d2", "007429", "user33@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 778, DateTimeKind.Local).AddTicks(6358), true, "Alexandrov", false, null, "Alex", "user33@abv.bg", "user33@abv.bg", "AQAAAAEAACcQAAAAEBLppbBhY6W9zlgjeqzZAdB56uNgYdxblgYgBYo7ZbfZpnRAKKGVFwVUzrIgxSM7iQ==", "007724", true, "", false, "user33@abv.bg" },
                    { "57c6dc2b-d42b-46e7-913c-c1ac44dc54bc", 0, "b0c8080c-e400-4348-a06f-f103e23a48a9", "006550", "user32@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 770, DateTimeKind.Local).AddTicks(2552), true, "Alexandrov", false, null, "Alex", "user32@abv.bg", "user32@abv.bg", "AQAAAAEAACcQAAAAENRNV3vA0vYNgFEFy4cfrSXw4yX6ElrL3Q2j/pt0TOwd1J4k+hRBFvVSaMWDRPOLdQ==", "005529", true, "", false, "user32@abv.bg" },
                    { "a382f457-031f-430c-a779-ad6066f00e59", 0, "783a178c-9d02-4369-80e4-b4943f990503", "008295", "user31@abv.bg", true, null, "Jack", new DateTime(2023, 3, 16, 18, 45, 30, 761, DateTimeKind.Local).AddTicks(3683), true, "Johnson", false, null, "Alex", "user31@abv.bg", "user31@abv.bg", "AQAAAAEAACcQAAAAEIl0QYXzPl2zP2oJ+blUrjthPVtsRCMx9TuVlGoQdW0nmyxw2M5gbdqK4TR1vQYwgw==", "000111", true, "", false, "user31@abv.bg" },
                    { "caa54bf4-373c-48b3-a1c3-c5af356fe05d", 0, "84489793-ebac-4092-b1cf-763b488ee575", "001851", "user30@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 753, DateTimeKind.Local).AddTicks(2429), true, "Alexandrov", false, null, "John", "user30@abv.bg", "user30@abv.bg", "AQAAAAEAACcQAAAAEBvtxUNoMYbYyIp9Z3aOoX3nVucbjmU/OBGZ0ymiJaZjPSanE1YXVzTipFlvsTiCkQ==", "004482", true, "", false, "user30@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FireDate", "FirstName", "HireDate", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c2f8a7a5-6a3f-469b-bcb4-3f85af10cc9b", 0, "93e73ab0-5ba5-4aa7-83e3-feb3a4a5988f", "002183", "user29@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 745, DateTimeKind.Local).AddTicks(795), true, "Alexandrov", false, null, "Jane", "user29@abv.bg", "user29@abv.bg", "AQAAAAEAACcQAAAAEPRJ7skZWsZtwpjOucR/ygaTbeXshDQfEP4AmWQ/hCO090dsFHtdu+Bih9ibDg+Jwg==", "004788", true, "", false, "user29@abv.bg" },
                    { "f521e9c8-1992-461b-9056-c65bdf80f32a", 0, "ce7af5d9-a19a-44ad-a4f4-c330565d06f4", "004312", "user28@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 736, DateTimeKind.Local).AddTicks(9531), true, "Alexandrov", false, null, "Jack", "user28@abv.bg", "user28@abv.bg", "AQAAAAEAACcQAAAAEC2SGJuIposaoDtWmLJHJDar+KYeYAi57YxRCbase/qHjVl9QLHjYuLl1/d3tIawvQ==", "000408", true, "", false, "user28@abv.bg" },
                    { "53113d5a-7904-4b09-a41e-0a82452b5644", 0, "803be067-609b-4fad-ba40-042dbe2baeea", "007571", "user27@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 728, DateTimeKind.Local).AddTicks(2263), true, "Alexandrov", false, null, "Jane", "user27@abv.bg", "user27@abv.bg", "AQAAAAEAACcQAAAAEAOPpcHdOx9PzKv5g8giBJEeD+ZR4OxvFJ1hyKiZ9k0HXmdxCg20G/f2NhaNBZkMnw==", "007297", true, "", false, "user27@abv.bg" },
                    { "f05abb57-5fe4-4d1f-972c-516b5768598c", 0, "2431f985-4ad3-483e-b6c8-da02c296e4bf", "007522", "user26@abv.bg", true, null, "Alex", new DateTime(2023, 3, 16, 18, 45, 30, 720, DateTimeKind.Local).AddTicks(724), true, "Alexandrov", false, null, "Alex", "user26@abv.bg", "user26@abv.bg", "AQAAAAEAACcQAAAAEF3RkSQj84EuqI6NSIjZ0z4s+UDhLfiCQaUdC/z2i52E339jcynMfDA/cqDKwAFiQA==", "004715", true, "", false, "user26@abv.bg" },
                    { "b26593e8-a8f4-4621-838e-3aa8e357a634", 0, "e0100a31-9a69-42c4-b915-9c7103bd44cf", "004230", "user36@abv.bg", true, null, "Jane", new DateTime(2023, 3, 16, 18, 45, 30, 804, DateTimeKind.Local).AddTicks(6918), true, "Johnson", false, null, "John", "user36@abv.bg", "user36@abv.bg", "AQAAAAEAACcQAAAAEJdFSh0uZmVIqwkCgBCaj9bIs3U/Wg1G2b8bI1ys/L7pV4BRVuuKxOsq2JNcX54Weg==", "006653", true, "", false, "user36@abv.bg" },
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", 0, "a214fa04-8c13-41d6-a6e1-bdeb997b7131", "8603129931", "admin@abv.bg", true, null, "John", new DateTime(2023, 3, 16, 18, 45, 30, 486, DateTimeKind.Local).AddTicks(9087), true, "Johnson", false, null, "Johnny", "ADMIN@ABV.BG", "ADMIN@ABV.BG", "AQAAAAEAACcQAAAAEKUsJm1RN2z+fB944D2r9X15VfA8kE10MJD+hOQrOQNoyK2ajQ3UG3KLFeAYe8Pcww==", "1111111111", true, "", false, "admin@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8e445864-a24d-4543-a6c6-9443d048cdb9", "6ecf672a-137e-4458-91b1-120bd23252c4" },
                    { "22b970d9-a138-441b-876e-906a2a80494a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "6f02b90d-5286-48e0-afeb-4f4b9f51d471", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "691c2734-906d-4244-bc38-34b8f1c422c4", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "973b3385-2c52-4e43-973e-742c5359bb10", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "6ec19c6b-7ae7-4df0-bb7a-1110d4b3671a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "bfee186b-8f7f-47bf-ac1a-c96c31f43885", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "2e2e8e50-23a6-4e49-8188-8f074f7fb7a7", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "56711d20-388a-4f66-86ad-18adccc6f80d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ed024312-f08c-42a3-9352-0a99fe6a67ab", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f355fbfe-827d-4f58-84df-89fe35f5cde9", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5368e623-15e5-468f-9520-709495f69c6b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "24d6c12c-8d02-4e5a-8090-7e9c56e18095", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5385dbad-b1b3-4b2d-8b32-cbe801d10aac", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "d5bbd992-b8a9-470a-948f-1806318c7807", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9ab9700e-aab5-4987-9bd9-20b19d0bac0a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "171b17a3-bdf5-4e8b-a973-9695a905a338", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "7865dbbc-2034-45ef-924f-a19c6a7f5c8a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "83bd512b-329e-4f95-b7c1-9e7b45cc485b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ff2a668d-148a-42fa-82a6-58f5f7cbb15e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "0545f90a-70d8-4935-a049-95cf2d764afc", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "8817f1a3-c1f8-458e-9174-89014698e0aa", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "40055042-e587-4376-a14c-f42d858661a1", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9f1b6d0f-d448-4d04-998b-dfad94deb32a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "3844a9df-77a3-4109-8ec9-eb8b50b77aaf", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f5f75346-834c-465c-a299-72f791085292", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "2138aa1f-9037-41f4-955c-7f218c5b0c87", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "c806d3d2-b999-49f6-98a8-5e4beca42e4f", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ebfbfc66-bd23-4aaa-8a8a-6e6d4cc3bed0", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "bab17fa2-ff82-4dea-babc-527f16db3e78", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "81c2396b-664d-4725-aea3-111cb1668a14", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5d7e0bc8-c6f8-4b3f-93e8-05b2d99e061e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "1c84c71d-a231-4b0a-92f0-97569eff3cc7", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "be539df8-60ce-4dec-a1d0-e86bd541fe12", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "7f82a25e-b33f-4bb6-b038-819eccf813ae", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "4f8f4799-ffe4-47da-9e85-7df893f60687", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e96d0d8a-6a34-4d26-afd4-f7fa9c9af648", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "12c49bdf-8b79-46fa-93bd-9c806a42a146", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "30d582e8-70e8-4e53-a189-ff87f6d4ff52", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "b0cd465c-70a4-41ed-84da-865165952cbf", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "42835c46-e5ec-4229-aac3-08225ff7459e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "317f785b-6bf7-474e-8293-a8ee6d8a797f", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "cb235131-5172-4c2e-a910-423583f1979c", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "3141bfe2-4ea1-4703-9e76-9480aa913aeb", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e69ff9b9-7034-451a-a9af-f01929d6c682", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5f310e6e-f60f-49d8-aade-521799d45867", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f7868b05-734f-4a3a-9844-fc4baef6c192", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ece9887d-2925-4beb-95a1-8f6860452b07", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "b5e3b998-84e8-4fea-898f-4a02df84fb50", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "310a0bf1-44fa-45ef-9cc2-c80291d88f15", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "515df932-7769-4581-b590-032eb391309d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "6ef61d9e-67a3-410d-8e79-2f4ef2e73923", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "a7109c8e-6c15-48b2-bdf0-594301c41e95", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "30204ffa-f756-411d-be05-b7efae209e0c", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "04a8ec0f-249c-4013-b104-6dcd9906fcf0", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "49349abd-1cb6-4022-86fd-fbbbe7ec0c63", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "c97b2b92-476b-4882-bace-338e944a07f8", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "1be25721-5914-4520-8741-b46dcbddfaa6", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "55759b4a-ea02-4314-8736-52c4a1ff9a17", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9c250e9b-8343-4dfa-8d94-f650bda4e60d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "7a1e3e1d-5eb6-4c94-8081-25620210fce3", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9d4d1efa-6fac-454c-8dbd-492ab1e5f64f", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "8880a31f-9062-49c8-97d3-5d0ff02e3b37", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "d20dfd6b-8d25-4e9c-947c-6feb1333d483", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "3b2b43e2-6a06-41fc-a23b-997ffe1d5a86", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "72bae118-1a8e-4b6d-9a22-ff1c06f7a48d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "b800df25-389b-464d-8a05-5ef5c5c43e96", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "5dcea69b-a35a-4033-a4ca-515e41778834", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "4264826e-90e0-421a-bddc-4a2c3e70433c", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "9349cb3d-2c32-4922-9ae8-f9c12e2f6574", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e967aedd-34ec-42d5-aabb-fe64a99a480b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e46f9d0c-a7d3-405a-9493-94d75f6c52dd", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "a976ff9e-2c2a-4ec2-bf1a-4e45dc48164e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "e5685cfe-3f9e-4366-aca6-0ddc300f4115", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "ac39ebb6-dd26-4157-88f3-2b3e617a4b77", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "40dee55d-c036-4c00-8122-3fbe18a08291", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "999daf2b-0bf0-4f99-820e-009c1da8a85b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "01ad6a6a-0e57-4dad-a9dd-d6f9520a0f0f", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "c601ea23-624b-450c-9579-0d1b7bba71be", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "82feddcd-2cfb-495a-a05e-fb55a4936ab9", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "2225cf23-2c7b-4035-94fe-4ef508c2da67", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "32a5628d-7679-48d4-b81e-92ef61d50b81", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f706bf8c-ffba-4985-a1c4-5458b05cb7e9", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "744619b6-8c7f-4a8a-a1c9-767df6828f83", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "90bf7e12-ba0d-4529-ac3d-10408a10b48e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "89bfc529-d0b8-480f-9194-5fb38d831e4d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "8f76f16c-b419-466c-a699-a381f5dbbb42", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "699d13d3-6e14-44e9-959d-30e13c24e3b6", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "b26593e8-a8f4-4621-838e-3aa8e357a634", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "23cf7c2f-acd3-45c1-9ea5-b59eb515db2e", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "a8fd7085-15b7-4388-ad92-d0a7f8dfac02", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "57c6dc2b-d42b-46e7-913c-c1ac44dc54bc", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "a382f457-031f-430c-a779-ad6066f00e59", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "caa54bf4-373c-48b3-a1c3-c5af356fe05d", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "c2f8a7a5-6a3f-469b-bcb4-3f85af10cc9b", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f521e9c8-1992-461b-9056-c65bdf80f32a", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "53113d5a-7904-4b09-a41e-0a82452b5644", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "f05abb57-5fe4-4d1f-972c-516b5768598c", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "441e75fc-9c7e-458d-b9b5-602d2ac24fff", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "87a7ecc6-d13f-4bad-b2b0-a026ae797c81", "863f63b8-943c-40a1-bae5-529fc38ce420" },
                    { "36939b51-52e7-4b14-b3de-f5b2f1465bbb", "863f63b8-943c-40a1-bae5-529fc38ce420" }
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
                column: "ReservationId");
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
