using Coupons.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Coupons.Models;

namespace Coupons.Controllers.MarketingUsers
{
    public class MarketingUsersController : ControllerBase
    {
        private readonly IMarketingUser _markingUsersgRepository;

        public MarketingUsersController(IMarketingUser marketinUsersgRepository)
        {
            _markingUsersgRepository = marketinUsersgRepository;
        }
        // Obtener todos los usuarios de marketing 
        [HttpGet]
        [Route("api/MarketingUsers")]
        public IActionResult GetAllMarketingUsers()
        {
            try
            {
                return Ok(_markingUsersgRepository.GetMarketingUsers());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        // Obtener los usuarios de marketing por id 
        [HttpGet]
        [Route("api/MarketingUsers/{id}")]
        public IActionResult GetMarketingUserById(int id)
        {
            try
            {
                return Ok(_markingUsersgRepository.GetMarketingUser(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}