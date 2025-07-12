using AutoMapper;
using Micro.Services.couponAPI.Models;
using Micro.Services.couponAPI.Models.Dto;

namespace Micro.Services.couponAPI.Mappings
{
    public class MappingConfig : Profile
    {
       MappingConfig()
        {
            CreateMap<CouponDto, Coupon>();
            CreateMap<Coupon, CouponDto>();
        }
    }
}
