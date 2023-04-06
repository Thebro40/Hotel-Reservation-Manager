using Hotel_Reservation_Manager.Services.Rooms;
using Hotel_Reservation_Manager.ViewModels.Rooms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Controllers
{
    [Authorize]
    public class RoomsController : Controller
    {
        public IRoomsService roomsService { get; set; }
        public RoomsController(IRoomsService roomsService)
        {
            this.roomsService = roomsService;
        }
        // GET: RoomsController
        public async Task<IActionResult> Index(RoomsIndexViewModel model)
        {
            model = await roomsService.GetRoomsAsync(model);
            return View(model);
        }

        // GET: RoomsController/Details/5
        public async Task<IActionResult> Details(string id)
        {
            RoomDetailsViewModel model = await roomsService.GetRoomDetailsByIdAsync(id);
            return View(model);
        }

        // GET: RoomsController/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomsController/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoomCreateViewModel model)
        {
            if (await roomsService.DoesRoomNumberExist(model.Number))
            {
                ModelState.AddModelError(nameof(model.Number), "There is already a room with this number");
                return View(model);
            }
            await roomsService.CreateRoomAsync(model);
            return RedirectToAction(nameof(Index));
        }

        // GET: RoomsController/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            RoomEditViewModel model = await roomsService.EditRoomByIdAsync(id);
            return View(model);
        }

        // POST: RoomsController/Edit/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RoomEditViewModel model)
        {         
            if (await roomsService.DoesRoomNumberExist(model.Number,model.Id))
            {
                ModelState.AddModelError(nameof(model.Number), "There is already a room with this number");
                return View(model);
            }
            await roomsService.UpdateRoomAsync(model);
            return RedirectToAction(nameof(Index));
        }

        // GET: RoomsController/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            RoomDetailsViewModel model = await roomsService.DeleteRoomByIdAsync(id);
            return View(model);
        }

        // POST: RoomsController/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(RoomDetailsViewModel model)
        {
            await roomsService.DeleteConfirmRoomAsync(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
