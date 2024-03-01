using learn.Services.couponApi.Data;
using learn.Services.couponApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace learn.Services.couponApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CouponApiController : ControllerBase
	{
		private readonly AppDbContext _db;

		public CouponApiController(AppDbContext db)
		{
			_db = db;
		}
		[HttpGet]
		public object Get() {
			try
			{
				IEnumerable<Coupon> objList = _db.Coupons.ToList();
				return objList;

			}
			catch (Exception ex) {
			
			}
			return null;
			
			}

		[HttpGet]
		[Route("{id:int}")]
		public object Get(int id)
		{
			try
			{
				Coupon objList = _db.Coupons.First(u=> u.CouponId==id);
				return objList;

			}
			catch (Exception ex)
			{

			}
			return null;

		}
	}
}
