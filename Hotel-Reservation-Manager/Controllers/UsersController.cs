using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.Services;
using Hotel_Reservation_Manager.ViewModels.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        private readonly UserManager<User> userManager;
        public UsersController(IUsersService usersService, UserManager<User> userManager)
        {
            this.usersService = usersService;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await usersService.GetUsersAsync();
            return View(users);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                await usersService.CreateUserAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        //GET: Users/Edit/(Id)
        public async Task<IActionResult> Edit(string id)
        {
            UserEditViewModel model = await usersService.EditUserByIdAsync(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                await usersService.UpdateUserAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        //GET: Users/Delete/(Id)
        public async Task<IActionResult> Delete(string id)
        {
            UserDetailsViewModel model = await usersService.DeletUserByIdAsync(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(UserDetailsViewModel model)
        {
            await usersService.DeleteUserConfirmedAsync(model);
            return RedirectToAction(nameof(Index));
        }

        //GET: Users/Details/(Id)
        public async Task<IActionResult> Details(string id)
        {
            UserDetailsViewModel model = await usersService.GetUserDetailsByIdAsync(id);
            return View(model);
        }

    }
}
