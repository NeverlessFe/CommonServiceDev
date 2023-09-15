using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CommonServiceCore.Interfaces;
using CommonServiceCore.Models;
using Newtonsoft.Json.Linq;
using CommonServiceCore.Services;


namespace CommonServiceCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenValidationController : ControllerBase
    {
        public readonly ITokenValidationService _TokenValidationService;

        public TokenValidationController(ITokenValidationService TokenValidationService)
        {
            _TokenValidationService = TokenValidationService;
        }

        [HttpPost]
        [Route("ValidationToken")]
        public async Task<IActionResult> ValidationTokenTest(TokenAttributes value)
        {
            TokenValidationServices obj = new TokenValidationServices();
            try
            {
                return Ok(await TokenValidationServices.get);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("ValidationToken")]
        public async Task<IActionResult> ValidationToken(TokenAttributes value)
        {
            try
            {
                return Ok(await _TokenValidationService.GetTokenValidationServices(value));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("GenerateToken")]
        public async Task<IActionResult> GenerateToken(TokenAttributes value)
        {
            try
            {
                return Ok(await _TokenValidationService.GenerateToken(value));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
