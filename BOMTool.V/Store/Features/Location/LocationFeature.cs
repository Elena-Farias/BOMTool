using BOMTool.V.Store.State;
using Fluxor;

namespace BOMTool.V.Store.Features.Locations
{
    public class LocationFeature : Feature<LocationState>
    {
        public override string GetName() => "LocationState";

        protected override LocationState GetInitialState() =>
            new LocationState(false, null, null, null);
    }
}
