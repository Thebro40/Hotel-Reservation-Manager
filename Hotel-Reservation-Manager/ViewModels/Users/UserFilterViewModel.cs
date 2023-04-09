
namespace Hotel_Reservation_Manager.ViewModels.Users
{
using System.ComponentModel.DataAnnotations;
    public class UserFilterViewModel
    {
        [Display(Name="Username")]
        public string UserName { get; set; }
        [Display(Name="First name")]
        public string FirstName { get; set; }
        [Display(Name="Middle name")]
        public string MiddleName { get; set; }
        [Display(Name="Last name")]
        public string LastName { get; set; }
        [Display(Name="Email")]
        public string Email { get; set; }
    }
}
