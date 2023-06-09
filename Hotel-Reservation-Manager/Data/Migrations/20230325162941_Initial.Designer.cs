﻿// <auto-generated />
using System;
using Hotel_Reservation_Manager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotel_Reservation_Manager.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230325162941_Initial")]
    partial class Initial
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
                            Id = "9d76f617-5197-480e-a8b2-59bb73df934b",
                            Email = "customer0@abv.bg",
                            FirstName = "Jane",
                            IsAdult = false,
                            LastName = "Johnson",
                            PhoneNumber = "988418"
                        },
                        new
                        {
                            Id = "8d0685ff-894c-42bf-8371-82b3e7a51344",
                            Email = "customer1@abv.bg",
                            FirstName = "Jack",
                            IsAdult = false,
                            LastName = "Johnson",
                            PhoneNumber = "953794"
                        },
                        new
                        {
                            Id = "98abd15c-5bcc-46f3-96b7-00fb9de86194",
                            Email = "customer2@abv.bg",
                            FirstName = "Jack",
                            IsAdult = false,
                            LastName = "Johnson",
                            PhoneNumber = "447797"
                        },
                        new
                        {
                            Id = "4a1cc43a-2e9e-4b10-95f8-2f53de9691f1",
                            Email = "customer3@abv.bg",
                            FirstName = "John",
                            IsAdult = true,
                            LastName = "Johnson",
                            PhoneNumber = "209110"
                        },
                        new
                        {
                            Id = "f3e560ff-c5f0-4a98-9612-d5ff53f68fb9",
                            Email = "customer4@abv.bg",
                            FirstName = "Jack",
                            IsAdult = false,
                            LastName = "Johnson",
                            PhoneNumber = "525575"
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
                            ConcurrencyStamp = "b3140740-1bca-4f51-a5ea-833fcb5eccbc",
                            Email = "admin@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "John",
                            HireDate = new DateTime(2023, 3, 25, 18, 29, 41, 20, DateTimeKind.Local).AddTicks(6698),
                            IsActive = true,
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            MiddleName = "Johnny",
                            NormalizedEmail = "ADMIN@ABV.BG",
                            NormalizedUserName = "ADMIN@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEM4wCwlze62EoJsrcJwiclaxktm8ROCm8aVgy+R6pxJ2Z4rDSdFD36leZ40LxwalUA==",
                            PhoneNumber = "1111111111",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "8603129931",
                            UserName = "admin@abv.bg"
                        },
                        new
                        {
                            Id = "2de9d5f0-1c53-4aaf-885a-e83c17ea4950",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bb1f6f40-acf4-48e1-a22f-b2f389f9ced7",
                            Email = "user0@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Alex",
                            HireDate = new DateTime(2023, 3, 25, 18, 29, 41, 26, DateTimeKind.Local).AddTicks(6630),
                            IsActive = true,
                            LastName = "Alexandrov",
                            LockoutEnabled = false,
                            MiddleName = "Jane",
                            NormalizedEmail = "user0@abv.bg",
                            NormalizedUserName = "user0@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEIq7A4h2D44yR8KIV0yIHkyOznjjkb87+0+4B/Yb3MIbpVyKWligVmiewfJcMp3+QA==",
                            PhoneNumber = "005783",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "006695",
                            UserName = "user0@abv.bg"
                        },
                        new
                        {
                            Id = "0eebc067-bed8-41aa-8505-3e09dcbaace4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9a10f496-5501-400e-b6f0-350c9c9b8785",
                            Email = "user1@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Jane",
                            HireDate = new DateTime(2023, 3, 25, 18, 29, 41, 36, DateTimeKind.Local).AddTicks(483),
                            IsActive = true,
                            LastName = "Alexandrov",
                            LockoutEnabled = false,
                            MiddleName = "Alex",
                            NormalizedEmail = "user1@abv.bg",
                            NormalizedUserName = "user1@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEDFZE53NVDrcFoDXqdo95MDHplw0vOSXLQVSWwQjsFPTOLWjyyOTOxb2mxA37N0w6A==",
                            PhoneNumber = "000315",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "008982",
                            UserName = "user1@abv.bg"
                        },
                        new
                        {
                            Id = "7531416f-579f-4c1b-bc20-1a014f071f6d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "260e9a22-0d47-48a2-9cd1-40c832b213d9",
                            Email = "user2@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Jane",
                            HireDate = new DateTime(2023, 3, 25, 18, 29, 41, 44, DateTimeKind.Local).AddTicks(9280),
                            IsActive = true,
                            LastName = "Alexandrov",
                            LockoutEnabled = false,
                            MiddleName = "John",
                            NormalizedEmail = "user2@abv.bg",
                            NormalizedUserName = "user2@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEMhTNaW2SEXQykkqdM7KrnX4oug1g1gQRMWNYV2dL4eEjek9Z6C1dXdAsJnyQxBoUg==",
                            PhoneNumber = "002967",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "005612",
                            UserName = "user2@abv.bg"
                        },
                        new
                        {
                            Id = "7cdcf7d4-0b82-4916-82e8-a669796ee3c2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f94044fe-4247-496c-b38d-e626ed7ba8eb",
                            Email = "user3@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Alex",
                            HireDate = new DateTime(2023, 3, 25, 18, 29, 41, 62, DateTimeKind.Local).AddTicks(3142),
                            IsActive = true,
                            LastName = "Alexandrov",
                            LockoutEnabled = false,
                            MiddleName = "John",
                            NormalizedEmail = "user3@abv.bg",
                            NormalizedUserName = "user3@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEDyM6nTVy5JMhfwjT6n9wEBalMm8FlBQydpdWJ3XaeL5RgpyWZiDZO6Co/M+M2do5Q==",
                            PhoneNumber = "003009",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "007130",
                            UserName = "user3@abv.bg"
                        },
                        new
                        {
                            Id = "d43f19f8-6f5d-4a29-a1fe-0505e250ac14",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b41bd786-2b91-4e83-aafc-c9b1d16d4567",
                            Email = "user4@abv.bg",
                            EmailConfirmed = true,
                            FirstName = "Jack",
                            HireDate = new DateTime(2023, 3, 25, 18, 29, 41, 70, DateTimeKind.Local).AddTicks(5196),
                            IsActive = true,
                            LastName = "Alexandrov",
                            LockoutEnabled = false,
                            MiddleName = "John",
                            NormalizedEmail = "user4@abv.bg",
                            NormalizedUserName = "user4@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEEzTzkVnmupsibjpYstr63PaXp+5IJHO+fmjNLoJLzD9/HAm67vKXQw2achrQCTXXg==",
                            PhoneNumber = "007354",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UCN = "008862",
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
                            Id = "66f8c581-f6f0-406c-9af0-35e7d2567b09",
                            ConcurrencyStamp = "04d4e941-0686-4e51-89de-003129cfe1a0",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "f40d8b19-06cc-4554-b6cb-67414611c0df",
                            ConcurrencyStamp = "88ae0370-cfdb-49ed-b1ae-d9a3aa9ad35f",
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
                            RoleId = "66f8c581-f6f0-406c-9af0-35e7d2567b09"
                        },
                        new
                        {
                            UserId = "2de9d5f0-1c53-4aaf-885a-e83c17ea4950",
                            RoleId = "f40d8b19-06cc-4554-b6cb-67414611c0df"
                        },
                        new
                        {
                            UserId = "0eebc067-bed8-41aa-8505-3e09dcbaace4",
                            RoleId = "f40d8b19-06cc-4554-b6cb-67414611c0df"
                        },
                        new
                        {
                            UserId = "7531416f-579f-4c1b-bc20-1a014f071f6d",
                            RoleId = "f40d8b19-06cc-4554-b6cb-67414611c0df"
                        },
                        new
                        {
                            UserId = "7cdcf7d4-0b82-4916-82e8-a669796ee3c2",
                            RoleId = "f40d8b19-06cc-4554-b6cb-67414611c0df"
                        },
                        new
                        {
                            UserId = "d43f19f8-6f5d-4a29-a1fe-0505e250ac14",
                            RoleId = "f40d8b19-06cc-4554-b6cb-67414611c0df"
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
