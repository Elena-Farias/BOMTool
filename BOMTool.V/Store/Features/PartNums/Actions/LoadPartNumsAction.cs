using BOMTool.V.Pages;

namespace BOMTool.V.Store.Features.PartNums.Actions
{
    public class LoadPartNumsAction
    {
        public LoadPartNumsAction(string locationcode, string partnum)
        {
            LocationCode = locationcode;
            PartNum = partnum;             
        }

        public string LocationCode { get; }
        public string PartNum { get; }
    }
}
