namespace Retail_backend.DTOs.Promotion
{
    public class ValidateCouponDto
    {
        public string Code { get; set; } = string.Empty;
        public decimal CartTotal { get; set; }
    }
}
