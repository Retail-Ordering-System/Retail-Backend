using Retail_backend.Models;
using Retail_backend.Repositories.Interfaces;

namespace Retail_backend.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task<Order> CreateAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order?> GetByIdAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
