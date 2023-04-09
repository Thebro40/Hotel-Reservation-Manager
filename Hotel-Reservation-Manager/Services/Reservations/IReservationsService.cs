using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Hotel_Reservation_Manager.ViewModels.Reservations;
using Hotel_Reservation_Manager.ViewModels.Rooms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services.Reservations
{
    public interface IReservationsService
    {
        Task CreateReservationAsync(ReservationCreateViewModel model);
        Task<ReservationDetailsViewModel> GetReservationToDeleteAsync(string id);
        Task DeleteReservationAsync(ReservationDetailsViewModel model);
        Task<ReservationDetailsViewModel> GetReservationDetailsAsync(string id);
        Task<ReservationsIndexViewModel> GetReservationsAsync(ReservationsIndexViewModel model);
        Task<ReservationEditViewModel> EditReservationByIdAsync(string id);
        Task UpdateReservationAsync(ReservationEditViewModel editmodel);
        Task<List<RoomSelectListViewModel>> GetFreeRoomsSelectListAsync();
        Task<int> GetRoomCapacityAsync(string id);
        Task<Customer> FindCustomerAsync(Customer cust);
        Task<List<RoomSelectListViewModel>> GetAllRoomsSelectListAsync(ReservationEditViewModel model);
        bool HasReservationPassed(DateTime LeaveDate);
    }
}