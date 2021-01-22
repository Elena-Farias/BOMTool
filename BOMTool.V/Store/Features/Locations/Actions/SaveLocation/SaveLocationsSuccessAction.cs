using BOMTool.M;

namespace BOMTool.V.Store.Features.Locations.Actions.SaveLocation
{
    public class SaveLocationsSuccessAction
    {
        public SaveLocationsSuccessAction(Location location) =>
            Location = location;

        public Location Location { get; }
    }
}
