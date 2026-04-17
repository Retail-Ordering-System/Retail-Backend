using Retail_backend.DTOs.Inventory;

namespace Retail_backend.Services.Interfaces
{
    public interface IInventoryService
    {
        Task<InventoryDto?> GetByProductIdAsync(int productId);
        Task<InventoryDto> UpdateStockAsync(int productId, int quantity);
        Task DeductStockOnOrderAsync(int orderId);
    }
}
