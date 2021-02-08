using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BOMTool.C.Data;
using BOMTool.C.Services;
using System;
using BOMTool.M.DTOs;
using System.Collections.Generic;
using ClosedXML.Excel;
using Newtonsoft.Json;
using System.IO;

namespace BOMTool.C.Controller
{
    [Route("v1/[controller]")]
    [ApiController]
    public class PartNumController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IOracleServices _oracle;
       // PartNumbDto ListPartNumbs; 
        private class partNumlist
        {
        }

        public PartNumController(ApplicationDbContext context, IOracleServices oracle)
        {
            _context = context;
            _oracle = oracle; 
        }


        [HttpGet]
        public async Task<ActionResult<List<PartNumbDto>>> GetFromOracle(string PNDto)
        {
            try
            {
                PartNumbDto data = JsonConvert.DeserializeObject<PartNumbDto>(PNDto);
                var partnum = data.PartNum;
                var orgcode = data.Location;
                var partNumbers = await _oracle.GetPartNumber(orgcode, partnum);  
                
                return partNumbers;           
             }

            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpGet("Export")]
        public async Task<ActionResult> GetFromOracleToExport(string PNDto)
        {
            try
            {
                PartNumbDto data = JsonConvert.DeserializeObject<PartNumbDto>(PNDto);
                var partnum = data.PartNum;
                var orgcode = data.Location;
                var partNumberstoexport = await _oracle.GetPartNumber(orgcode, partnum);               

                XLWorkbook workbook = new XLWorkbook();
                IXLWorksheet worksheet = workbook.Worksheets.Add("BOMTool");
                                
                worksheet.Cell(1, 1).Value = "Model";               
                worksheet.Cell(1, 2).Value = "ParNum";
                worksheet.Cell(1, 3).Value = "ItemDescription";
                worksheet.Cell(1, 4).Value = "UOM";
                worksheet.Cell(1, 5).Value = "QTY";
                worksheet.Cell(1, 6).Value = "ItemType";

                 var x = 2;
                 foreach (var partn in partNumberstoexport)
                 {
                     worksheet.Cell(x, 1).Value = string.Concat("'",partn.Model);
                     worksheet.Cell(x, 2).Value = string.Concat("'",partn.PartNum);
                     worksheet.Cell(x, 3).Value = partn.ItemDescription;
                     worksheet.Cell(x, 4).Value = partn.UOM;
                     worksheet.Cell(x, 5).Value = partn.QTY;
                     worksheet.Cell(x, 6).Value = partn.ItemType;
                     x++; 
                 }


                 var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";           
                 var fileName = $"BOMTool-{DateTime.Now.ToString()}.xlsx";

                   using (var stream = new MemoryStream())
                  {
                      workbook.SaveAs(stream);
                      var content = stream.ToArray();

                      return File(content, contentType, fileName); 
                   }

             }

            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

    }

}
