using BOMTool.M.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BOMTool.C.Services
{
    public interface IOracleServices
    {
        //Task<List<PartNumbDto>> GetPartNumber(string OrgCode, PartNumbDto partNumbDtos);
        Task<List<PartNumbDto>> GetPartNumber(string OrgCode, string partNumb);
    }

}
