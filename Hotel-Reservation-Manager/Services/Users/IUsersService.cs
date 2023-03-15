using Hotel_Reservation_Manager.ViewModels.Users;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services
{
    public interface IUsersService
    {
        Task<UsersIndexViewModel> GetUsersAsync();
        Task<UserDetailsViewModel> GetUserDetailsViewModelByIdAsync(string id);
        Task CreateUserAsync(UserCreateViewModel user);
        Task<UserEditViewModel> GetUserEditViewModelAsync(string id);
        Task UpdateUserAsync(UserEditViewModel model);
        Task<UserDetailsViewModel> GetUserDeleteViewModelAsyncById(string id);
        Task DeleteUserAsync(UserDetailsViewModel model);

    }
}