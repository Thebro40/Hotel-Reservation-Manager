namespace Hotel_Reservation_Manager.ViewModels.Rooms
{
    using Data.Enums;
    using System;
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
        [RegularExpression(@"^[1-9]\d*([\,\.]\d{2})?$", ErrorMessage = "Enter a valid price")]
        [StringLength(10)]
        //[Range(0, int.MaxValue)]
        public string PricePerBedAdult { get; set; }
        [Required]
        [Display(Name = "Price for child")]
        [RegularExpression(@"^[1-9]\d*([\,\.]\d{2})?$", ErrorMessage = "Enter a valid price")]
        [StringLength(10)]
        //[Range(0, int.MaxValue)]
        public string PricePerBedChild { get; set; }
        [Required]
        public int Number { get; set; }

    }
}
