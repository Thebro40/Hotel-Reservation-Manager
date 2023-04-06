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
    [Authorize(Roles = "Admin,User")]
    public class ReservationsController : Controller
    {
        private readonly IReservationsService reservationsService;
        public ReservationsController(IReservationsService reservationsService)
        {
            this.reservationsService = reservationsService;
        }
        public async Task<IActionResult> Index(ReservationsIndexViewModel model)
        {
            model = await reservationsService.GetReservationsAsync(model);
            return View(model);
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

            // Check if user submitted a roomid
            if (model.RoomId==null)
            {
                ModelState.AddModelError(nameof(model.RoomId), "Please select and submit a room");
                await ConfigureCreateVM(model, model.RoomId);
                return View(model);
            }
            //Checks Accommodation and Leave date if they are sensible
            if (CheckDurationOfDates(model.LeaveDate,model.AccommodationDate))
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
            //chek every inputted User if he exists in database and if he already has a reservation
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

            //Remove temporary empty Customer objects
            model.CustomersToAdd = model.CustomersToAdd.Where(x => x.FirstName != null && x.LastName != null && x.PhoneNumber != null).ToList();
            model.CustomersToRemove = model.CustomersToRemove.Where(x=>x.RemoveFromRes).ToList();

            // Check if user submitted a roomid
            if (model.RoomId == null)
            {
                ModelState.AddModelError(nameof(model.RoomId), "Please select and submit a room");
                return View(await reservationsService.EditReservationByIdAsync(model.Id));
            }
            //Checks Accommodation and Leave date if they are sensible
            if (CheckDurationOfDates(model.LeaveDate, model.AccommodationDate))
            {
                ModelState.AddModelError(nameof(model.LeaveDate), "Leave date can't be before Accommodation Date");
                ModelState.AddModelError(nameof(model.AccommodationDate), "Accommodation Date can't be after Leave Date");
                return View(await reservationsService.EditReservationByIdAsync(model.Id));
            }
            //Check if nubmer of people is more than room capacity
            if (await reservationsService.GetRoomCapacityAsync(model.RoomId) < model.CustomersToAdd.Count)
            {
                ModelState.AddModelError(nameof(model.CustomersToAdd), "Number of people exceeds Room Capacity");
                return View(await reservationsService.EditReservationByIdAsync(model.Id));
            }
            List<Customer> inputCustomers = model.CustomersToAdd.Select(x => new Customer()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                PhoneNumber = x.PhoneNumber,
            }).ToList();
            //chek every inputted User if he exists in database and if he already has a reservation
            foreach (var cust in inputCustomers)
            {
                Customer customer = await reservationsService.FindCustomerAsync(cust);
                if (customer == null)
                {
                    ModelState.AddModelError(nameof(model.CustomersToAdd), $"{cust.FirstName} {cust.LastName} isn't found in the database. You have to first add him/her");
                    return View(await reservationsService.EditReservationByIdAsync(model.Id));
                }
                if (customer.Reservation != null)
                {
                    ModelState.AddModelError(nameof(model.CustomersToAdd), $"{cust.FirstName} {cust.LastName} has already been asigned to a Reservation");
                    return View(await reservationsService.EditReservationByIdAsync(model.Id));
                }
            }
            if (ModelState.IsValid)
            {
                await reservationsService.UpdateReservationAsync(model);

                return RedirectToAction(nameof(Index));
            }
            return View(await reservationsService.EditReservationByIdAsync(model.Id));
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
        private static bool CheckDurationOfDates(DateTime LeaveDate, DateTime AccommodationDate)
        {
            return LeaveDate < AccommodationDate;
        }
    }
}
