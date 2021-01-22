using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BOMTool.V.Services;
using BOMTool.V.Store.State;
using Fluxor;
using BOMTool.M.DTOs;

namespace BOMTool.V.Pages
{
    public partial class PartNum
    {
        [Inject]
        IState<PartNumState> PartNumState { get; set; }

        [Inject]
        IState<LocationsState> LocationState { get; set; }

        [Inject]
        StateServices stateServices { get; set; }

        private PartNumbDto selectedPartNum = new PartNumbDto(); 
        private bool isLoading = false;
               
        public async Task SeachPartNum(PartNumbDto partnumbers, bool export)
        {
            if (selectedPartNum.PartNum != "")
            {
                isLoading = true;
                stateServices.LoadPartNums(partnumbers, export); 
            }                       
        }

        public void clearfields()
        {
            selectedPartNum.PartNum = null;          
        }

     }
}
