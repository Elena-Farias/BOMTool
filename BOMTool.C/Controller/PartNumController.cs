using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BOMTool.C.Data;
using BOMTool.C.Services;
using System;
using Microsoft.EntityFrameworkCore;
using BOMTool.M.DTOs;
using System.Collections.Generic;

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

        
        [HttpGet("/{OrgCode}/{PartNum}")]
        public async Task<ActionResult<List<PartNumbDto>>> GetFromOracle(string orgcode, string partnumb)
        {
            try
            {
                var partNumbers = await _oracle.GetPartNumber(orgcode, partnumb);
                
                return partNumbers;           
             }

            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

       }
       
    }

}
