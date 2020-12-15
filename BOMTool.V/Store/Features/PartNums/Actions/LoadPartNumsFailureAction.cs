using BOMTool.V.Store.Features.Shared;

namespace BOMTool.V.Store.Features.PartNums.Actions
{
    public class LoadPartNumsFailureAction : FailureAction
    {
        public LoadPartNumsFailureAction(string errorMessage)
          : base(errorMessage)
        {
        }
    }
}
