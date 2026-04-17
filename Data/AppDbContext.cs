using Microsoft.EntityFrameworkCore;
using Retail_backend.Models;

namespace Retail_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Inventory> Inventories => Set<Inventory>();
        public DbSet<Cart> Carts => Set<Cart>();
        public DbSet<CartItem> CartItems => Set<CartItem>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        public DbSet<Coupon> Coupons => Set<Coupon>();
        public DbSet<LoyaltyAccount> LoyaltyAccounts => Set<LoyaltyAccount>();
        public DbSet<EmailLog> EmailLogs => Set<EmailLog>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>()
                .Property(u => u.Role).HasConversion<string>();

            // Product
            modelBuilder.Entity<Product>()
                .Property(p => p.Price).HasColumnType("decimal(18,2)");

            // Order
            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Order>()
                .Property(o => o.Status).HasConversion<string>();

            // OrderItem
            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.UnitPrice).HasColumnType("decimal(18,2)");

            // Coupon
            modelBuilder.Entity<Coupon>()
                .HasIndex(c => c.Code).IsUnique();
            modelBuilder.Entity<Coupon>()
                .Property(c => c.DiscountPercent).HasColumnType("decimal(5,2)");

            // One-to-one: User <-> Cart
            modelBuilder.Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.UserId);

            // One-to-one: User <-> LoyaltyAccount
            modelBuilder.Entity<User>()
                .HasOne(u => u.LoyaltyAccount)
                .WithOne(la => la.User)
                .HasForeignKey<LoyaltyAccount>(la => la.UserId);
            modelBuilder.Entity<LoyaltyAccount>()
    .HasKey(la => la.LoyaltyId);

            // One-to-one: Product <-> Inventory
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Inventory)
                .WithOne(i => i.Product)
                .HasForeignKey<Inventory>(i => i.ProductId);
        }
    }
}
