using Retail_backend.DTOs.Order;
using Retail_backend.Models;
using Retail_backend.Repositories.Interfaces;
using Retail_backend.Services.Interfaces;

namespace Retail_backend.Services
{
    public class CartService : ICartService
    {
        public Task<CartDto> AddItemAsync(int userId, CartItemDto dto)
        {
            throw new NotImplementedException();
        }

        public Task ClearCartAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<CartDto?> GetCartAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveItemAsync(int userId, int cartItemId)
        {
            throw new NotImplementedException();
        }

        public Task<CartDto> UpdateItemAsync(int userId, int cartItemId, int quantity)
        {
            throw new NotImplementedException();
        }

        Task<CartDto> ICartService.AddItemAsync(int userId, CartItemDto dto)
        {
            throw new NotImplementedException();
        }

        Task<CartDto?> ICartService.GetCartAsync(int userId)
        {
            throw new NotImplementedException();
        }

        Task<CartDto> ICartService.UpdateItemAsync(int userId, int cartItemId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
