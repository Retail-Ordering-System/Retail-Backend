using Retail_backend.Models;
using Retail_backend.Repositories.Interfaces;

namespace Retail_backend.Repositories
{
    public class CouponRepository : ICouponRepository
    {
        public Task<Coupon> CreateAsync(Coupon coupon)
        {
            throw new NotImplementedException();
        }

        public Task<List<Coupon>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Coupon?> GetByCodeAsync(string code)
        {
            throw new NotImplementedException();
        }
    }
}
