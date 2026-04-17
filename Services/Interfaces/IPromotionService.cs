using Retail_backend.DTOs.Promotion;

namespace Retail_backend.Services.Interfaces
{
    public interface IPromotionService
    {
        Task<CouponDto?> ValidateCouponAsync(string code);
        Task<decimal> ApplyDiscountAsync(decimal amount, string code);
        Task<LoyaltyDto?> GetLoyaltyAsync(int userId);
        Task AddLoyaltyPointsAsync(int userId, int points);
    }
}
