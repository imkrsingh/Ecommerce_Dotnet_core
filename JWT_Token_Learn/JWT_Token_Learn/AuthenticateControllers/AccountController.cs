using JWT_Token_Learn.Data;
using JWT_Token_Learn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JWT_Token_Learn.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDb context;

        public AccountController(ApplicationDb context) 
        
        {
            this.context= context;
        }  
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUp user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.employees.Add(user);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
