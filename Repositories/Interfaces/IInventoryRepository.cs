using Retail_backend.Models;

namespace Retail_backend.Repositories.Interfaces
{
    public interface IInventoryRepository
    {
        Task<Inventory?> GetByProductIdAsync(int productId);
        Task<Inventory> UpdateAsync(Inventory inventory);
        Task<Inventory> CreateAsync(Inventory inventory);
    }
}
