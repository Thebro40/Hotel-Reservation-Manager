using Hotel_Reservation_Manager.ViewModels.Customers;
using System;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Reservations
{
    public class ReservationDetailsViewModel: ReservationIndexViewModel
    {
        public ICollection<CustomerIndexViewModel> Customers { get; set; }
    }
}
