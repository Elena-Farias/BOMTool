using BOMTool.V.Pages;

namespace BOMTool.V.Store.Features.PartNums.Actions
{
    public class LoadPartNumsAction
    {
        public LoadPartNumsAction(string locationcode, string partnum, bool export)
        {
            LocationCode = locationcode;
            PartNum = partnum;
            Export = export; 
        }

        public string LocationCode { get; }
        public string PartNum { get; }
        public bool Export { get; }
    }
}
