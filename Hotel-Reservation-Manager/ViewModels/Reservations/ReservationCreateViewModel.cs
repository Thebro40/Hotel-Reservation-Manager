﻿using Hotel_Reservation_Manager.Data.Models;
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
        public IList<CustomerIndexViewModel> Customers { get; set; } = new List<CustomerIndexViewModel>();

        [DisplayName ("Customers")]
        public IList<string> SelectedCustomers { get; set; }
        public IList<SelectListItem> CustomersList { get; set; } = new List<SelectListItem>();

        //public CustomersIndexViewModel Customers { get; set; } = new CustomersIndexViewModel();
        [Required]
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