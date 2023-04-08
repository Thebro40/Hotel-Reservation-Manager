using Hotel_Reservation_Manager.Data.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservation_Manager.ViewModels.CustomerHistory
{
    public class CustomerHistoryViewModel
    {
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ResRoomNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [DisplayName("Accomodation date")]
        public DateTime ResAccomDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [DisplayName("Leave date")]
        public DateTime ResLeaveDate { get; set; }

        [Display(Name = "Total price")]
        [DataType(DataType.Currency)]
        public decimal ResPrice { get; set; }
    }
}
