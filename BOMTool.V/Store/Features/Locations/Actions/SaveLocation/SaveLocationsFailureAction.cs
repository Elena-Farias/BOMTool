using BOMTool.V.Store.Features.Shared;

namespace BOMTool.V.Store.Features.Locations.Actions.SaveLocation
{
    public class SaveLocationsFailureAction : FailureAction
    {
        public SaveLocationsFailureAction(string errorMessage)
           : base(errorMessage)
        {
        }
    }
}
