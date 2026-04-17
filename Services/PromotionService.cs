using Retail_backend.DTOs.Promotion;
using Retail_backend.Services.Interfaces;

namespace Retail_backend.Services
{
    public class PromotionService : IPromotionService
    {
        public Task AddLoyaltyPointsAsync(int userId, int points)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> ApplyDiscountAsync(decimal amount, string code)
        {
            throw new NotImplementedException();
        }

        public Task<LoyaltyDto?> GetLoyaltyAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<CouponDto?> ValidateCouponAsync(string code)
        {
            throw new NotImplementedException();
        }
    }
}
