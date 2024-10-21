using AppCLP.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppCLP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {

        [HttpGet(Name = "GetUsers")]
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            return users;
        }
    }
}
