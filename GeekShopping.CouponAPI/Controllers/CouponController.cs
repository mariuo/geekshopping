﻿#nullable disable

using GeekShopping.CouponAPI.Data.ValueObjects;
using GeekShopping.CouponAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.CouponAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CouponController : ControllerBase
    {
        private ICouponRepository _repository;

        public CouponController(ICouponRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }

        [HttpGet("{couponCode}")]
        [Authorize]
        public async Task<ActionResult<CouponVO>> GetCouponByCouponCode(string couponCode)
        {
            var Coupon = await _repository.GetCouponByCouponCode(couponCode);
            if (Coupon == null) return NotFound();
            return Ok(Coupon);
        }
    }
}
