using Hotel_Reservation_Manager.Services.Customers;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Controllers
{
    [Authorize]
    public class CustomersController : Controller
    {
        public ICustomersService customersService { get; set; }
        public CustomersController(ICustomersService customersService)
        {
            this.customersService = customersService;
        }
        public async Task<IActionResult> Index()
        {
            var model = await customersService.GetCustomersAsync();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CustomerCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                await customersService.CreateCustomerAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Details(string id)
        {
            CustomerDetailsViewModel model = await customersService.GetCustomerDetailsByIdAsync(id);
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            CustomerEditViewModel model = await customersService.EditCustomerByIdAsync(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CustomerEditViewModel model)
        {
            await customersService.UpdateCustomerAsync(model);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string id)
        {
            CustomerDetailsViewModel model = await customersService.DeleteCustomerByIdAsync(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(CustomerDetailsViewModel model)
        {
            if (ModelState.IsValid)
            {
                await customersService.DeleteConfirmCustomerAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
