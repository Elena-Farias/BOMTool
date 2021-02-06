using BOMTool.M.DTOs;

namespace BOMTool.V.Store.Features.PartNums.Actions
{
    public class LoadPartNumsAction
    {
        public LoadPartNumsAction(PartNumbDto partnumbs)
        {
            PartNumbs = partnumbs;
        }

        public PartNumbDto PartNumbs { get; }
    }
}
