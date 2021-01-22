using BOMTool.C.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BOMTool.M;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace BOMTool.C.Controller
{
    [Route("v1/[controller]")]
    [ApiController]

    //[Authorize]
    public class LocationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private string userSSO;

        public LocationController(ApplicationDbContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            userSSO = contextAccessor.HttpContext.User.Claims.Where(x => x.Type == "preferred_username").FirstOrDefault().Value;
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

        [HttpPost]
        public async Task<IActionResult> CreateLocation(Location location)
       {
            try
            {
               
                if (!_context.Location.Any(x => x.Name == location.Name))
                {
                    location.CreatedAt = DateTime.Now;
                    //location.CreatedBy = userSSO;
                   
                    _context.Location.Add(location);
                    var result = await _context.SaveChangesAsync();
                   return CreatedAtAction("GetLocation", new { location.Id }, location);
                   
                }
                else
                {
                    return BadRequest("Location name is already taken");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = ex.Message
                });
            }
        }

        [HttpPut]
        public ActionResult UpdatePlant(Location location)
        {
            try
            {
                location.UpdatedAt = DateTime.Now;

                _context.Location.Update(location);
                _context.SaveChanges();

                return NoContent();
                //return RedirectToAction("GetLocation"); 
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

    }
}
