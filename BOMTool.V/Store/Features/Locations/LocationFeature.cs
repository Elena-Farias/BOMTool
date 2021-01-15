using BOMTool.V.Store.State;
using Fluxor;

namespace BOMTool.V.Store.Features.Locations
{
    public class LocationFeature : Feature<LocationsState>
    {
        public override string GetName() => "LocationState";

        protected override LocationsState GetInitialState() =>
            new LocationsState(false, null, null, null);
    }
}
