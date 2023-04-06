using Hotel_Reservation_Manager.ViewModels.Shared;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Reservations
{
    public class ReservationsIndexViewModel:PagingViewModel
    {
        public ICollection<ReservationIndexViewModel> Reservations { get; set; }
    }
}
