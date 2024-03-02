using AutoMapper;
using learn.Services.couponApi.Models;
using learn.Services.couponApi.Models.DTO;

namespace learn.Services.couponApi
{
	public class MappingConfig
	{
		public static MapperConfiguration RegisterMaps(){
		   var mappingConfig = new MapperConfiguration(config =>
		   {
			   config.CreateMap<CouponDto, Coupon>();
			   config.CreateMap<Coupon, CouponDto>();

		   });
			return mappingConfig;
		}
	}
}
