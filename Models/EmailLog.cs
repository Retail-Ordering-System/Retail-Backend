namespace Retail_backend.Models
{

    public class EmailLog
    {
        public int EmailLogId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public string EmailType { get; set; } = string.Empty;   // e.g. "OrderConfirmation"
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = string.Empty;      // "Sent" / "Failed"
        public string ErrorMessage { get; set; } = string.Empty;

        // Navigation
        public User? User { get; set; }
        public Order? Order { get; set; }
    }
}
