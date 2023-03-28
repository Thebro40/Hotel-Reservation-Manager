using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservation_Manager.ViewModels.Reservations
{
    public class ReservationCreateViewModel
    {
        public string UserId { get; set; }
        public IList<CustomerCreateViewModel> Customers { get; set; } = 
            new List<CustomerCreateViewModel>();
        public int SelectedRoomCap { get; set; }
        [Required(ErrorMessage = "Please select and submit a room")]
        public string RoomId { get; set; }
        public SelectList Rooms { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [DisplayName("Accomodation date")]
        public DateTime AccommodationDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [DisplayName("Leave date")]
        public DateTime LeaveDate { get; set; }

        [DisplayName("Breakfast")]
        public bool HasBreakfast { get; set; }

        [DisplayName("Allinclusive")]
        public bool HasAllInclusive { get; set; }
    }
}