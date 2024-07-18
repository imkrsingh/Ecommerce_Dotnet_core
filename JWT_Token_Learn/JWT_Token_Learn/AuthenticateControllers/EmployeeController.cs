using JWT_Token_Learn.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Token_Learn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public string GetData()
        {
            return "Authenticated with jwt";
        }

        [HttpGet]
        [Route("Details")]

        public string Details()
        {
            return "Authenticated with JWT";
        }

        [Authorize]
        [HttpPost]
        public string AddUser(Users user)
        {
            return "User added with username" + user.Username;
        }
    }
}
