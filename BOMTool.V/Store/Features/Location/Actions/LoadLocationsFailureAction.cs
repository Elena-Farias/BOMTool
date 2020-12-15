using BOMTool.V.Store.Features.Shared;

namespace BOMTool.V.Store.Features.Locations.Actions
{
    public class LoadLocationsFailureAction : FailureAction
    {
        public LoadLocationsFailureAction(string errorMessage)
            : base(errorMessage)
        { 
        }
    }
}
