using Microsoft.EntityFrameworkCore;
using ParcialOrder.Domain.Aggregates;
using ParcialOrder.Domain.Interfaces;
using ParcialOrder.Infraestructure.Data;


namespace ParcialOrder.Infraestructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbConext _dbContext;
        public OrderRepository(ApplicationDbConext dbContext)
        {
            _dbContext = dbContext;

        }
        public string GetName()
        {
            return "Order";
        }

        public async Task<List<Order>> GetAsync()
        {
            var result = await _dbContext.Orders.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<Order>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Order> CreateAsync(Order order)
        {
            throw new NotImplementedException();
        }
        public async Task<Order> UpdateAsync(Order order)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
