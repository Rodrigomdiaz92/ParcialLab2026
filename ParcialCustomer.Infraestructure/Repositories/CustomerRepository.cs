using Microsoft.EntityFrameworkCore;
using ParcialCustomer.Domain.Entities;
using ParcialCustomer.Domain.Interfaces;
using ParcialCustomer.Infraestructure.Data;


namespace ParcialCustomer.Infraestructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbConext _dbContext;
        public CustomerRepository(ApplicationDbConext dbContext)
        {
            _dbContext = dbContext;

        }
        public string GetName()
        {
            return "Customer";
        }

        public async Task<List<Customer>> GetAsync()
        {
            var result = await _dbContext.Customers.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Customer> CreateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
        public async Task<Customer> UpdateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
