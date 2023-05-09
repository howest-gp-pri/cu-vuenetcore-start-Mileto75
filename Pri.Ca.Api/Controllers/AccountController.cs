using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Pri.Ca.Api.DTOs.Account;
using Pri.Ca.Core.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Pri.Ca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(AccountLoginRequestDto accountLoginRequestDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }
            //check credentials
            var user = await _userManager.FindByNameAsync(accountLoginRequestDto.Username);
            if(!await _userManager.CheckPasswordAsync(user,accountLoginRequestDto.Password))
            {
                return BadRequest("Wrong credentials");
            }
            //generate token
            //set parameters
            var audience = _configuration.GetValue<string>("JWTConfiguration:Audience");
            var issuer = _configuration.GetValue<string>("JWTConfiguration:Issuer");
            var expires = _configuration.GetValue<int>("JWTConfiguration:Expires");
            var secret = _configuration.GetValue<string>("JWTConfiguration:Secret");
            //claims
            var claims = await _userManager.GetClaimsAsync(user);
            //signinKey
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var signinCredentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            //generate byte token
            var token = new JwtSecurityToken(
                issuer: issuer,
                audience:audience,
                claims:claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddDays(expires),
                signingCredentials: signinCredentials
                );
            //serialize token
            var serializedToken = new JwtSecurityTokenHandler()
                .WriteToken(token);
            return Ok(serializedToken);
        }
        [HttpPost("Register")]
        public IActionResult Register(AccountRegisterRequestDto accountRegisterRequestDto)
        {
            return Ok();
        }
    }
}
