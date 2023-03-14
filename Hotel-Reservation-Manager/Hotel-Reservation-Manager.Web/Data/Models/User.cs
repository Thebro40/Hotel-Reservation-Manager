using Microsoft.AspNetCore.Identity;
using System;

namespace Hotel_Reservation_Manager.Data.Models
{
    //TO-DO User: IdentityRole
    public class User: IdentityUser
    {
        //username,password,email and phonenumber will be inherited from IdentityUser
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int EGN { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? FireDate { get; set; }

    }
}
