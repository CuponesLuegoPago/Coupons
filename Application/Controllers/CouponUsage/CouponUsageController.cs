using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coupons.Application.Interfaces;
using Coupons.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coupons.Application.Controllers.CouponUsage
{
    [ApiController]
    [Route("api/[controller]")]
    public class CouponUsageController : ControllerBase
    {
        private readonly ICouponUsage _repository;

        public CouponUsageController(ICouponUsage repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll(){
            return Ok( _repository.GetAllCoupons());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id){
            return Ok( _repository.GetById(id));
        }
    }
}