using Hotel_Reservation_Manager.Data.Models;
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
        public ICollection<Customer> OutputCustomers { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasAllInclusive { get; set; }
        public int Price { get; set; }
    }
}
