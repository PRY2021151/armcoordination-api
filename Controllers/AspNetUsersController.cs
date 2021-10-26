using armcoordination_api.Data;
using armcoordination_api.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace armcoordination_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AspNetUsersController : ControllerBase
    {
        private readonly armcoordinationContext context;
        public AspNetUsersController(armcoordinationContext _context)
        {
            context = _context;
        }

        [HttpGet("login")]
        public ActionResult Login([FromBody] UserLogin userLogin)
        {
            
            var result = context.AspNetUsers.FirstOrDefault(x => x.Email == userLogin.email && x.PasswordText == userLogin.password);
            if (result != null)
            {
                return Ok();
            }

            return BadRequest();
        }

    }
}
