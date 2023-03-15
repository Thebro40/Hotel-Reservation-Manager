using Hotel_Reservation_Manager.ViewModels.Rooms;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services.Rooms
{
    public interface IRoomsService
    {
        Task<RoomsIndexViewModel> GetRoomsAsync();
        Task<RoomDetailsViewModel> GetRoomDetailsViewModelAsyncById(int id);
        Task CreateRoomAsync(RoomCreateViewModel model);
        Task<RoomEditViewModel> GetRoomEditViewModelAsync(int id);
        Task UpdateRoom(RoomEditViewModel model);
    }
}