using Hotel_Reservation_Manager.ViewModels.Rooms;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services.Rooms
{
    public interface IRoomsService
    {
        Task<RoomsIndexViewModel> GetRoomsAsync();
        Task<RoomDetailsViewModel> GetRoomDetailsByIdAsync(string id);
        Task CreateRoomAsync(RoomCreateViewModel model);
        Task<RoomEditViewModel> EditRoomByIdAsync(string id);
        Task UpdateRoomAsync(RoomEditViewModel model);
        Task DeleteConfirmRoomAsync(RoomDetailsViewModel model);
        Task<RoomDetailsViewModel> DeleteRoomByIdAsync(string id);
    }
}