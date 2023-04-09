using Hotel_Reservation_Manager.Data.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservation_Manager.ViewModels.Reservations
{
    public class ReservationIndexViewModel
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public Room Room { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayName("Accomodation date")]
        public DateTime AccommodationDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayName("Leave date")]
        public DateTime LeaveDate { get; set; }

        [DisplayName("Breakfast")]
        public bool HasBreakfast { get; set; }

        [DisplayName("Allinclusive")]
        public bool HasAllInclusive { get; set; }

        [Display(Name = "Total price")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

    }
}
