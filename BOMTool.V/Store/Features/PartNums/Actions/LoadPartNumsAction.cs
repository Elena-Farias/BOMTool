using BOMTool.M.DTOs;

namespace BOMTool.V.Store.Features.PartNums.Actions
{
    public class LoadPartNumsAction
    {
        public LoadPartNumsAction(PartNumbDto partnumbs, bool export)
        {
            PartNumbs = partnumbs;
            Export = export; 
        }

        public PartNumbDto PartNumbs { get; }
        public bool Export { get; }
    }
}
