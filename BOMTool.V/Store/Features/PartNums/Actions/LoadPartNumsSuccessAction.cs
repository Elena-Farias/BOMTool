using BOMTool.M;
using System.Collections.Generic;

namespace BOMTool.V.Store.Features.PartNums.Actions
{
    public class LoadPartNumsSuccessAction
    {
        public LoadPartNumsSuccessAction(IEnumerable<PartNumbDto> partNum) =>
            PartNums = partNum;

        public IEnumerable<PartNumbDto> PartNums { get; }
    }
}
