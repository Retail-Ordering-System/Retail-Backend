using Retail_backend.Models;

namespace Retail_backend.Repositories.Interfaces
{
    public interface ICartRepository
    {
        Task<Cart?> GetByUserIdAsync(int userId);
        Task<Cart> CreateAsync(Cart cart);
        Task<CartItem> AddItemAsync(CartItem item);
        Task<CartItem?> GetItemAsync(int cartItemId);
        Task<CartItem> UpdateItemAsync(CartItem item);
        Task<bool> RemoveItemAsync(int cartItemId);
        Task ClearAsync(int cartId);
    }
}
