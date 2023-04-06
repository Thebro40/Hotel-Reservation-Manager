using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Customers;
using System;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Reservations
{
    public class ReservationCreateViewModel
    {
        public string UserId { get; set; }
        public string CustomerId { get; set; }
        public string RoomId { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasAllInclusive { get; set; }
        public decimal Price { get; set; }
    }
}
