using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Users;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services
{
    public interface IUsersService
    {
        Task<UsersIndexViewModel> GetUsersAsync(UsersIndexViewModel model);
        Task<UserDetailsViewModel> GetUserDetailsByIdAsync(string id);
        Task CreateUserAsync(UserCreateViewModel model);
        Task<UserEditViewModel> EditUserByIdAsync(string id);
        Task UpdateUserAsync(UserEditViewModel model);
        Task<UserDetailsViewModel> DeleteUserByIdAsync(string id);
        Task DeleteUserConfirmedAsync(UserDetailsViewModel model);
    }
}