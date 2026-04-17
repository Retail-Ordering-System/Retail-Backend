using Retail_backend.DTOs.Order;

namespace Retail_backend.Services.Interfaces
{
    public interface IOrderService
    {
        Task<OrderDto> PlaceOrderAsync(int userId, PlaceOrderDto dto);
        Task<List<OrderDto>> GetUserOrdersAsync(int userId);
        Task<OrderDto?> GetOrderByIdAsync(int orderId);
        Task<OrderDto?> UpdateStatusAsync(int orderId, string status);
    }
}
