using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Reservation_Manager.ViewModels.Rooms
{
    public class RoomFilterViewModel
    {
        public int Capacity { get; set; }
        public string Type { get; set; }
        [Display(Name="Available")]
        public string IsAvailable { get; set; }
    }
}
