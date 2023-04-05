namespace Hotel_Reservation_Manager.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    public class User: IdentityUser<string>
    {
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UCN { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? FireDate { get; set; }

    }
}
