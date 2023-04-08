using Hotel_Reservation_Manager.Data;
using Hotel_Reservation_Manager.Data.Enums;
using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Rooms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services.Rooms
{
    public class RoomsService : IRoomsService
    {
        private readonly ApplicationDbContext context;
        public RoomsService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<RoomsIndexViewModel> GetRoomsAsync(RoomsIndexViewModel model)
        {
            model.Rooms = await this.context.Rooms
                .Where(x => x.Capacity >= model.Filter.Capacity )
                .Where(x => model.Filter.Type != null ? x.RoomType == Enum.Parse<RoomType>(model.Filter.Type) : x.Id != null)
                .Where(x => x.IsAvailable == model.Filter.IsAvailable)
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
                .Select(x => new RoomIndexViewModel()
                {
                    Id = x.Id,
                    Capacity = x.Capacity,
                    RoomType = x.RoomType,
                    IsAvailable = x.IsAvailable,
                    PricePerBedAdult = x.PricePerBedAdult,
                    PricePerBedChild = x.PricePerBedChild,
                    Number = x.Number,
                })
                .ToListAsync();
            model.ElementsCount = await this.context.Customers.CountAsync();
            return model;
        }
        public async Task<RoomDetailsViewModel> GetRoomDetailsByIdAsync(string id)
        {
            Room room = await this.context.Rooms.FindAsync(id);
            if (room != null)
            {
                RoomDetailsViewModel model = new RoomDetailsViewModel()
                {
                    Id = room.Id,
                    Capacity = room.Capacity,
                    IsAvailable = room.IsAvailable,
                    Number = room.Number,
                    PricePerBedAdult = room.PricePerBedAdult,
                    PricePerBedChild = room.PricePerBedChild,
                    RoomType = room.RoomType,
                };
                return model;
            }
            return null;
        }
        public async Task<bool> DoesRoomNumberExist(int modelNumber,string roomId=null)
        {
            var roomx = context.Rooms.Where(x=>x.Number==modelNumber).Select(x => new Room()
            {
                Id=x.Id,
                Number = x.Number,
            });
            foreach (var room in roomx)
            {
                if (room.Id!=roomId)
                {
                    return true;
                }
            }
            return false;
        }
        public async Task CreateRoomAsync(RoomCreateViewModel model)
        {
            Room room = new Room()
            {
                Capacity = model.Capacity,
                IsAvailable = model.IsAvailable,
                Number = model.Number,
                PricePerBedAdult = model.PricePerBedAdult,
                PricePerBedChild = model.PricePerBedChild,
                RoomType = model.RoomType,
            };
            await this.context.Rooms.AddAsync(room);
            await this.context.SaveChangesAsync();
        }
        public async Task<RoomEditViewModel> EditRoomByIdAsync(string id)
        {
            Room room = await this.context.Rooms.FindAsync(id);
            if (room != null)
            {
                return new RoomEditViewModel()
                {
                    Id = room.Id,
                    Capacity = room.Capacity,
                    IsAvailable = room.IsAvailable,
                    Number = room.Number,
                    PricePerBedAdult = room.PricePerBedAdult,
                    PricePerBedChild = room.PricePerBedChild,
                    RoomType = room.RoomType,
                };
            }
            return null;
        }
        public async Task UpdateRoomAsync(RoomEditViewModel model)
        {
            Room room = new Room()
            {
                Id = model.Id,
                Capacity = model.Capacity,
                IsAvailable = model.IsAvailable,
                Number = model.Number,
                PricePerBedAdult = model.PricePerBedAdult,
                PricePerBedChild = model.PricePerBedChild,
                RoomType = model.RoomType,
            };
            context.Update(room);
            await context.SaveChangesAsync();
        }
        public async Task<RoomDetailsViewModel> DeleteRoomByIdAsync(string id)
        {
            Room room = await this.context.Rooms.FindAsync(id);
            if (room != null)
            {
                return new RoomDetailsViewModel()
                {
                    Capacity = room.Capacity,
                    Id = room.Id,
                    IsAvailable = room.IsAvailable,
                    Number = room.Number,
                    PricePerBedAdult = room.PricePerBedAdult,
                    PricePerBedChild = room.PricePerBedChild,
                    RoomType = room.RoomType,
                };
            }
            return null;
        }
        public async Task DeleteConfirmRoomAsync(RoomDetailsViewModel model)
        {
            Room room = await this.context.Rooms.FindAsync(model.Id);
            if (room != null)
            {
                this.context.Rooms.Remove(room);
                await this.context.SaveChangesAsync();
            }
        }
    }
}
