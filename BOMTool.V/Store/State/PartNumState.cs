using System.Collections.Generic;
using BOMTool.M;

namespace BOMTool.V.Store.State
{
    public class PartNumState  : RootState
    {
        public PartNumState(bool isLoading, string currentErrorMessage, IEnumerable<PartNumbDto> currentPartNums, PartNumbDto currentPartNum)
            : base (isLoading, currentErrorMessage)
        {
            Currents = currentPartNums;
            Current = currentPartNum;
        }

        public IEnumerable<PartNumbDto> Currents { get; }
        public PartNumbDto Current { get; }
    }
}
