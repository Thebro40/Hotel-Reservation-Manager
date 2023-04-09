
namespace Hotel_Reservation_Manager.ViewModels.Rooms
{
using Data.Enums;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class RoomIndexViewModel
    {
        public string Id { get; set; }
        
        public int Capacity { get; set; }
        [Display(Name = "Type")]
        public RoomType RoomType { get; set; }
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }
        [Display(Name = "Price for adult")]
        [DataType(DataType.Currency)]
        public decimal PricePerBedAdult { get; set; }
        [Display(Name = "Price for child")]
        [DataType(DataType.Currency)]
        public decimal PricePerBedChild { get; set; }
        public int Number { get; set; }
    }
}