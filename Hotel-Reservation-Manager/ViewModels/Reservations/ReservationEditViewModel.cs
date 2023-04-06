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
        public string CustomerToRemoveId { get; set; }
        public string CustomerToAddId { get; set; }
        public string RoomId { get; set; }
        public IList<Customer> Customers { get; set; } = new List<Customer>();
        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasAllInclusive { get; set; }
        public int Price { get; set; }
    }
}
