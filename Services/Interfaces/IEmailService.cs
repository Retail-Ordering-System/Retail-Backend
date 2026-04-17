namespace Retail_backend.Services.Interfaces
{
    public interface IEmailService
    {
        Task SendOrderConfirmationAsync(int orderId);
    }
}
