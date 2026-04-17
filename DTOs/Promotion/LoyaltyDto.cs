namespace Retail_backend.DTOs.Promotion
{
    public class LoyaltyDto
    {
        public int LoyaltyId { get; set; }
        public int UserId { get; set; }
        public int Points { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
