using learn.Services.couponApi.Models;
using Microsoft.EntityFrameworkCore;

namespace learn.Services.couponApi.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
			
		}
		public DbSet<Coupon> Coupons {  get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Seed data
			modelBuilder.Entity<Coupon>().HasData(
				new Coupon { CouponId = 1, CouponCode = "CODE1", DiscountAmount = 10.00, MinAmount = 50 });

			modelBuilder.Entity<Coupon>().HasData(new Coupon { CouponId = 2, CouponCode = "CODE2", DiscountAmount = 20.00, MinAmount = 100 });
		}
	}
}
