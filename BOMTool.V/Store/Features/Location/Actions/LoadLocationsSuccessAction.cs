using BOMTool.M;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOMTool.V.Store.Features.Locations.Actions
{
    public class LoadLocationsSuccessAction
    {
        public LoadLocationsSuccessAction(IEnumerable<Location> locations) =>
            Locations = locations;

        public IEnumerable<Location> Locations { get; }
    }
}
