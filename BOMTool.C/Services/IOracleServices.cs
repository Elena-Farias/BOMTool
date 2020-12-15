using System;

namespace BOMTool.C.Services
{
    public interface IOracleServices
    {
        String GetPartNumber(string OrgCode, string partNum);
    }
}
