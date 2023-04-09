using Hotel_Reservation_Manager.Data.Enums;
using Hotel_Reservation_Manager.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Reservation_Manager.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerHistory> CustomerHistory { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Configure one-to-one relationship between Room And Reservation
            builder.Entity<Reservation>()
           .HasOne(a => a.Room)
           .WithOne(b => b.Reservation)
           .HasForeignKey<Room>(b => b.ReservationId);

            builder.Entity<Customer>()
                .HasOne(a => a.Reservation)
                .WithMany(a => a.Customers)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Customer>()
    .HasMany(a => a.ReservationsHistory)
    .WithOne(a => a.Customer)
    .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(builder);

            // Create user - administrator
            var password = new PasswordHasher<User>();
            User admin = new User
            {
                Id = "8e445864-a24d-4543-a6c6-9443d048cdb9",
                UserName = "admin@abv.bg",
                NormalizedUserName = "admin@abv.bg".ToUpper(),
                PasswordHash = password.HashPassword(null, "123456"),
                Email = "admin@abv.bg",
                NormalizedEmail = "admin@abv.bg".ToUpper(),
                PhoneNumber = "0123456789",
                FirstName = "John",
                MiddleName = "Johnny",
                LastName = "Johnson",
                UCN = "8603129931",
                HireDate = DateTime.Now,
                IsActive = true,
                SecurityStamp = string.Empty,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };
            builder.Entity<User>().HasData(admin);

            // Create roles
            IdentityRole adminRole = CreateRole("Admin");
            IdentityRole userRole = CreateRole("User");
            builder.Entity<IdentityRole>(
                option =>
                {
                    option.HasData(new IdentityRole[]
                    {
                        adminRole,
                        userRole,
                    }
                    );
                });


            //Add admin to role
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRole.Id,
                UserId = admin.Id
            });

            //Add users
            for (int i = 0; i < 100; i++)
            {
                User user = CreateUser($"user{i}@abv.bg");

                builder.Entity<User>().HasData(user);
                builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                    RoleId = userRole.Id,
                    UserId = user.Id
                });
            }
            //Add Customers

            for (int i = 0; i < 100; i++)
            {
                Customer customer = CreateCustomer($"customer{i}@abv.bg");

                builder.Entity<Customer>().HasData(customer);
            }

            //Add rooms
            for (int i = 0; i < 15; i++)
            {
                Room room = CreateRoom(i+100);
                builder.Entity<Room>().HasData(room);
            }
        }
        private static IdentityRole CreateRole(string roleName)
        {
            return new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = roleName, NormalizedName = roleName.ToUpper() };
        }
        private User CreateUser(string email, string password = "123456")
        {
            List<string> firstName = new List<string>() { "John", "Alex", "Jane", "Jack", "Michael", "William" };
            List<string> lastName = new List<string>() { "Johnson", "Alexandrov", "Brown", "Martinez" };
            Random random = new Random();
            var hasher = new PasswordHasher<IdentityUser>();
            //Create user
            User user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = firstName[random.Next(0, firstName.Count)],
                MiddleName = firstName[random.Next(0, firstName.Count)],
                LastName = lastName[random.Next(0, lastName.Count)],
            PhoneNumber = random.Next(100000000, 999999999).ToString("D10"),
                UCN = random.Next(0, 1000000000).ToString("D10"),
                HireDate = DateTime.Now,
                IsActive = true,
                SecurityStamp = string.Empty,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                UserName = email,
                NormalizedUserName = email,
                Email = email,
                NormalizedEmail = email,
                PasswordHash = hasher.HashPassword(null, password),

            };
            return user;
        }
        private Customer CreateCustomer(string email)
        {
            List<string> firstName = new List<string>() { "John", "Alex", "Jane", "Jack", "Michael", "William" };
            List<string> lastName = new List<string>() { "Johnson", "Alexandrov", "Brown", "Martinez" };
            Random random = new Random();
            var x = random.Next(100000000, 999999999);
            Boolean isAdult = false;

            if (random.Next(100) < 40)
            {
                isAdult = true;
            }
            //Create customer
            Customer customer = new Customer()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = firstName[random.Next(0, firstName.Count)],
                LastName = lastName[random.Next(0, lastName.Count)],
                PhoneNumber = x.ToString("D10"),
                IsAdult = isAdult,
                Email = email,
            };
            return customer;
        }
        private Room CreateRoom(int number = 100)
        {
            Random random = new Random();
            decimal y = random.Next(0, 1000);
            var z = random.Next(0, 10);
            Array values = Enum.GetValues(typeof(RoomType));
            RoomType randomType = (RoomType)values.GetValue(random.Next(values.Length));

            //Create Room
            Room room = new Room()
            {
                Id = Guid.NewGuid().ToString(),
                Capacity = z,
                IsAvailable = true,
                Number = number,
                PricePerBedAdult = y,
                PricePerBedChild = y / 2,
                RoomType = randomType,
            };
            return room;
        }

    }
}
