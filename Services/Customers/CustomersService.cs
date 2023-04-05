using Hotel_Reservation_Manager.Data;
using Hotel_Reservation_Manager.Data.Models;
using Hotel_Reservation_Manager.ViewModels;
using Hotel_Reservation_Manager.ViewModels.CustomerHistory;
using Hotel_Reservation_Manager.ViewModels.Customers;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation_Manager.Services.Customers
{
    public class CustomersService : ICustomersService
    {
        private readonly ApplicationDbContext context;
        public CustomersService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<CustomersIndexViewModel> GetCustomersAsync(CustomersIndexViewModel model)
        {
            model.Customers = await this.context.Customers
                .Skip((model.Page - 1) * model.ItemsPerPage)
                .Take(model.ItemsPerPage)
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

            model.ElementsCount = await this.context.Customers.CountAsync();

            return model;
        }


        public async Task CreateCustomerAsync(CustomerCreateViewModel model)
        {
            Customer customer = new Customer()
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IsAdult = model.IsAdult,
                PhoneNumber = model.PhoneNumber,
            };
            await this.context.Customers.AddAsync(customer);
            await this.context.SaveChangesAsync();
        }
        public async Task<CustomerDetailsViewModel> GetCustomerDetailsByIdAsync(string id)
        {
            //TODO Dispaly info about reservation
            Customer customer = await this.context.Customers.FindAsync(id);
            if (customer != null)
            {
                CustomerDetailsViewModel model = new CustomerDetailsViewModel()
                {
                    Id = customer.Id,
                    Email = customer.Email,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    IsAdult = customer.IsAdult,
                    PhoneNumber = customer.PhoneNumber,
                };

                List<CustomerHistoryViewModel> history = await context.CustomerHistory.Where(x => x.CustomerId == customer.Id).Select(x => new CustomerHistoryViewModel()
                {
                    CustomerId = x.CustomerId,
                    ResPrice = x.ResPrice,
                    Customer = x.Customer,
                    ResAccomDate = x.ResAccomDate,
                    ResLeaveDate = x.ResLeaveDate,
                    ResRoomNumber = x.ResRoomNumber
                }).ToListAsync();
                model.History = history;
                return model;
            }
            return null;
        }
        public async Task<CustomerEditViewModel> EditCustomerByIdAsync(string id)
        {
            Customer customer = await this.context.Customers.FindAsync(id);
            if (customer != null)
            {
                return new CustomerEditViewModel()
                {
                    Id = customer.Id,
                    Email = customer.Email,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    IsAdult = customer.IsAdult,
                    PhoneNumber = customer.PhoneNumber,
                };
            }
            return null;
        }
        public async Task UpdateCustomerAsync(CustomerEditViewModel model)
        {
            Customer customer = new Customer()
            {
                Id = model.Id,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                IsAdult = model.IsAdult,
                PhoneNumber = model.PhoneNumber,
            };
            this.context.Update(customer);
            await context.SaveChangesAsync();
        }
        public async Task<CustomerDetailsViewModel> DeleteCustomerByIdAsync(string id)
        {
            Customer customer = await this.context.Customers.FindAsync(id);
            if (customer != null)
            {
                CustomerDetailsViewModel model = new CustomerDetailsViewModel()
                {
                    Id = customer.Id,
                    Email = customer.Email,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    IsAdult = customer.IsAdult,
                    PhoneNumber = customer.PhoneNumber,
                };
                if (customer.Reservation != null)
                {
                    model.ReservationId = customer.Reservation.Id;
                }
                return model;
            }
            return null;
        }
        public async Task DeleteConfirmCustomerAsync(CustomerDetailsViewModel model)
        {
            Customer customer = await this.context.Customers.FindAsync(model.Id);
            if (customer != null)
            {
                if (customer.Reservation != null)
                {
                    customer.Reservation = null;
                }
                this.context.Customers.Remove(customer);
                await this.context.SaveChangesAsync();
            }
        }
    }
}
