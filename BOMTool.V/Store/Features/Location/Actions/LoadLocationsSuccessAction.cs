using BOMTool.M;
using System.Collections.Generic;

namespace BOMTool.V.Store.Features.Locations.Actions
{
    public class LoadLocationsSuccessAction
    {
        public LoadLocationsSuccessAction(IEnumerable<Location> locations) =>
            Locations = locations;

        public IEnumerable<Location> Locations { get; }
    }
}
