using Hotel_Reservation_Manager.Data;
using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels;
using Hotel_Reservation_Manager.ViewModels.Rooms;
using Hotel_Reservation_Manager.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext context;
        public readonly IPasswordHasher<User> passwordHasher;
        private readonly UserManager<User> userManager;
        public UsersService(ApplicationDbContext context, IPasswordHasher<User> passwordHasher, UserManager<User> userManager)
        {
            this.userManager = userManager;
            this.context = context;
            this.passwordHasher = passwordHasher;
        }
        public async Task<UserDetailsViewModel> GetUserDetailsByIdAsync(string id)
        {
            User user = await this.context.Users.FindAsync(id);
            if (user != null)
            {
                return new UserDetailsViewModel()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    UCN = user.UCN,
                    PhoneNumber = user.PhoneNumber,
                    FirstName = user.FirstName,
                    MiddleName = user.MiddleName,
                    LastName = user.LastName,
                    HireDate = user.HireDate,
                    IsActive = user.IsActive,
                };
            }
            return null;
        }
        public async Task<UsersIndexViewModel> GetUsersAsync(UsersIndexViewModel model)
        {
<<<<<<< HEAD
            model.Users = await this.context.Users
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new UserIndexViewModel()
                {
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email,
                    UCN = x.UCN,
                    PhoneNumber = x.PhoneNumber,
                    FirstName = x.FirstName,
                    MiddleName = x.MiddleName,
                    LastName = x.LastName,
                    HireDate = x.HireDate,
                    IsActive = x.IsActive,
                })
                .ToListAsync();

=======
            model.Users = await context.Users
                .Where(x => model.Filter.FirstName != null ? (x.FirstName.StartsWith(model.Filter.FirstName)) : x.Id != null)
                .Where(x => model.Filter.MiddleName != null ? (x.MiddleName.StartsWith(model.Filter.MiddleName)) : x.Id != null)
                .Where(x => model.Filter.LastName != null ? (x.LastName.StartsWith(model.Filter.LastName)) : x.Id != null)
                .Where(x => model.Filter.UserName != null ? (x.UserName.StartsWith(model.Filter.UserName)) : x.Id != null)
                .Where(x => model.Filter.Email != null ? (x.Email.StartsWith(model.Filter.Email)) : x.Id != null)
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new UserIndexViewModel()
            {
                Id = x.Id,
                UserName = x.UserName,
                Email = x.Email,
                UCN = x.UCN,
                PhoneNumber = x.PhoneNumber,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                HireDate = x.HireDate,
                IsActive = x.IsActive,
                FireDate = x.FireDate,
            })
                .ToListAsync();
>>>>>>> 9b615d978ebcefaac978178e5eda4c713a65289f
            model.ElementsCount = await this.context.Users.CountAsync();
            return model;
        }
        public async Task CreateUserAsync(UserCreateViewModel model)
        {
            //Create User
            User user = new User()
            {
                UserName = model.UserName,
                NormalizedUserName = model.UserName.ToUpper(),
                Email = model.Email,
                NormalizedEmail = model.Email.ToUpper(),
                PhoneNumber = model.PhoneNumber,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                UCN = model.UCN,
                HireDate = model.HireDate,
                IsActive = model.IsActive,
            };
            //Hash and add user password
            var hashedPassword = passwordHasher.HashPassword(user, model.Password);
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.PasswordHash = hashedPassword;

            //Add User to database and save
            await this.context.Users.AddAsync(user);
            await this.context.SaveChangesAsync();

            //Add User to role if IsActive is true
            if (model.IsActive)
            {
                await userManager.AddToRoleAsync(user, "User");
            }
        }
        public async Task<UserEditViewModel> EditUserByIdAsync(string id)
        {
            User user = await this.context.Users.FindAsync(id);
            if (user != null)
            {
                return new UserEditViewModel()
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber,
                    NewPassword = String.Empty,
                    FirstName = user.FirstName,
                    MiddleName = user.MiddleName,
                    LastName = user.LastName,
                    UCN = user.UCN,
                    Email = user.Email,
                    HireDate = user.HireDate,
                    IsActive = user.IsActive,
                    FireDate = user.FireDate,
                };
            }

            return null;
        }
        public async Task UpdateUserAsync(UserEditViewModel model)
        {
            User user = await this.context.Users.FindAsync(model.Id);
            user.UserName = model.UserName;
            user.NormalizedUserName = model.UserName.ToUpper();
            user.Email = model.Email;
            user.NormalizedEmail = model.Email.ToUpper();
            user.PhoneNumber = model.PhoneNumber;
            user.FirstName = model.FirstName;
            user.MiddleName = model.MiddleName;
            user.LastName = model.LastName;
            user.UCN = model.UCN;
            user.HireDate = model.HireDate;

            if (!model.IsActive && model.IsActive != user.IsActive)
            {
                user.FireDate = DateTime.Today;
            }
            user.IsActive = model.IsActive;
            user.SecurityStamp = Guid.NewGuid().ToString();
            if (!String.IsNullOrWhiteSpace(model.NewPassword))
            {
                var hashedPassword = passwordHasher.HashPassword(user, model.NewPassword);
                user.PasswordHash = hashedPassword;
            }

            //Remove Role if IsActive isn't true
            if (!model.IsActive)
            {
                await userManager.RemoveFromRoleAsync(user, "User");
            }
            else
            {
                //Add User role if IsActive is true and User doesnt have Admin or User role
                if (!await userManager.IsInRoleAsync(user, "Admin") || !await userManager.IsInRoleAsync(user, "User"))
                {
                    await userManager.AddToRoleAsync(user, "User");
                }
                user.FireDate = null;
            }
            this.context.Update(user);
            await context.SaveChangesAsync();
        }
        public async Task<UserDetailsViewModel> DeleteUserByIdAsync(string id)
        {
            User user = await this.context.Users.FindAsync(id);
            if (user != null)
            {
                return new UserDetailsViewModel()
                {
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber,
                    //Password = user.Password,
                    FirstName = user.FirstName,
                    MiddleName = user.MiddleName,
                    LastName = user.LastName,
                    UCN = user.UCN,
                    Email = user.Email,
                    HireDate = user.HireDate,
                    IsActive = user.IsActive,
                    FireDate = user.FireDate,
                };
            }
            return null;
        }
        public async Task DeleteUserConfirmedAsync(UserDetailsViewModel model)
        {
            User user = await this.context.Users.FindAsync(model.Id);
            if (user != null)
            {
                this.context.Users.Remove(user);
                await this.context.SaveChangesAsync();
            }
        }
    }
}
