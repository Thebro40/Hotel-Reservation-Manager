using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservation_Manager.ViewModels.Reservations
{
    public class ReservationEditViewModel: ReservationCreateViewModel
    {
        public string Id { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayName("Accomodation date")]
        public new DateTime AccommodationDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [DisplayName("Leave date")]
        public new DateTime LeaveDate { get; set; }
        public IList<Customer> CustomersToAdd { get; set; } = new List<Customer>();
        public IList<CustomerIndexViewModel> CustomersToRemove { get; set; } = new List<CustomerIndexViewModel>();
    }
}
