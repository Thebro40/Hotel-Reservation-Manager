using Hotel_Reservation_Manager.ViewModels.Shared;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Rooms
{
    public class RoomsIndexViewModel:PagingViewModel
    {
        public ICollection<RoomIndexViewModel> Rooms { get; set; }
    }
}
