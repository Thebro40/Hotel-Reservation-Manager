﻿namespace Hotel_Reservation_Manager.ViewModels.Customers
{
    public class CustomerIndexViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; }
        public bool HasReservation { get; set; }
    }
}