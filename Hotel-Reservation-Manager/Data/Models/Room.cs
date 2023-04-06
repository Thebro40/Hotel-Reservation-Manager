namespace Hotel_Reservation_Manager.Data.Models
{
    using Hotel_Reservation_Manager.Data.Enums;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Room
    {
        public Room()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public int Number { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
        [Column(TypeName = "money")]
        public decimal PricePerBedAdult { get; set; }
        [Column(TypeName = "money")]
        public decimal PricePerBedChild { get; set; }
        public string ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
