using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace SDKWebPortalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public TokenController(IConfiguration configuration)
        {
            this._configuration = configuration;

        }
        [HttpGet]
        public IActionResult Get()
        {

            var token = new JwtSecurityToken
                (
                issuer: _configuration["Issuer"],
                audience: _configuration["Audience"],
                expires: DateTime.UtcNow.AddDays(30),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SigningKey"])), SecurityAlgorithms.HmacSha256)
                );

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });

        }
    }
}