using FireAndIce.ViewModels.Shared;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Users
{
    public class UsersIndexViewModel
    {
        public ICollection<UserIndexViewModel> Users { get; set; }
    }
}
