using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CommonServiceCore.Interfaces;
using CommonServiceCore.Models;
using Newtonsoft.Json.Linq;


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
