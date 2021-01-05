using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BOMTool.V.Services;
using BOMTool.V.Store.State;
using Fluxor;

namespace BOMTool.V.Pages
{
    public partial class PartNum
    {
        [Inject]
        IState<PartNumState> PartNumState { get; set; }

        [Inject]
        public IState<LocationsState> LocationState { get; set; }

        [Inject]
        StateServices stateServices { get; set; }

        private string selectedLocation;
        private string partnum;
        private bool notFound = true;
        private bool isLoading = false;


       public async Task SeachPartNum(string locatioName, string partnumber, bool export)
        {
            if (partnum != "")
            {
                isLoading = true;
                stateServices.LoadPartNums(locatioName, partnumber, export); 
            }
        }
    }
}
