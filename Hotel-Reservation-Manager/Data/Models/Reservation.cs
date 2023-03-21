namespace Hotel_Reservation_Manager.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Reservation
    {
        // TODO Require UserId
        public Reservation()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string RoomId { get; set; }
        [ForeignKey("RoomId")]
        public virtual Room Room { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        //Remove CustomerId
        //public string CustomerId { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }

        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasAllInclusive { get; set; }
        public decimal Price { get; set; }


    }
}
