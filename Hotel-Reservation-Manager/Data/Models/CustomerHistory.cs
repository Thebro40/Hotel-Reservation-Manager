using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Reservation_Manager.Data.Models
{
    public class CustomerHistory
    {
        public CustomerHistory()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int ResRoomNumber { get; set; }
        public DateTime ResAccomDate { get; set; }
        public DateTime ResLeaveDate { get; set; }

        [Column(TypeName = "money")]
        public decimal ResPrice { get; set; }

    }
}
