namespace Hotel_Reservation_Manager.Data.Models
{
    public class Room
    {
        //TO-DO ADD DATA ANNOTATIONS
        public int Id { get; set; }
        public int Capacity { get; set; }
        public RoomType RoomType { get; set; }
        public bool IsAvailable { get; set; }
        public decimal PricePerBedAdult { get; set; }
        public decimal PricePerBedChild { get; set; }
        public int Number { get; set; }
        public virtual Reservation Reservation { get; set; }
        
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
