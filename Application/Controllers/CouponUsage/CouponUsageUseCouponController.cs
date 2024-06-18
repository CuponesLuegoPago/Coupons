using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.CouponUsage
{
    [ApiController]
    [Route("api/[controller]")]
    public class CouponUsageUseCouponController : ControllerBase
    {
        private readonly ICouponUsage _repository;

        public CouponUsageUseCouponController(ICouponUsage repository)
        {
            _repository = repository;
        }
        [HttpPost]
        [Route("{id}")]
        public IActionResult UseCoupon([FromBody] CouponUsageDto couponUsageDto, int id)
        {
            try
            {
                // Resta 1 del UsageLimit del cupón y crea un nuevo CouponUsage
                var couponUsage = _repository.Create(id, couponUsageDto);

                // Si todo sale bien, devuelve el CouponUsage creado
                return Ok(couponUsage);
            }
            catch (Exception ex)
            {
                // Si hay un error, devuelve un mensaje con el error
                return BadRequest(ex.Message);
            }
        }

    }
}