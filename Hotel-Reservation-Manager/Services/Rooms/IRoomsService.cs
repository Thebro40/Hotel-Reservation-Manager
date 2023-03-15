using Hotel_Reservation_Manager.ViewModels.Rooms;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services.Rooms
{
    public interface IRoomsService
    {
        Task<RoomsIndexViewModel> GetRoomsAsync();
        Task<RoomDetailsViewModel> GetRoomDetailsByIdAsync(int id);
        Task CreateRoomAsync(RoomCreateViewModel model);
        Task<RoomEditViewModel> EditRoomByIdAsync(int id);
        Task UpdateRoomAsync(RoomEditViewModel model);
        Task DeleteConfirmRoomAsync(RoomDetailsViewModel model);
        Task<RoomDetailsViewModel> DeleteRoomByIdAsync(int id);
    }
}