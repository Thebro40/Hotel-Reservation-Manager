using Hotel_Reservation_Manager.Data;
using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Hotel_Reservation_Manager.ViewModels.Reservations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
                RoomId = room.Id,
                AccommodationDate = model.AccommodationDate,
                LeaveDate = model.LeaveDate,
                HasAllInclusive = model.HasAllInclusive,
                HasBreakfast = model.HasBreakfast,
                Price = model.Price,
            };

            reservation.Room = room;

            //Add Reservation to database and save
            await this.context.Reservations.AddAsync(reservation);
            await this.context.SaveChangesAsync();

            //Add Reservation into each object Customer and Attach Reservation 
            foreach (var id in ids)
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
                if (reservation != null)
                {
                    //Add Reservation to Room
                    room.Reservation = reservation;
                }
                ////Attach instance of Reservation
                //context.Reservations.Attach(reservation);
                //await this.context.SaveChangesAsync();
            }
            //Attach instance of Reservation
            context.Reservations.Attach(reservation);
            await this.context.SaveChangesAsync();
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
        public async Task<ReservationEditViewModel> EditReservationByIdAsync(string id)
        {
            Reservation reservation = await this.context.Reservations.FindAsync(id);
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
                model.OutputCustomers = new List<Customer>();
                foreach (var item in reservation.Customers)
                {
                    ///TODO ADD DEBUG
                    //model.CustomerId += item.Id + ',';
                    model.OutputCustomers.Add(item);
                }
                ///TODO REMOVE DEBUG
                model.CustomerToAddId = reservation.Customers.Select(x => x.Id).FirstOrDefault();
                model.CustomerToRemoveId = reservation.Customers.Select(x => x.Id).FirstOrDefault();

                return model;
            }
            return null;
        }
        public async Task UpdateReservationAsync(ReservationEditViewModel model)
        {
            User user = await context.Users.FindAsync(model.UserId);
            Room room = await context.Rooms.FindAsync(model.RoomId);
            Reservation reservation = await context.Reservations.FindAsync(model.Id);

            reservation.User = user;

            reservation.RoomId = room.Id;
            room.ReservationId = reservation.Id;
            if (reservation.Room != null)
            {
                if (reservation.Room.Id == room.Id & room != null)
                {
                    reservation.Room.Reservation = reservation;

                }
            }


            reservation.AccommodationDate = model.AccommodationDate;
            reservation.LeaveDate = model.LeaveDate;
            reservation.HasAllInclusive = model.HasAllInclusive;
            reservation.HasBreakfast = model.HasBreakfast;

            reservation.Price = model.Price;


            List<string> cusIdsToDel = new List<string>();

            if (!string.IsNullOrEmpty(model.CustomerToRemoveId))
            {
                cusIdsToDel = model.CustomerToRemoveId.Split(',').ToList();
            }
            foreach (var id in cusIdsToDel)
            {
                await DeleteCustomerFromReservationAsync(id, reservation);
            }

            List<string> cusIdsToAdd = new List<string>();
            if (!string.IsNullOrEmpty(model.CustomerToAddId))
            {
                cusIdsToAdd = model.CustomerToAddId.Split(',').ToList();
            }
            foreach (var id in cusIdsToAdd)
            {
                await CreateCustomerForReservationAsync(model, reservation,
                "DynamicEmail", "DynamicFName", "DynamicLName", "DynamicPhone", false);
            }




            context.Update(reservation);
            await context.SaveChangesAsync();
            if (!reservation.Customers.Any())
            {
                context.Remove(reservation);
                await context.SaveChangesAsync();
            }

        }
        private async Task DeleteCustomerFromReservationAsync(string CustomerToRemoveId, Reservation reservation)
        {
            Customer dbCustomer = await context.Customers.FindAsync(CustomerToRemoveId);
            if (dbCustomer != null)
            {

            
            var existingReservation = context.Reservations.Local.SingleOrDefault(o => o.Id == reservation.Id);
            if (existingReservation != null)
                context.Entry(existingReservation).State = EntityState.Modified;

            Customer localCustomer = reservation.Customers.FirstOrDefault();
            localCustomer.Reservation = null;
            localCustomer.ReservationId = null;

            context.Update(dbCustomer);
            await context.SaveChangesAsync();
            }
        }
        private async Task CreateCustomerForReservationAsync(ReservationEditViewModel model, Reservation reservation,
            string email, string firstname, string lastname, string phone, bool isadult)
        {
            Customer dbCustomer = await context.Customers.FindAsync(model.CustomerToAddId);
            if (dbCustomer == null)
            {
                var existingReservation = context.Reservations.Local.SingleOrDefault(o => o.Id == reservation.Id);
                if (existingReservation != null)
                    context.Entry(existingReservation).State = EntityState.Modified;

                Customer localCustomer = new Customer
                {
                    Email = email,
                    FirstName = firstname,
                    LastName = lastname,
                    IsAdult = isadult,
                    PhoneNumber = phone,
                };
                localCustomer.Reservation = reservation;
                localCustomer.ReservationId = reservation.Id;

                context.Add(localCustomer);
                await context.SaveChangesAsync();
            }
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
    }
}
