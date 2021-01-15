using BOMTool.M.DTOs;
using System.Collections.Generic;

namespace BOMTool.V.Store.Features.PartNums.Actions
{
    public class LoadPartNumsSuccessAction
    {
        public LoadPartNumsSuccessAction(List<PartNumbDto> partNum) =>
            PartNums = partNum;

        public List<PartNumbDto> PartNums { get; }
    }
}
