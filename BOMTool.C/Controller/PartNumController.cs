using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOMTool.C.Data;
using BOMTool.C.Services;
using BOMTool.M;

namespace BOMTool.C.Controller
{
    [Route("v1/[controller]")]
    [ApiController]
    public class PartNumController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IOracleServices _oracle;

    //    public PartNumController(ApplicationDbContext context, IOracleServices oracle)
     //   {
     //      _context = context;
     //      _oracle = oracle;
     //   }
        
        [HttpGet("getfromoracle/{code}")]
        public async Task<ActionResult> GetFromOracle (int code)
        {
            _oracle.GetPartNumber(code);
            return Ok();

       }
    }
}
