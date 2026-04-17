using Retail_backend.DTOs.Order;

namespace Retail_backend.Services.Interfaces
{
    public interface ICartService
    {
        Task<CartDto?> GetCartAsync(int userId);
        Task<CartDto> AddItemAsync(int userId, CartItemDto dto);
        Task<CartDto> UpdateItemAsync(int userId, int cartItemId, int quantity);
        Task<bool> RemoveItemAsync(int userId, int cartItemId);
        Task ClearCartAsync(int userId);
    }
}
