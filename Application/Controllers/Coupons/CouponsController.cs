using Coupons.Application.Interfaces;
using Coupons.Dtos;
using Coupons.Models;

using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.Coupons
{
    public class CouponsController : ControllerBase
    {
        private readonly ICoupons _repository;

        public CouponsController(ICoupons repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("api/Coupons")]
        public IActionResult GetAllCoupons()
        {
            return Ok(_repository.GetAllCoupons());
        }

        [HttpGet]
        [Route("api/Coupons/{id}")]
        public IActionResult GetCouponById(int id)
        {
            return Ok(_repository.GetById(id));
        }
    }
}