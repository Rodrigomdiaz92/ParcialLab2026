using ParcialCustomer.Domain.Entities;

namespace ParcialCustomer.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> CreateAsync(Customer customer);
        Task<bool> DeleteAsync(int id);
        Task<List<Customer>> GetAsync();
        Task<List<Customer>> GetByIdAsync(int id);
        string GetName();
        Task<Customer> UpdateAsync(Customer customer);
    }
}