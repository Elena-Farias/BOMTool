using BOMTool.M;

namespace BOMTool.V.Store.Features.Locations.Actions.SaveLocation
{
    public class SaveLocationAction
    {
        public SaveLocationAction(Location location, bool isnew)
        {
            Location = location;
            IsNew = isnew;            
        }

        public Location Location { get; }
        public bool IsNew { get; }
    }
}
