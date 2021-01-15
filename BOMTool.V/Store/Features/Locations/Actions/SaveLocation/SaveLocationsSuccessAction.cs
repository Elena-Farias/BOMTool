using BOMTool.M;
using System.Collections.Generic;

namespace BOMTool.V.Store.Features.Locations.Actions.SaveLocation
{
    public class SaveLocationsSuccessAction
    {
        public SaveLocationsSuccessAction(IEnumerable<Location> locations) =>
            Locations = locations;

        public IEnumerable<Location> Locations { get; }
    }
}
