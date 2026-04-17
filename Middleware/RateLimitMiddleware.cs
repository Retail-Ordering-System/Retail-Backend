using System.Collections.Concurrent;

namespace Retail_backend.Middleware
{
    public class RateLimitMiddleware
    {
        private readonly RequestDelegate _next;
        private static readonly ConcurrentDictionary<string, (int Count, DateTime WindowStart)>
            _requestCounts = new();

        private const int MaxRequests = 100;
        private static readonly TimeSpan WindowDuration = TimeSpan.FromMinutes(1);

        public RateLimitMiddleware(RequestDelegate next) => _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            var ip = context.Connection.RemoteIpAddress?.ToString() ?? "unknown";
            var now = DateTime.UtcNow;

            var entry = _requestCounts.AddOrUpdate(ip,
                _ => (1, now),
                (_, old) =>
                {
                    if (now - old.WindowStart > WindowDuration)
                        return (1, now);
                    return (old.Count + 1, old.WindowStart);
                });

            if (entry.Count > MaxRequests)
            {
                context.Response.StatusCode = 429;
                await context.Response.WriteAsync("Too many requests. Please slow down.");
                return;
            }

            await _next(context);
        }
    }
}
