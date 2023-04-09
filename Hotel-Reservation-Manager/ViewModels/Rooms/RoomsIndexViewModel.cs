using Hotel_Reservation_Manager.ViewModels.Shared;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Rooms
{
<<<<<<< HEAD
    public class RoomsIndexViewModel : PagingViewModel
=======
    public class RoomsIndexViewModel:PagingViewModel
>>>>>>> 9b615d978ebcefaac978178e5eda4c713a65289f
    {
        public ICollection<RoomIndexViewModel> Rooms { get; set; }
        public RoomFilterViewModel Filter { get; set; } = new RoomFilterViewModel();
    }
}
