using Hotel_Reservation_Manager.ViewModels.Shared;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Users
{
<<<<<<< HEAD
    public class UsersIndexViewModel : PagingViewModel
=======
    public class UsersIndexViewModel:PagingViewModel
>>>>>>> 9b615d978ebcefaac978178e5eda4c713a65289f
    {
        public ICollection<UserIndexViewModel> Users { get; set; }
        public UserFilterViewModel Filter { get; set; } = new UserFilterViewModel();
    }
}
