using Retail_backend.DTOs.Order;
using Retail_backend.Services.Interfaces;

namespace Retail_backend.Services
{
    public class OrderService : IOrderService
    {
        public Task<OrderDto?> GetOrderByIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> GetUserOrdersAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto> PlaceOrderAsync(int userId, PlaceOrderDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto?> UpdateStatusAsync(int orderId, string status)
        {
            throw new NotImplementedException();
        }
    }
}
