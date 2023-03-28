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
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly IReservationsService reservationsService;
        public ReservationsController(IReservationsService reservationsService)
        {
            this.reservationsService = reservationsService;
        }
        public async Task<IActionResult> Index()
        {
            var reservations = await reservationsService.GetReservationsAsync();
            return View(reservations);
        }
        public async Task<IActionResult> Create(string roomId)
        {
            ReservationCreateViewModel model = new ReservationCreateViewModel();
            await ConfigureCreateVM(model, roomId);
            if (!model.Rooms.Any())
            {
                return RedirectToAction("Error", "Home", new ErrorViewModel() { ErrorMessage = "No free rooms at his time" });
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReservationCreateViewModel model)
        {
            //Gets current user's id
            model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //Remove temporary empty Customer objects
            model.Customers = model.Customers.Where(x => x.FirstName != null && x.LastName != null && x.PhoneNumber != null).ToList();

            //Checks Accommodation and Leave date if they are sensible
            if (CheckDurationOfDates(model))
            {
                ModelState.AddModelError(nameof(model.LeaveDate), "Leave date can't be before Accommodation Date");
                ModelState.AddModelError(nameof(model.AccommodationDate), "Accommodation Date can't be after Leave Date");
                await ConfigureCreateVM(model, model.RoomId);
                return View(model);
            }
            //Check if nubmer of people is more than room capacity
            if (await reservationsService.GetRoomCapacityAsync(model.RoomId) < model.Customers.Count)
            {
                ModelState.AddModelError(nameof(model.Customers), "Number of people exceeds Room Capacity");
                await ConfigureCreateVM(model, model.RoomId);
                return View(model);
            }
            //check if user inputed at least 1 customer
            if (!model.Customers.Any())
            {
                ModelState.AddModelError(nameof(model.Customers), "Add at least 1 person");
                await ConfigureCreateVM(model, model.RoomId);
                return View(model);
            }
            List<Customer> inputCustomers = model.Customers.Select(x => new Customer()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                PhoneNumber = x.PhoneNumber,
            }).ToList();
            //chek every inputted User if he exists in database
            foreach (var cust in inputCustomers)
            {
                Customer customer = await reservationsService.FindCustomerAsync(cust);
                if (customer == null)
                {
                    ModelState.AddModelError(nameof(model.Customers), $"{cust.FirstName} {cust.LastName} isn't found in the database. You have to first add him/her");
                    await ConfigureCreateVM(model, model.RoomId);
                    return View(model);
                }
                if (customer.Reservation != null)
                {
                    ModelState.AddModelError(nameof(model.Customers), $"{cust.FirstName} {cust.LastName} has already been asigned to a Reservation");
                    await ConfigureCreateVM(model, model.RoomId);
                    return View(model);
                }
            }
            if (ModelState.IsValid)
            {
                await reservationsService.CreateReservationAsync(model);
                return RedirectToAction(nameof(Index));
            }
            await ConfigureCreateVM(model, model.RoomId);
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
            //Gets current user's id
            model.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //Checks Accommodation and Leave date if they are sensible
            if (CheckDurationOfDates(model))
            {
                ModelState.AddModelError(nameof(model.LeaveDate), "Leave date can't be before Accommodation Date");
                ModelState.AddModelError(nameof(model.AccommodationDate), "Accommodation Date can't be after Leave Date");
                return View(await reservationsService.EditReservationByIdAsync(model.Id));
            }

            await reservationsService.UpdateReservationAsync(model);

            return RedirectToAction(nameof(Index));
        }
        private async Task ConfigureCreateVM(ReservationCreateViewModel model, string roomId)
        {
            model.Rooms = new SelectList(await reservationsService.GetFreeRoomsSelectListAsync(), "Id", "Number");
            if (!String.IsNullOrEmpty(roomId) && await reservationsService.GetRoomCapacityAsync(roomId) > 0)
            {
                model.RoomId = roomId;
                model.SelectedRoomCap = await reservationsService.GetRoomCapacityAsync(roomId);
            }
            for (int i = 0; i < model.SelectedRoomCap; i++)
            {
                model.Customers.Add(new CustomerCreateViewModel());
            }
        }
        private static bool CheckDurationOfDates(ReservationCreateViewModel model)
        {
            return model.LeaveDate < model.AccommodationDate;
        }
        private static bool CheckDurationOfDates(ReservationEditViewModel model)
        {
            return model.LeaveDate < model.AccommodationDate;
        }
    }
}
