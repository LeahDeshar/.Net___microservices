using learn.Services.couponApi.Data;
using learn.Services.couponApi.Models;
using learn.Services.couponApi.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace learn.Services.couponApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CouponApiController : ControllerBase
	{
		private readonly AppDbContext _db;
		private ResponseDto _response;

		public CouponApiController(AppDbContext db)
		{
			_db = db;
			_response = new ResponseDto();
		}
		[HttpGet]
		public ResponseDto Get() {
			try
			{
				IEnumerable<Coupon> objList = _db.Coupons.ToList();
				_response.Result =  objList;

			}
			catch (Exception ex) {
			_response.IsSuccess = false;
			_response.Message = ex.Message;
			
			}
			return _response;

		}

		[HttpGet]
		[Route("{id:int}")]
		public ResponseDto Get(int id)
		{
			try
			{
				Coupon obj = _db.Coupons.First(u=> u.CouponId==id);
				CouponDto couponDto = new CouponDto()
				{
					CouponId = obj.CouponId,
					CouponCode = obj.CouponCode,
					DiscountAmount = obj.DiscountAmount,
					MinAmount = obj.MinAmount,
				};
				_response.Result = couponDto;

			}
			catch (Exception ex)
			{
				_response.IsSuccess = false;
				_response.Message = ex.Message;
			}
			return _response;

		}
	}
}
