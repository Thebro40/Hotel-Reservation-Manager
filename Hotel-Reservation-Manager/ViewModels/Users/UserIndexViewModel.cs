namespace Hotel_Reservation_Manager.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class UserIndexViewModel
    {
        public string Id { get; set; }
        [Display(Name ="User name")]
        public string UserName { get; set; }     
        public string Email { get; set; }
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle name")]
        public string MiddleName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public string UCN { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Hire date")]
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Fire date")]
        public DateTime? FireDate { get; set; }

    }
}
