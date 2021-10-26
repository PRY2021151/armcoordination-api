using armcoordination_api.Data;
using armcoordination_api.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace armcoordination_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly armcoordinationContext context;
        public SessionController(armcoordinationContext _context)
        {
            context = _context;
        }

        [HttpPost("session")]
        public ActionResult Post([FromBody] session session)
        {
            try
            {
                session.date = DateTime.Now;
                context.session.Add(session);
                context.SaveChanges();
                return Ok();
            } 
            catch
            {
                return BadRequest();
            }
        }
    }
}
