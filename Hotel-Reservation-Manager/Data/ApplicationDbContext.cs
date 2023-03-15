using Hotel_Reservation_Manager.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Reservation_Manager.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        //TO-DO Implement proper raltionships between tables
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
            /*
             * builder.Entity<Tech>(
                entity =>
            {
                entity.HasOne(x => x.User)
                  .WithOne(x => x.Tech)
                 .HasForeignKey<Tech>(x => x.UserId)
                 .OnDelete(DeleteBehavior.Cascade);
            });
            */
            base.OnModelCreating(builder);
            var password = new PasswordHasher<User>();
            User user = new User
            {

                Id = "8e445864-a24d-4543-a6c6-9443d048cdb9",
                UserName = "admin@abv.bg",
                NormalizedUserName = "admin@abv.bg".ToUpper(),
                //Password = "Password",
                PasswordHash = password.HashPassword(null, "Pa$$w0rd"),
                Email = "admin@abv.bg",
                NormalizedEmail = "ADMIN@ABV.BG",
                PhoneNumber = "1111111111",
                FirstName = "ss",
                MiddleName = "vv",
                LastName = "s2s",
                EGN = "12121",
                HireDate = DateTime.Now,
                IsActive = true,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };
            builder.Entity<User>().HasData(user);
        }
    }
}
