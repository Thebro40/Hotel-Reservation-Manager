namespace Hotel_Reservation_Manager.ViewModels.Customers
{
    using System.ComponentModel.DataAnnotations;
    public class CustomerCreateViewModel
    {
        [Required]
        [Display(Name = "First name")]
        [StringLength(15)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        [StringLength(15)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        [StringLength(25)]
        public string Email { get; set; }

        [Display(Name = "Adult")]
        public bool IsAdult { get; set; }
    }
}
