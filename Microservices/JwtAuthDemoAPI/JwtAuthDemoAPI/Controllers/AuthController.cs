using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthDemoAPI.Models;

namespace JwtAuthDemoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (model.Username == "admin" && model.Password == "admin123")
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, model.Username),
                    new Claim(ClaimTypes.Role, "Admin")
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisIsASecretKeyForJwtToken123456"));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    issuer: "MyAuthServer",
                    audience: "MyApiUsers",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(60),
                    signingCredentials: creds);

                return Ok(new { Token = new JwtSecurityTokenHandler().WriteToken(token) });
            }

            return Unauthorized();
        }
    }
}
