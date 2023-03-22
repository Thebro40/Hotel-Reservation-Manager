using Hotel_Reservation_Manager.ViewModels.Customers;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services.Customers
{
    public interface ICustomersService
    {
        Task CreateCustomerAsync(CustomerCreateViewModel model);
        Task DeleteConfirmCustomerAsync(CustomerDetailsViewModel model);
        Task<CustomerDetailsViewModel> DeleteCustomerByIdAsync(string id);
        Task<CustomerEditViewModel> EditCustomerByIdAsync(string id);
        Task<CustomerDetailsViewModel> GetCustomerDetailsByIdAsync(string id);
        Task<CustomersIndexViewModel> GetCustomersAsync();
        Task UpdateCustomerAsync(CustomerEditViewModel model);
    }
}