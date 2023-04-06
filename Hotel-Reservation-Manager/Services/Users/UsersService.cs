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
        public async Task<UsersIndexViewModel> GetUsersAsync()
        {
            UsersIndexViewModel model = new UsersIndexViewModel();
            model.Users = await context.Users.Select(x => new UserIndexViewModel()
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
                UCN = model.UCN,
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

            //Add User to role if IsActive is true
            if (model.IsActive == true)
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
                    ///TO-DO
                    ///When editing a user, password always changes
                    //NewPassword = user.PasswordHash.ToString(),
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
            ///TO-DO
            ///When editing a user, change only edited properties?
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
            user.IsActive = model.IsActive;
            user.FireDate = model.FireDate;
            user.SecurityStamp = Guid.NewGuid().ToString();

            ///TO-DO
            ///When editing a user, password always changes
            /* 
                var hashedPassword = passwordHasher.HashPassword(user, model.NewPassword);
                user.PasswordHash = hashedPassword;
            */
            if (!String.IsNullOrWhiteSpace(model.NewPassword))
            {
                var hashedPassword = passwordHasher.HashPassword(user, model.NewPassword);
                user.PasswordHash = hashedPassword;
            }

            //Remove Role if IsActive isn't true
            if (model.IsActive == false)
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
