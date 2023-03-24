﻿// <auto-generated />
using System;
using Hotel_Reservation_Manager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotel_Reservation_Manager.data.migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230324191043_RenamedEGNtoUCN")]
    partial class RenamedEGNtoUCN
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hotel_Reservation_Manager.Data.Models.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdult")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservationId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = "480b301b-e461-48ab-9741-c2e11b1e2df2",
                            Email = "customer0@abv.bg",
                            FirstName = "John",
                            IsAdult = false,
                            LastName = "Johnson",
                            PhoneNumber = "739296"
                        },
                        new
                        {
                            Id = "0a825efc-5b41-4877-9f53-89c817683050",
                            Email = "customer1@abv.bg",
                            FirstName = "Alex",
                            IsAdult = false,
                            LastName = "Johnson",
                            PhoneNumber = "936085"
                        },
                        new
                        {
                            Id = "fb5ee98f-bee2-4a8e-8bd8-5e75327f6e14",
                            Email = "customer2@abv.bg",
                            FirstName = "Jane",
                            IsAdult = true,
                            LastName = "Alexandrov",
                            PhoneNumber = "754923"
                        },
                        new
                        {
                            Id = "94afd613-898b-4225-8e1f-5a5bce021517",
                            Email = "customer3@abv.bg",
                            FirstName = "Jane",
                            IsAdult = false,
                            LastName = "Alexandrov",
                            PhoneNumber = "467388"
                        },
                        new
                        {
                            Id = "3196e2bf-e3e0-4daa-bf52-af12e22211ac",
                            Email = "customer4@abv.bg",
                            FirstName = "Jack",
                            IsAdult = true,
                            LastName = "Johnson",
                            PhoneNumber = "787033"
                        });
                });

            modelBuilder.Entity("Hotel_Reservation_Manager.Data.Models.Reservation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AccommodationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasAllInclusive")
                        .HasColumnType("bit");

                    b.Property<bool>("HasBreakfast")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LeaveDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("RoomId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Hotel_Reservation_Manager.Data.Models.Room", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<decimal>("PricePerBedAdult")
                        .HasColumnType("money");

                    b.Property<decimal>("PricePerBedChild")
                        .HasColumnType("money");

                    b.Property<string>("ReservationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId")
                        .IsUnique()
                        .HasFilter("[ReservationId] IS NOT NULL");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Hotel_Reservation_Manager.Data.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UCN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "8e445864-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d780548b-d4ec-4844-86cf-d0889f52a49c",
                            Email = "admin@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "John",
                            HireDate = new DateTime(2023, 3, 24, 21, 10, 43, 69, DateTimeKind.Local).AddTicks(9824),
                            IsActive = true,
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            MiddleName = "Johnny",
                            NormalizedEmail = "ADMIN@ABV.BG",
                            NormalizedUserName = "ADMIN@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEEMYQBVBAF7ROMVZXAIKs1XeGaXWu/FALq/CeRwWZasI19DYO1xLNn87WqLjhIKwHw==",
                            PhoneNumber = "1111111111",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "8603129931",
                            UserName = "admin@abv.bg"
                        },
                        new
                        {
                            Id = "af6d324c-f366-4c8e-8746-302aacfed1f3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "021272dd-9229-442c-bafc-5a77ecf9bd31",
                            Email = "user0@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "John",
                            HireDate = new DateTime(2023, 3, 24, 21, 10, 43, 76, DateTimeKind.Local).AddTicks(5978),
                            IsActive = true,
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            MiddleName = "Jack",
                            NormalizedEmail = "user0@abv.bg",
                            NormalizedUserName = "user0@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEJssXhmbYrfE0sF1CaMyzRc6BAVodPgdZ+TQY0ShE3lnMT8IkbzrF7ltPuXpEuM4jA==",
                            PhoneNumber = "001715",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "006204",
                            UserName = "user0@abv.bg"
                        },
                        new
                        {
                            Id = "b7ba7229-d592-4b02-9d1d-37db54511f4d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "33f24356-f09c-4e0b-bd3d-2f5b234b2bf8",
                            Email = "user1@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Alex",
                            HireDate = new DateTime(2023, 3, 24, 21, 10, 43, 85, DateTimeKind.Local).AddTicks(1905),
                            IsActive = true,
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            MiddleName = "Alex",
                            NormalizedEmail = "user1@abv.bg",
                            NormalizedUserName = "user1@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEGi0Dj3N58qVnUaGmCeaAOgBaZ+dPLnBhCLRMpgJjfwZYcs2qXO2Keznw16QHQXR+Q==",
                            PhoneNumber = "009673",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "009695",
                            UserName = "user1@abv.bg"
                        },
                        new
                        {
                            Id = "1cdde740-25f6-41df-9d01-c00278f24c35",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fcac4dc9-4aea-42dc-9ca2-47e77504c699",
                            Email = "user2@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Alex",
                            HireDate = new DateTime(2023, 3, 24, 21, 10, 43, 93, DateTimeKind.Local).AddTicks(1260),
                            IsActive = true,
                            LastName = "Alexandrov",
                            LockoutEnabled = false,
                            MiddleName = "Jack",
                            NormalizedEmail = "user2@abv.bg",
                            NormalizedUserName = "user2@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEMev3JIBsJ4qinSoOuSIX2iUDz4d9yxgOECivMNRBK0BQYeqU86DTz0iwyFEr2PTeg==",
                            PhoneNumber = "004502",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "005371",
                            UserName = "user2@abv.bg"
                        },
                        new
                        {
                            Id = "68d93d33-181e-4313-bc4d-6c264cce77d1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0b696888-c46f-4e6b-9c32-5019bd4b63d1",
                            Email = "user3@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Jack",
                            HireDate = new DateTime(2023, 3, 24, 21, 10, 43, 101, DateTimeKind.Local).AddTicks(3137),
                            IsActive = true,
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            MiddleName = "John",
                            NormalizedEmail = "user3@abv.bg",
                            NormalizedUserName = "user3@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEAsGMO/V0fTHWMcHevm2aP6VhtYSJZd3bk0zfboERQ/BOHU7TQsAtTK/DaqeNd7x9Q==",
                            PhoneNumber = "002768",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "001100",
                            UserName = "user3@abv.bg"
                        },
                        new
                        {
                            Id = "92f2783e-baa7-46fa-8a0b-565ffb70b3d9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f758585f-e6b4-4d79-baff-2c05725fae95",
                            Email = "user4@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Alex",
                            HireDate = new DateTime(2023, 3, 24, 21, 10, 43, 109, DateTimeKind.Local).AddTicks(4019),
                            IsActive = true,
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            MiddleName = "Alex",
                            NormalizedEmail = "user4@abv.bg",
                            NormalizedUserName = "user4@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEIatIzkBnMV+XiMd8mVVsTiDPPGnsCzoB8AebOHbJjzmKXT3hWWLAwKSqXmYqfcS4g==",
                            PhoneNumber = "003676",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "002372",
                            UserName = "user4@abv.bg"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "735c9bdf-7979-4891-a8c7-57b20039f54c",
                            ConcurrencyStamp = "87c141d7-6260-4dd6-8293-31184ddd94ea",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "bf5ef909-e344-4383-a563-b09f259928a6",
                            ConcurrencyStamp = "b2a00ea8-5050-4d43-94ff-c84120c39705",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "8e445864-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "735c9bdf-7979-4891-a8c7-57b20039f54c"
                        },
                        new
                        {
                            UserId = "af6d324c-f366-4c8e-8746-302aacfed1f3",
                            RoleId = "bf5ef909-e344-4383-a563-b09f259928a6"
                        },
                        new
                        {
                            UserId = "b7ba7229-d592-4b02-9d1d-37db54511f4d",
                            RoleId = "bf5ef909-e344-4383-a563-b09f259928a6"
                        },
                        new
                        {
                            UserId = "1cdde740-25f6-41df-9d01-c00278f24c35",
                            RoleId = "bf5ef909-e344-4383-a563-b09f259928a6"
                        },
                        new
                        {
                            UserId = "68d93d33-181e-4313-bc4d-6c264cce77d1",
                            RoleId = "bf5ef909-e344-4383-a563-b09f259928a6"
                        },
                        new
                        {
                            UserId = "92f2783e-baa7-46fa-8a0b-565ffb70b3d9",
                            RoleId = "bf5ef909-e344-4383-a563-b09f259928a6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Hotel_Reservation_Manager.Data.Models.Customer", b =>
                {
                    b.HasOne("Hotel_Reservation_Manager.Data.Models.Reservation", "Reservation")
                        .WithMany("Customers")
                        .HasForeignKey("ReservationId");
                });

            modelBuilder.Entity("Hotel_Reservation_Manager.Data.Models.Reservation", b =>
                {
                    b.HasOne("Hotel_Reservation_Manager.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Hotel_Reservation_Manager.Data.Models.Room", b =>
                {
                    b.HasOne("Hotel_Reservation_Manager.Data.Models.Reservation", "Reservation")
                        .WithOne("Room")
                        .HasForeignKey("Hotel_Reservation_Manager.Data.Models.Room", "ReservationId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Hotel_Reservation_Manager.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Hotel_Reservation_Manager.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel_Reservation_Manager.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Hotel_Reservation_Manager.Data.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
