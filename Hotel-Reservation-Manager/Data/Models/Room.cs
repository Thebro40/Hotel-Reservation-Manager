namespace Hotel_Reservation_Manager.Data.Models
{
    using Hotel_Reservation_Manager.Data.Enums;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Room
    {
        //TO-DO ADD DATA ANNOTATIONS
        public Room()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Number { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
        public decimal PricePerBedAdult { get; set; }
        public decimal PricePerBedChild { get; set; }

        public string ReservationId { get; set; }
        [ForeignKey("ReservationId")]
        public virtual Reservation Reservation { get; set; }

    }
}
