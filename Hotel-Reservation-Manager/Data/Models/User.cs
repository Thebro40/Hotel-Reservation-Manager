﻿namespace Hotel_Reservation_Manager.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    //USER: IdentityUser
    public class User: IdentityUser<string>
    {
        //TO-DO ADD DATA ANNOTATIONS
        //username,password,email and phonenumber will be inherited from IdentityUser

        //public string Password { get; set; }
        public User()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? FireDate { get; set; }

    }
}
