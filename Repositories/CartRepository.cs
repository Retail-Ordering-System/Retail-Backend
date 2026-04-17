using Retail_backend.Models;
using Retail_backend.Repositories.Interfaces;

namespace Retail_backend.Repositories
{
    public class CartRepository : ICartRepository
    {
        public Task<CartItem> AddItemAsync(CartItem item)
        {
            throw new NotImplementedException();
        }

        public Task ClearAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<Cart> CreateAsync(Cart cart)
        {
            throw new NotImplementedException();
        }

        public Task<Cart?> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<CartItem?> GetItemAsync(int cartItemId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveItemAsync(int cartItemId)
        {
            throw new NotImplementedException();
        }

        public Task<CartItem> UpdateItemAsync(CartItem item)
        {
            throw new NotImplementedException();
        }
    }
}
