using Hotel_Reservation_Manager.ViewModels.Shared;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Customers
{
    public class CustomersIndexViewModel : PagingViewModel
    {
        public ICollection<CustomerIndexViewModel> Customers { get; set; }
    }
}
