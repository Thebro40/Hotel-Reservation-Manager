using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Reservations
{
    public class ReservationsIndexViewModel
    {
        public ICollection<ReservationIndexViewModel> Reservations { get; set; }
    }
}
