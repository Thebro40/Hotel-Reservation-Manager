using Hotel_Reservation_Manager.Data.Enums;

namespace Hotel_Reservation_Manager.ViewModels.Rooms
{
    public class RoomSelectListViewModel
    {
        public string Id { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public decimal PricePerBedAdult { get; set; }
        public decimal PricePerBedChild { get; set; }
        public int Number { get; set; }
    }
}