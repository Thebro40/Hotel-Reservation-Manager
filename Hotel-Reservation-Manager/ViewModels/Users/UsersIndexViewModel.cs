using Hotel_Reservation_Manager.ViewModels.Shared;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Users
{
    public class UsersIndexViewModel:PagingViewModel
    {
        public ICollection<UserIndexViewModel> Users { get; set; }
        public UserFilterViewModel Filter { get; set; } = new UserFilterViewModel();
    }
}
