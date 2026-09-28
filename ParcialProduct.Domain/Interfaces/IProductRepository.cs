using ParcialProduct.Domain.Entities;

namespace ParcialProduct.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> CreateAsync(Product product);
        Task<bool> DeleteAsync(int id);
        Task<List<Product>> GetAsync();
        Task<List<Product>> GetByIdAsync(int id);
        string GetName();
        Task<Product> UpdateAsync(Product product);
    }
}