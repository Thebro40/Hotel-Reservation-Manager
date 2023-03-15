using Hotel_Reservation_Manager.Services.Rooms;
using Hotel_Reservation_Manager.ViewModels.Rooms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Controllers
{
    public class RoomsController : Controller
    {
        public IRoomsService roomsService { get; set; }
        public RoomsController(IRoomsService roomsService)
        {
            this.roomsService = roomsService;
        }
        // GET: RoomsController
        public async Task<IActionResult> Index()
        {
            var rooms = await roomsService.GetRoomsAsync();
            return View(rooms);
        }

        // GET: RoomsController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            RoomDetailsViewModel model = await roomsService.GetRoomDetailsViewModelAsyncById(id);
            return View(model);
        }

        // GET: RoomsController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoomCreateViewModel model)
        {
            await roomsService.CreateRoomAsync(model);
            return RedirectToAction(nameof(Index));
        }

        // GET: RoomsController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            RoomEditViewModel model = await roomsService.GetRoomEditViewModelAsync(id);
            return View(model);
        }

        // POST: RoomsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RoomEditViewModel model)
        {
            await roomsService.UpdateRoom(model);
            return RedirectToAction(nameof(Index));
        }

        // GET: RoomsController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoomsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
