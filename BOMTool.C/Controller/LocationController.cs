using BOMTool.C.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BOMTool.C.Controller
{
    [Route("v1/[controller]")]
    [ApiController]

    //[Authorize]
    public class LocationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LocationController(ApplicationDbContext context)
        {
            _context = context;           
        }

        [HttpGet]
        public async Task<IActionResult> GetLocation()
        { 
           try
            {
                //var location = await _context.Location.Where(x => x.Active == true).ToListAsync();
               var location = await _context.Location.ToListAsync();
                return Ok(location);
            }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

    }
}
