using Retail_backend.Models;

namespace Retail_backend.Repositories.Interfaces
{
    public interface ICouponRepository
    {
        Task<Coupon?> GetByCodeAsync(string code);
        Task<List<Coupon>> GetAllAsync();
        Task<Coupon> CreateAsync(Coupon coupon);
    }
}
