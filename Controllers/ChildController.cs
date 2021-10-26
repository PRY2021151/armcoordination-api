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
    public class ChildController : ControllerBase
    {

        private readonly armcoordinationContext context;
        public ChildController(armcoordinationContext _context)
        {
            context = _context;
        }

        [HttpGet("child")]
        public IEnumerable<child> Get(ChildList child)
        {
            return context.child.Where(x => x.relationship == child.relationship && x.is_deleted != true).ToList();
        }
    }
}
