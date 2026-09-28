using ParcialOrder.Domain.Aggregates;

namespace ParcialOrder.Domain.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order> CreateAsync(Order order);
        Task<bool> DeleteAsync(int id);
        Task<List<Order>> GetAsync();
        Task<List<Order>> GetByIdAsync(int id);
        string GetName();
        Task<Order> UpdateAsync(Order order);
    }
}