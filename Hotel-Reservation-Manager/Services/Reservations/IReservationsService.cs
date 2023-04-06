using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Reservations;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services.Reservations
{
    public interface IReservationsService
    {
        Task CreateReservationAsync(ReservationCreateViewModel model);
        Task<ReservationDeleteViewModel> GetReservationToDeleteAsync(string id);
        Task DeleteReservationAsync(ReservationDeleteViewModel model);
        Task<ReservationDetailsViewModel> GetReservationDetailsAsync(string id);
        Task<ReservationsIndexViewModel> GetReservationsAsync();
        Task<ReservationEditViewModel> EditReservationByIdAsync(string id);
        Task UpdateReservationAsync(ReservationEditViewModel model);
    }
}