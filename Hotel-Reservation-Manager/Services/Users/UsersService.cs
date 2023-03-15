using Hotel_Reservation_Manager.Data;
using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels;
using Hotel_Reservation_Manager.ViewModels.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services
{
    public class UsersService : IUsersService
    {
        private readonly ApplicationDbContext context;
        public UsersService(ApplicationDbContext context)
        {
            this.context = context;
        }
        //TO-DO ADD VALIDATIONS AND CHECKS
        public async Task<UserDetailsViewModel> GetUserDetailsViewModelByIdAsync(string id)
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
            User user = new User()
            {
                UserName = model.UserName,
                PhoneNumber = model.PhoneNumber,
                Password = model.Password,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                EGN = model.EGN,
                Email = model.Email,
                HireDate = model.HireDate,
                IsActive = model.IsActive,
                FireDate = model.FireDate,

            };
            await this.context.Users.AddAsync(user);
            await this.context.SaveChangesAsync();

        }
        public async Task<UserEditViewModel> GetUserEditViewModelAsync(string id)
        {
            User user = await this.context.Users.FindAsync(id);
            if (user != null)
            {
                return new UserEditViewModel()
                {
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber,
                    Password = user.Password,
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
            user.PhoneNumber = model.PhoneNumber;
            user.Password = model.Password;
            user.FirstName = model.FirstName;
            user.MiddleName = model.MiddleName;
            user.LastName = model.LastName;
            user.EGN = model.EGN;
            user.Email = model.Email;
            user.HireDate = model.HireDate;
            user.IsActive = model.IsActive;
            user.FireDate = model.FireDate;
            this.context.Update(user);
            await context.SaveChangesAsync();
        }
        public async Task<UserDetailsViewModel> GetUserDeleteViewModelAsyncById(string id)
        {
            User user = await this.context.Users.FindAsync(id);
            if (user != null)
            {
                return new UserDetailsViewModel()
                {
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber,
                    Password = user.Password,
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
        public async Task DeleteUserAsync(UserDetailsViewModel model)
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
