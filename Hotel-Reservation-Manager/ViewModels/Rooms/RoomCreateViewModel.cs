namespace Hotel_Reservation_Manager.ViewModels.Rooms
{
    using Data.Enums;
    using System.ComponentModel.DataAnnotations;

    public class RoomCreateViewModel
    {
        [Required]
        public int Capacity { get; set; }
        [Required]
        [Display(Name = "Type")]
        public RoomType RoomType { get; set; }
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }
        [Required]
        [Display(Name = "Price for adult")]
        [Range(1, 10000)]
        public decimal PricePerBedAdult { get; set; }
        [Required]

        [RegularExpression(@"[0-9]+(\.[0-9][0-9]?)?", ErrorMessage = "Not a valid phone number")]
        [Display(Name = "Price for child")]
        [Range(1, 10000)]
        public decimal PricePerBedChild { get; set; }
        [Required]
        public int Number { get; set; }

    }
}
