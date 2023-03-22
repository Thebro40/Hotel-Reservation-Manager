using Hotel_Reservation_Manager.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Hotel_Reservation_Manager.ViewModels.Rooms
{
    public class RoomCreateViewModel
    {
        //public string Id { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
        public decimal PricePerBedAdult { get; set; }
        public decimal PricePerBedChild { get; set; }
        public int Number { get; set; }

    }
}
