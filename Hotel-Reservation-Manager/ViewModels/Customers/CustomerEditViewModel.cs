namespace Hotel_Reservation_Manager.ViewModels.Customers
{
    public class CustomerEditViewModel: CustomerCreateViewModel
    {
        public string Id { get; set; }
        public bool RemoveFromRes { get; set; } = false;
    }
}
