using Retail_backend.Services.Interfaces;

namespace Retail_backend.Services
{
    public class EmailService : IEmailService
    {
        public Task SendOrderConfirmationAsync(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
