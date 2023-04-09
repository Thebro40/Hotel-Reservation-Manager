using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservation_Manager.ViewModels.Users
{
    public class UserCreateViewModel
    {
        [Required]
        [DisplayName("User name")]
        [StringLength(15)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Phone number")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("First name")]
        [StringLength(15)]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Middle name")]
        [StringLength(15)]
        public string MiddleName { get; set; }
        [Required]
        [DisplayName("Last name")]
        [StringLength(15)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(25)]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; }

        [Required]
        [StringLength(10)]
        [MinLength(10, ErrorMessage = "UCN must be exactly 10 characters")]
        public string UCN { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayName("Hire date")]
        public DateTime HireDate { get; set; }

        [DisplayName("Activity")]
        public bool IsActive { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayName("Fire date")]
        public DateTime? FireDate { get; set; }

    }
}
