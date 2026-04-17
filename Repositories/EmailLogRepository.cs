using Retail_backend.Models;
using Retail_backend.Repositories.Interfaces;

namespace Retail_backend.Repositories
{
    public class EmailLogRepository : IEmailLogRepository
    {
        public Task<EmailLog> CreateAsync(EmailLog log)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmailLog>> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
