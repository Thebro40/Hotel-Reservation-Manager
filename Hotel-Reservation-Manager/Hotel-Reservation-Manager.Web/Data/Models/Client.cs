using System;

namespace Hotel_Reservation_Manager.Web.Data.Models
{
    public class Client
    {
        public string Id = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; }
    }
}
