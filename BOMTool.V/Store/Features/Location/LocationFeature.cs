using BOMTool.V.Store.State;
using Fluxor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOMTool.V.Store.Features.Locations
{
    public class LocationFeature : Feature<LocationState>
    {
        public override string GetName() => "All Locations";

        protected override LocationState GetInitialState() =>
            new LocationState(false, null, null, null);
    }
}
