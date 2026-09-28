using Microsoft.EntityFrameworkCore;
using ParcialProduct.Domain.Interfaces;
using ParcialProduct.Domain.Entities;
using ParcialProduct.Infraestructure.Data;

namespace ParcialProduct.Infraestructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbConext _dbContext;
        public ProductRepository(ApplicationDbConext dbContext)
        {
            _dbContext = dbContext;

        }
        public string GetName()
        {
            return "Product";
        }

        public async Task<List<Product>> GetAsync()
        {
            var result = await _dbContext.Products.ToListAsync();
            return result;
            //throw new NotImplementedException();
        }

        public async Task<List<Product>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<Product> CreateAsync(Product product)
        {
            throw new NotImplementedException();
        }
        public async Task<Product> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }



    }
}
