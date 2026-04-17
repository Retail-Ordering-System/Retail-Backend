using Retail_backend.Models;

namespace Retail_backend.Helpers
{
    public static class EmailTemplateHelper
    {
        public static string OrderConfirmation(Order order, User user)
        {
            var itemRows = string.Join("", order.OrderItems.Select(i =>
                $"<tr><td>{i.Product?.Name}</td><td>{i.Quantity}</td><td>₹{i.UnitPrice:F2}</td></tr>"));

            return $"""
        <html>
        <body style="font-family: Arial, sans-serif; color: #333;">
          <h2>Order Confirmed! 🎉</h2>
          <p>Hi {user.FullName}, your order <strong>#{order.OrderId}</strong> has been placed.</p>
          <table border="1" cellpadding="8" cellspacing="0" style="border-collapse: collapse;">
            <thead>
              <tr style="background:#f0f0f0;">
                <th>Product</th><th>Qty</th><th>Price</th>
              </tr>
            </thead>
            <tbody>{itemRows}</tbody>
          </table>
          <p><strong>Total: ₹{order.TotalAmount:F2}</strong></p>
          <p>Shipping to: {order.ShippingAddress}</p>
          <p>Thank you for shopping with us!</p>
        </body>
        </html>
        """;
        }
    }
}
