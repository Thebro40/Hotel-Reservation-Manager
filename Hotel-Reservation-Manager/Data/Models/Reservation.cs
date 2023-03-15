using System;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.Data.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public virtual ICollection<Room> ReservedRooms { get; set; }
        //TO-DO User or IdentityUser?
        public virtual User IssuingUser { get; set; }
        public virtual ICollection<Customer> PeopleStaying { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasAllInclusive { get; set; }
        public decimal Price { get; set; }


    }
}
