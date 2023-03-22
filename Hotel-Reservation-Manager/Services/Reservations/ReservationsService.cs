using Hotel_Reservation_Manager.Data;
using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Hotel_Reservation_Manager.ViewModels.Reservations;
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

            // TODO Find Better way of handling input many Customers
            List<string> ids = model.CustomerId.Split(',').ToList();

            //Create Reservation
            Reservation reservation = new Reservation()
            {
                User = user,
                AccommodationDate = model.AccommodationDate,
                LeaveDate = model.LeaveDate,
                HasAllInclusive = model.HasAllInclusive,
                HasBreakfast = model.HasBreakfast,
                Price = model.Price,
            };
            //Adds Room to Reservation And Changes Status to false
            if (room.Id != reservation.RoomId)
            {
                AddReservationRoom(room, reservation);
            }
            //Add Reservation to database and save
            await this.context.Reservations.AddAsync(reservation);
            await this.context.SaveChangesAsync();

            //Add Reservation into each object Customer and Attach Reservation 
            foreach (var id in ids)
            {
                if (RoomHasCapacity(reservation, room))
                {
                    Customer customer = await context.Customers.FindAsync(id);
                    if (customer != null)
                    {
                        //Add Reservation to Customer 
                        customer.Reservation = reservation;
                    }
                    else
                    {
                        // TODO Create Customer if he doesn't exist when creating Reservation
                    }
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
                    Price = (int)reservation.Price,
                };
                model.Customers = reservation.Customers.ToList();
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
                if (!RoomHasCapacity(reservation, room))
                {
                    throw new InvalidOperationException("Selected Room does not have enough capacity");
                }
                if (RoomIsAvailable(room))
                {
                    AddReservationRoom(room, reservation);
                }
                else
                {
                    throw new InvalidOperationException("Selected Room isn't available");
                }
            }

            reservation.AccommodationDate = editmodel.AccommodationDate;
            reservation.LeaveDate = editmodel.LeaveDate;

            reservation.HasAllInclusive = editmodel.HasAllInclusive;
            reservation.HasBreakfast = editmodel.HasBreakfast;

            reservation.Price = editmodel.Price;



            List<string> cusIdsToDel = new List<string>();

            if (!string.IsNullOrEmpty(editmodel.CustomerToRemoveId))
            {
                cusIdsToDel = editmodel.CustomerToRemoveId.Split(',').ToList();
            }
            foreach (var id in cusIdsToDel)
            {
                Customer cust = await context.Customers.FindAsync(id);
                if (cust != null)
                {
                    if (cust.ReservationId == reservation.Id)
                    {
                        await RemoveCustomerReservationAsync(cust, reservation);
                    }
                }
            }


            List<string> cusIdsToAdd = new List<string>();
            if (!string.IsNullOrEmpty(editmodel.CustomerToAddId))
            {
                cusIdsToAdd = editmodel.CustomerToAddId.Split(',').ToList();
            }
            foreach (var id in cusIdsToAdd)
            {
                await AddCustomerToReservationAsync(id, reservation,
                "DynamicEmail", "DynamicFName", "DynamicLName", "DynamicPhone", false, room);
            }

            context.Update(reservation);
            await context.SaveChangesAsync();
            if (!reservation.Customers.Any())
            {
                context.Remove(reservation);
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
                    r.Room.Reservation = null;
                }
                this.context.Reservations.Remove(r);
                await this.context.SaveChangesAsync();
            }
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
        private async Task AddCustomerToReservationAsync(string CustomerToAddId, Reservation reservation,
            string email, string firstname, string lastname, string phone, bool isadult, Room dbroom)
        {
            Customer dbCustomer = await context.Customers.FindAsync(CustomerToAddId);

            if (dbCustomer == null)
            {
                //Create new customer if == null
                var existingReservation = context.Reservations.Local.SingleOrDefault(o => o.Id == reservation.Id);
                if (existingReservation != null)
                    context.Entry(existingReservation).State = EntityState.Modified;

                if (RoomHasCapacity(reservation, dbroom))
                {
                    Customer newCustomer = new Customer
                    {
                        Email = email,
                        FirstName = firstname,
                        LastName = lastname,
                        IsAdult = isadult,
                        PhoneNumber = phone,
                    };
                    newCustomer.Reservation = reservation;
                    newCustomer.ReservationId = reservation.Id;

                    context.Add(newCustomer);
                    await context.SaveChangesAsync();
                }
                else
                {
                    throw new InvalidOperationException("Reserved Room does not have enough capacity to add more people");
                }
            }
            else
            {
                if (RoomHasCapacity(reservation, dbroom))
                {
                    var existingReservation = context.Reservations.Local.SingleOrDefault(o => o.Id == reservation.Id);
                    if (existingReservation != null)
                        context.Entry(existingReservation).State = EntityState.Modified;

                    //Adds customer if he exists
                    dbCustomer.Reservation = reservation;
                    dbCustomer.ReservationId = reservation.Id;

                    context.Add(dbCustomer);
                    await context.SaveChangesAsync();
                }
            }
        }
        private static void AddReservationRoom(Room room, Reservation reservation)
        {
            room.IsAvailable = false;
            reservation.Room.IsAvailable = true;
            reservation.RoomId = room.Id;
            room.ReservationId = reservation.Id;
        }
        public static bool RoomHasCapacity(Reservation res, Room room)
        {
            return room.Capacity > res.Customers.Count();
        }
        public static bool RoomIsAvailable(Room room)
        {
            return room.IsAvailable;
        }


    }
}
