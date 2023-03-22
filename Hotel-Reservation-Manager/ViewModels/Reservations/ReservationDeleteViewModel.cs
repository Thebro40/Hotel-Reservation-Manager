using Hotel_Reservation_Manager.ViewModels.Customers;
using System;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Reservations
{
    public class ReservationDeleteViewModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string RoomId { get; set; }
        public string CustomerId { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasAllInclusive { get; set; }
        public decimal Price { get; set; }
        public ICollection<CustomerIndexViewModel> Customers { get; set; }
    }
}
