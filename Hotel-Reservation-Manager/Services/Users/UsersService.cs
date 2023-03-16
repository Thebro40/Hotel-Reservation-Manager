using Hotel_Reservation_Manager.Data;
using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels;
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
        public UsersService(ApplicationDbContext context,  IPasswordHasher<User> passwordHasher, UserManager<User> userManager)
        {
            this.userManager = userManager;
            this.context = context;
            this.passwordHasher = passwordHasher;
        }
        //TO-DO ADD VALIDATIONS AND CHECKS
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
                    EGN = user.EGN,
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
        public async Task<UsersIndexViewModel> GetUsersAsync()
        {
            UsersIndexViewModel model = new UsersIndexViewModel();
            model.Users = await context.Users.Select(x => new UserIndexViewModel()
            {
                Id = x.Id,
                UserName = x.UserName,
                Email = x.Email,
                EGN = x.EGN,
                PhoneNumber = x.PhoneNumber,
                FirstName = x.FirstName,
                MiddleName = x.MiddleName,
                LastName = x.LastName,
                HireDate = x.HireDate,
                IsActive = x.IsActive,
            })
                .ToListAsync();
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
                //Password = model.Password,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                EGN = model.EGN,
                HireDate = model.HireDate,
                IsActive = model.IsActive,
                FireDate = model.FireDate,

            };
            var hashedPassword = passwordHasher.HashPassword(user, model.Password);
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.PasswordHash = hashedPassword;
            
            //Add User to database and save
            await this.context.Users.AddAsync(user);
            await this.context.SaveChangesAsync();
            
            //Add User to role
            await userManager.AddToRoleAsync(user, "User");


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
                    Password = user.PasswordHash.ToString().Substring(0, 8),
                    FirstName = user.FirstName,
                    MiddleName = user.MiddleName,
                    LastName = user.LastName,
                    EGN = user.EGN,
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
            //user.PasswordHash = model.Password;
            user.FirstName = model.FirstName;
            user.MiddleName = model.MiddleName;
            user.LastName = model.LastName;
            user.EGN = model.EGN;
            user.HireDate = model.HireDate;
            user.IsActive = model.IsActive;
            user.FireDate = model.FireDate;
            user.SecurityStamp = Guid.NewGuid().ToString();

            var hashedPassword = passwordHasher.HashPassword(user, model.Password);
            user.PasswordHash = hashedPassword;

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
                    EGN = user.EGN,
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
