using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.Services;
using Hotel_Reservation_Manager.ViewModels;
using Hotel_Reservation_Manager.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }
        public async Task<IActionResult> Index(UsersIndexViewModel model)
        {
            model = await this.usersService.GetUsersAsync(model);
            return View(model);
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
            UserDetailsViewModel model = await usersService.DeleteUserByIdAsync(id);
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
