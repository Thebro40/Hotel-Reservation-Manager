using System;

namespace Hotel_Reservation_Manager.Data.Models
{
    public class CustomerHistory
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        //public virtual Customer Customer { get; set; }
        public string ReservationId { get; set; }
        public int RoomNumber { get; set; }
        public DateTime AccommodationDate { get; set; }
        public DateTime LeaveDate { get; set; }
       // public virtual Reservation Reservation { get; set; }
    }
}
