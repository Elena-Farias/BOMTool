using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BOMTool.C.Data;
using BOMTool.C.Services;
using System;

namespace BOMTool.C.Controller
{
    [Route("v1/[controller]")]
    [ApiController]
    public class PartNumController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IOracleServices _oracle;

        public PartNumController(ApplicationDbContext context, IOracleServices oracle)
        {
            _context = context;
            _oracle = oracle; 
        }

        
        [HttpGet("{OrgCode}/{PartNum}")]
        public async Task<ActionResult> GetFromOracle(string orgcode, string partnumb)
        {
            try
            {
                _oracle.GetPartNumber(orgcode, partnumb);
                return Ok();           
             }

            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

       }
       
    }

}
