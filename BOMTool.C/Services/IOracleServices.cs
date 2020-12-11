using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOMTool.C.Services
{
   interface IOracleServices
    {
        String GetPartNumber(int Code);
    }
}
