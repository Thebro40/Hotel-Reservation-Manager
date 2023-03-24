using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.Services.Customers;
using Hotel_Reservation_Manager.Services.Reservations;
using Hotel_Reservation_Manager.ViewModels;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Hotel_Reservation_Manager.ViewModels.Reservations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly IReservationsService reservationsService;
        private readonly ICustomersService customersService;
        public ReservationsController(IReservationsService reservationsService, ICustomersService customersService)
        {
            this.customersService = customersService;
            this.reservationsService = reservationsService;
        }
        public async Task<IActionResult> Index()
        {
            var reservations = await reservationsService.GetReservationsAsync();
            return View(reservations);
        }
        public async Task<IActionResult> Create()
        {
            ReservationCreateViewModel model = new ReservationCreateViewModel()
            {
                Customers = await reservationsService.GetFreeCustomersAsListAsync(),
                Rooms = new SelectList(await reservationsService.GetRoomsSelectListAsync(), "Id", "Number"),
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReservationCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Gets current user's id
                model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                await reservationsService.CreateReservationAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public async Task<IActionResult> Details(string id)
        {
            ReservationDetailsViewModel model = await reservationsService.GetReservationDetailsAsync(id);
            return View(model);
        }
        public async Task<IActionResult> Delete(string id)
        {
            ReservationDeleteViewModel model = await reservationsService.GetReservationToDeleteAsync(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(ReservationDeleteViewModel model)
        {
            if (ModelState.IsValid)
            {
                await reservationsService.DeleteReservationAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public async Task<IActionResult> Edit(string id)
        {
            ReservationEditViewModel model = await reservationsService.EditReservationByIdAsync(id);
            return View(model);
        }

        ///<summary>POST: ReservationController/Edit/?(id)</summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ReservationEditViewModel model)
        {
            try
            {
                //Gets current user's id
                model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                await reservationsService.UpdateReservationAsync(model);
            }
            catch (Exception ex)
            {
                //2 ways of handling exceptions:
                //redirect user back to edit view and display error
                model = await reservationsService.EditReservationByIdAsync(model.Id);
                ModelState.AddModelError(nameof(model.RoomId), ex.Message);
                //redirect user to error view and display error(doesn't work)
                //return RedirectToAction("Error", "Home", new ErrorViewModel() { ErrorMessage = ex.Message });
                return View(model);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
