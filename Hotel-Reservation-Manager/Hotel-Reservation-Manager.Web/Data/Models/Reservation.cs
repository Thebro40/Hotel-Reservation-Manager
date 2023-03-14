using System;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.Web.Data.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Room ReservedRoom { get; set; }
        //TO-DO User or IdentityUser?
        public User IssuingUser { get; set; }
        public ICollection<Client> PeopleStaying { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasAllInclusive { get; set; }
        public decimal Price { get; set; }


    }
}
