using Retail_backend.Models;
using Retail_backend.Repositories.Interfaces;

namespace Retail_backend.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        public Task<Inventory> CreateAsync(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public Task<Inventory?> GetByProductIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Inventory> UpdateAsync(Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
