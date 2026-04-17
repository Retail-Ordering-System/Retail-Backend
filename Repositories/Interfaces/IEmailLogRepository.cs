using Retail_backend.Models;

namespace Retail_backend.Repositories.Interfaces
{
    public interface IEmailLogRepository
    {
        Task<EmailLog> CreateAsync(EmailLog log);
        Task<List<EmailLog>> GetByUserIdAsync(int userId);
    }
}
