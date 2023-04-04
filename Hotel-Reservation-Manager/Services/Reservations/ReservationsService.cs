using Hotel_Reservation_Manager.Data;
using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Hotel_Reservation_Manager.ViewModels.Reservations;
using Hotel_Reservation_Manager.ViewModels.Rooms;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services.Reservations
{
    public class ReservationsService : IReservationsService
    {
        private readonly ApplicationDbContext context;
        public ReservationsService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task CreateReservationAsync(ReservationCreateViewModel model)
        {
            User user = await context.Users.FindAsync(model.UserId);
            Room room = await context.Rooms.FindAsync(model.RoomId);

            List<Customer> SelectedCustomers = model.Customers
                .Select(x => new Customer
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    PhoneNumber = x.PhoneNumber,
                }).ToList();

            //Create Reservation
            Reservation reservation = new Reservation()
            {
                User = user,
                AccommodationDate = model.AccommodationDate,
                LeaveDate = model.LeaveDate,
                HasAllInclusive = model.HasAllInclusive,
                HasBreakfast = model.HasBreakfast,
            };
            reservation.Customers = new List<Customer>();

            reservation.Price = CalculateInitialPrice(model.HasBreakfast, model.HasAllInclusive);

            if (room.Id != reservation.RoomId)
            {
                Reservation roomres = await context.Reservations.FirstOrDefaultAsync(x => x.RoomId == room.Id);
                if (roomres == null && room.IsAvailable)
                {
                    ReserveRoom(room, reservation);
                }
            }

            //Add Reservation to database and save
            await this.context.Reservations.AddAsync(reservation);
            await this.context.SaveChangesAsync();

            foreach (var cust in SelectedCustomers)
            {
                Customer customer = await FindCustomerAsync(cust);
                if (customer.Reservation == null && room.Capacity > reservation.Customers.Count)
                {
                    await AddCustomerToReservationAsync(customer, reservation);
                    reservation.Price += CalculatePrice(model.LeaveDate, model.AccommodationDate, room, customer);
                }
            }

            //Attach instance of Reservation
            context.Reservations.Attach(reservation);
            await this.context.SaveChangesAsync();
        }
        public async Task<ReservationsIndexViewModel> GetReservationsAsync()
        {
            ReservationsIndexViewModel model = new ReservationsIndexViewModel();
            model.Reservations = await context.Reservations.Select(x => new ReservationIndexViewModel()
            {
                Id = x.Id,
                UserId = x.UserId,
                RoomId = x.RoomId,
                AccommodationDate = x.AccommodationDate,
                LeaveDate = x.LeaveDate,
                HasAllInclusive = x.HasAllInclusive,
                HasBreakfast = x.HasBreakfast,
                Price = x.Price,
            })
                .ToListAsync();
            return model;
        }
        public async Task<ReservationDetailsViewModel> GetReservationDetailsAsync(string id)
        {
            Reservation reservation = await this.context.Reservations.FindAsync(id);

            if (reservation != null)
            {
                ReservationDetailsViewModel model = new ReservationDetailsViewModel()
                {
                    Id = reservation.Id,
                    UserId = reservation.UserId,
                    RoomId = reservation.RoomId,
                    AccommodationDate = reservation.AccommodationDate,
                    LeaveDate = reservation.LeaveDate,
                    HasAllInclusive = reservation.HasAllInclusive,
                    HasBreakfast = reservation.HasBreakfast,
                    Price = reservation.Price,
                };

                //Get customers for Current Reservation
                model.Customers = await context.Customers
                    .Where(x => x.ReservationId == model.Id)
                    .Select(x => new CustomerIndexViewModel()
                    {
                        Id = x.Id,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        IsAdult = x.IsAdult,
                        PhoneNumber = x.PhoneNumber,
                    })
                .ToListAsync();
                return model;
            }
            return null;
        }
        public async Task<ReservationEditViewModel> EditReservationByIdAsync(string id)
        {
            Reservation reservation = await context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                ReservationEditViewModel model = new ReservationEditViewModel()
                {
                    Id = reservation.Id,
                    UserId = reservation.UserId,
                    RoomId = reservation.RoomId,
                    AccommodationDate = reservation.AccommodationDate,
                    LeaveDate = reservation.LeaveDate,
                    HasAllInclusive = reservation.HasAllInclusive,
                    HasBreakfast = reservation.HasBreakfast,
                };

                model.CustomersToRemove = reservation.Customers.Select(x => new CustomerEditViewModel()
                {
                    Id = x.Id,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    IsAdult = x.IsAdult,
                    LastName = x.LastName,
                    PhoneNumber = x.PhoneNumber,
                }).ToList();

                SelectList selectList = new SelectList(await GetAllRoomsSelectListAsync(model), "Id", "Number");
                model.Rooms = selectList;

                if (!String.IsNullOrEmpty(model.RoomId) && await GetRoomCapacityAsync(model.RoomId) > 0)
                {
                    model.SelectedRoomCap = await GetRoomCapacityAsync(model.RoomId);

                    for (int i = 0; i < model.SelectedRoomCap - reservation.Customers.Count; i++)
                    {
                        model.CustomersToAdd.Add(new CustomerEditViewModel());
                    }

                }
                return model;
            }
            return null;
        }
        public async Task UpdateReservationAsync(ReservationEditViewModel editmodel)
        {
            User user = await context.Users.FindAsync(editmodel.UserId);
            Room room = await context.Rooms.FindAsync(editmodel.RoomId);
            Reservation reservation = await context.Reservations.FindAsync(editmodel.Id);

            reservation.User = user;

            if (room.Id != reservation.RoomId)
            {
                ReserveRoom(room, reservation);
            }

            reservation.AccommodationDate = editmodel.AccommodationDate;
            reservation.LeaveDate = editmodel.LeaveDate;

            reservation.HasAllInclusive = editmodel.HasAllInclusive;
            reservation.HasBreakfast = editmodel.HasBreakfast;

            reservation.Price = CalculateInitialPrice(editmodel.HasBreakfast, editmodel.HasAllInclusive);

            List<Customer> CustomersToAdd = editmodel.CustomersToAdd
            .Select(x => new Customer
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                PhoneNumber = x.PhoneNumber,
            }).ToList();

            foreach (var cust in CustomersToAdd)
            {
                Customer customer = await FindCustomerAsync(cust);
                if (customer != null && customer.ReservationId != reservation.Id)
                {
                    await AddCustomerToReservationAsync(customer, reservation);
                }
            }

            foreach (var cust in editmodel.CustomersToRemove)
            {
                Customer customer = await context.Customers.FindAsync(cust.Id);
                if (customer != null && customer.ReservationId == reservation.Id)
                {
                    await RemoveCustomerReservationAsync(customer, reservation);
                }
            }


            foreach (var item in reservation.Customers)
            {
                reservation.Price += CalculatePrice(editmodel.LeaveDate, editmodel.AccommodationDate, room, item);
            }




            context.Update(reservation);
            await context.SaveChangesAsync();
            if (!reservation.Customers.Any())
            {
                context.Remove(reservation);
                if (reservation.Room != null)
                {
                    reservation.Room.IsAvailable = true;
                    reservation.Room.Reservation = null;
                }
                await context.SaveChangesAsync();
            }
        }
        public async Task<ReservationDeleteViewModel> GetReservationToDeleteAsync(string id)
        {
            Reservation reservation = await this.context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                ReservationDeleteViewModel model = new ReservationDeleteViewModel()
                {
                    Id = reservation.Id,
                    AccommodationDate = reservation.AccommodationDate,
                    LeaveDate = reservation.LeaveDate,
                    UserId = reservation.UserId,
                    RoomId = reservation.RoomId,
                    HasAllInclusive = reservation.HasAllInclusive,
                    HasBreakfast = reservation.HasBreakfast,
                    Price = reservation.Price,
                };

                //Get customers for Current Reservation
                model.Customers = await context.Customers
                    .Where(x => x.ReservationId == model.Id)
                    .Select(x => new CustomerIndexViewModel()
                    {
                        Id = x.Id,
                        Email = x.Email,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        IsAdult = x.IsAdult,
                        PhoneNumber = x.PhoneNumber,
                    })
                .ToListAsync();
                return model;
            }
            return null;
        }
        public async Task DeleteReservationAsync(ReservationDeleteViewModel model)
        {
            Reservation r = await this.context.Reservations.FindAsync(model.Id);
            if (r != null)
            {
                foreach (var cust in r.Customers)
                {
                    cust.Reservation = null;
                }

                if (r.Room != null)
                {
                    r.Room.IsAvailable = true;
                    r.Room.Reservation = null;
                }
                this.context.Reservations.Remove(r);
                await this.context.SaveChangesAsync();
            }
        }
        private static void ReserveRoom(Room room, Reservation reservation)
        {
            room.IsAvailable = false;
            if (reservation.Room != null)
            {
                reservation.Room.IsAvailable = true;
                reservation.Room.Reservation = null;
            }
            reservation.RoomId = room.Id;
            room.ReservationId = reservation.Id;
        }
        public async Task<List<RoomSelectListViewModel>> GetFreeRoomsSelectListAsync()
        {
            List<RoomSelectListViewModel> SelectList = await this.context.Rooms.Where(x => x.Reservation == null).Select(x => new RoomSelectListViewModel()
            {
                Id = x.Id,
                Capacity = x.Capacity,
                RoomType = x.RoomType,
                PricePerBedAdult = x.PricePerBedAdult,
                PricePerBedChild = x.PricePerBedChild,
                Number = x.Number,
            })
                .ToListAsync();
            return SelectList;
        }
        public async Task<List<RoomSelectListViewModel>> GetAllRoomsSelectListAsync(ReservationEditViewModel model)
        {
            List<RoomSelectListViewModel> SelectList = await GetFreeRoomsSelectListAsync();
            Room room = await context.Rooms.FirstOrDefaultAsync(x => x.Id == model.RoomId);
            RoomSelectListViewModel vm = new RoomSelectListViewModel()
            {
                Id = room.Id,
                Capacity = room.Capacity,
                RoomType = room.RoomType,
                Number = room.Number,
                PricePerBedAdult = room.PricePerBedAdult,
                PricePerBedChild = room.PricePerBedChild,
            };
            SelectList.Add(vm);
            return SelectList;
        }
        private async Task RemoveCustomerReservationAsync(Customer dbCustomer, Reservation res)
        {
            var existingReservation = context.Reservations.Local.SingleOrDefault(o => o.Id == res.Id);
            if (existingReservation != null)
                context.Entry(existingReservation).State = EntityState.Modified;

            dbCustomer.Reservation = null;

            context.Update(dbCustomer);
            await context.SaveChangesAsync();
        }
        private async Task AddCustomerToReservationAsync(Customer dbCustomer,
            Reservation reservation)
        {
            dbCustomer.Reservation = reservation;

            CustomerHistory ch = new CustomerHistory()
            {
                Customer = dbCustomer,
                ResAccomDate = reservation.AccommodationDate,
                ResLeaveDate = reservation.LeaveDate,
                ResPrice = reservation.Price,
                ResRoomNumber = reservation.Room.Number,
            };

            context.CustomerHistory.Add(ch);

            context.Reservations.Attach(reservation);
            await this.context.SaveChangesAsync();
        }
        public async Task<int> GetRoomCapacityAsync(string id)
        {
            Room room = await context.Rooms.FindAsync(id);
            return room.Capacity;
        }
        public async Task<Customer> FindCustomerAsync(Customer cust)
        {
            Customer customer = await context.Customers.FirstOrDefaultAsync(x => x.FirstName == cust.FirstName &&
x.LastName == cust.LastName && x.PhoneNumber == cust.PhoneNumber /*&& x.IsAdult == cust.IsAdult*/);
            if (customer != null)
            {
                return customer;
            }
            else
            {
                return null;
            }
        }
        private decimal CalculateInitialPrice(Boolean HasBreakfast, Boolean HasAllInclusive)
        {
            decimal price = new decimal();
            if (HasBreakfast)
            {
                price += 150;
            }
            if (HasAllInclusive)
            {
                price += 300;
            }
            return price;
        }
        private decimal CalculatePrice(DateTime leaveDate, DateTime accomdate, Room room,
    Customer cust)
        {

            TimeSpan duration = leaveDate - accomdate;
            if (leaveDate == accomdate)
            {
                duration = TimeSpan.FromDays(1);
            }
            decimal price = new decimal();

            Customer dbc = context.Customers.Find(cust.Id);
            if (dbc.IsAdult)
            {
                price += room.PricePerBedAdult * (decimal)duration.TotalDays;
            }
            if (!dbc.IsAdult)
            {
                price += room.PricePerBedChild * (decimal)duration.TotalDays;
            }
            return price;
        }
    }
}
