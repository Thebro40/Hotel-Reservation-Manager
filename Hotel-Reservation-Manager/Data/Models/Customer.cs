namespace Hotel_Reservation_Manager.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Customer
    {
        public Customer()
        {
            this.Id= Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsAdult { get; set; }
        public string ReservationId { get; set; }
        [ForeignKey("ReservationId")]
        public virtual Reservation Reservation { get; set; }
    }
}
