namespace Hotel_Reservation_Manager.ViewModels.Customers
{
    using System.ComponentModel.DataAnnotations;
    public class CustomerCreateViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; }
    }
}
