using System;
namespace Hotel_Reservation_Manager.Data.Models
{

    public class Customer
    {
        //TO-DO ADD DATA ANNOTATIONS
        public Customer()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; }

    }
}
