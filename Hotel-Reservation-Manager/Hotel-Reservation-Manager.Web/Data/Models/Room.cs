namespace Hotel_Reservation_Manager.Web.Data.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
        public decimal PricePerBedAdult { get; set; }
        public decimal PricePerBedChild { get; set; }
        public int Number { get; set; }
        
    }
    public enum RoomType
    {
        TwoSingleBeds,
        Apartment,
        DoubleBed,
        PentHouse,
        Мaisonette

        //две единични легла, апартамент, стая с двойно легло, пентхаус, мезонет
    }
}
