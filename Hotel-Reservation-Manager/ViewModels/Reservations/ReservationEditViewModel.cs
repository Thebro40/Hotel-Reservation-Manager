using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Reservations
{
    public class ReservationEditViewModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string RoomId { get; set; }
        public IList<CustomerEditViewModel> CustomersToAdd { get; set; } = new List<CustomerEditViewModel>();
        public IList<CustomerEditViewModel> CustomersToRemove { get; set; } = new List<CustomerEditViewModel>();
        public SelectList Rooms { get; set; }
        public int SelectedRoomCap { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasAllInclusive { get; set; }
    }
}
