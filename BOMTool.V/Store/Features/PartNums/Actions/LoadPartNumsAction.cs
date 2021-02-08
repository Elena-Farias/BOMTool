using BOMTool.M.DTOs;

namespace BOMTool.V.Store.Features.PartNums.Actions
{
    public class LoadPartNumsAction
    {
        public LoadPartNumsAction(PartNumbDto partnumbs, bool Onlyitem)
        {
            PartNumbs = partnumbs;
            OnlyItem = Onlyitem; 
        }

        public PartNumbDto PartNumbs { get; }
        public bool OnlyItem { get; }
    }
}
