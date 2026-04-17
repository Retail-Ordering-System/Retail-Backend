using Retail_backend.DTOs.Inventory;
using Retail_backend.Services.Interfaces;

namespace Retail_backend.Services
{
    public class InventoryService : IInventoryService
    {
        public Task DeductStockOnOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<InventoryDto?> GetByProductIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<InventoryDto> UpdateStockAsync(int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        Task<InventoryDto?> IInventoryService.GetByProductIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        Task<InventoryDto> IInventoryService.UpdateStockAsync(int productId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
