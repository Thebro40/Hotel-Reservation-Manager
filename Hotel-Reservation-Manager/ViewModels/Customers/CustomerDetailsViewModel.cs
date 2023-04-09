using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.CustomerHistory;
using Hotel_Reservation_Manager.ViewModels.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservation_Manager.ViewModels.Customers
{
    public class CustomerDetailsViewModel : PagingViewModel
    {
        public CustomerDetailsViewModel()
        {
            Action = "Details";
        }
        public string Id { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Adult")]
        public bool IsAdult { get; set; }

        public ICollection<CustomerHistoryViewModel> History { get; set; }
    }
}
