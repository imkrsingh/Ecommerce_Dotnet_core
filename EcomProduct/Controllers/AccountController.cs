//using EcomProduct.Entities;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.IdentityModel.Tokens;
//using Microsoft.AspNetCore.Authorization;

//namespace EcomProduct.Controllers
//{

//    [ApiController]
//    public class AccountController : ControllerBase
//    {
//        private readonly UserManager<ApplicationUser> _userManager;
//        private readonly SignInManager<ApplicationUser> _signInManager;
//        private readonly IConfiguration _configuration;

//        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
//        {
//            _userManager = userManager;
//            _signInManager = signInManager;
//            _configuration = configuration;
//        }


//        [Route("api/[controller]/create")]
//        [HttpPost]
//        public async Task<IActionResult> Register([FromBody] RegisterModel request)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            var user = new ApplicationUser
//            {
//                UserName = request.Email,
//                Email = request.Email,
//                FirstName = request.FirstName,
//                LastName = request.LastName,
//                DateOfBirth = request.DateOfBirth,
//                Address = request.Address,
//                Gender = request.Gender
//            };

//            var result = await _userManager.CreateAsync(user, request.Password);
//            if (result.Succeeded)
//            {
//                return Ok();
//            }

//            foreach (var error in result.Errors)
//            {
//                ModelState.AddModelError("", error.Description);
//            }
//            return BadRequest(ModelState);
//        }


//        [Route("api/[controller]/login")]
//        [HttpPost]
//        public async Task<IActionResult> Login([FromBody] LoginModel model)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: true);
//            if (result.Succeeded)
//            {
//                var user = await _userManager.FindByEmailAsync(model.Email);
//                var token = GenerateJwtToken(user);
//                return Ok(new { Token = token });
//            }

//            return Unauthorized();
//        }

//        private string GenerateJwtToken(ApplicationUser user)
//        {
//            var claims = new[]
//            {
//                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
//                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
//                new Claim(JwtRegisteredClaimNames.Email, user.Email),
//                new Claim("FirstName", user.FirstName),
//                new Claim("LastName", user.LastName),
//                new Claim("DateOfBirth", user.DateOfBirth.ToString("yyyy-MM-dd")),
//                new Claim("Address", user.Address),
//                new Claim("Gender", user.Gender)
//            };

//            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
//            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

//            var token = new JwtSecurityToken(
//                _configuration["Jwt:Issuer"],
//                _configuration["Jwt:Audience"],
//                claims,
//                expires: DateTime.Now.AddMinutes(2),
//                signingCredentials: creds);

//            return new JwtSecurityTokenHandler().WriteToken(token);
//        }
//    }
//}



using EcomProduct.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace EcomProduct.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Register([FromBody] RegisterModel request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser
            {
                UserName = request.Email,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                DateOfBirth = request.DateOfBirth,
                Address = request.Address,
                Gender = request.Gender
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return Ok();
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return BadRequest(ModelState);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: true);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                var token = GenerateJwtToken(user);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }

        private string GenerateJwtToken(ApplicationUser user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim("FirstName", user.FirstName),
                new Claim("LastName", user.LastName),
                new Claim("DateOfBirth", user.DateOfBirth.ToString("yyyy-MM-dd")),
                new Claim("Address", user.Address),
                new Claim("Gender", user.Gender)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30), // Increased expiration time for testing
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        [Authorize]
        [HttpGet("me")]
        public IActionResult VerifyToken()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { message = "User not valid." });
            }
            return Ok(new { message = "User is valid.", userId });
        }

    }
}

