using Retail_backend.Models;

namespace Retail_backend.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<(List<Product> Items, int Total)> GetAllAsync(
            string? search, int? categoryId, int? brandId,
            decimal? minPrice, decimal? maxPrice,
            int page, int pageSize);
        Task<Product?> GetByIdAsync(int id);
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);
    }
}
