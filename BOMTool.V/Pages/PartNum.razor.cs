using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BOMTool.V.Services;
using BOMTool.V.Store.State;
using Fluxor;
using BOMTool.M.DTOs;
using Microsoft.JSInterop;
using System;

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

        [Inject]
        private IJSRuntime JSRuntime { get; set; }
                
        [Inject]
        private BOMToolClient bomtoolclient { get; set;  }

        private PartNumbDto selectedPartNum = new PartNumbDto(); 
        private bool isLoading = false;
        private bool ItemFlats; 


        public async Task SeachPartNum(PartNumbDto partnumbers)
        {
            if (selectedPartNum.PartNum != "")
            {
                isLoading = true;
                stateServices.LoadPartNums(partnumbers, ItemFlats); 
            }                       
        }

        protected async Task DownloadFile(PartNumbDto partnumbers)
        {
           var fileBytes = await bomtoolclient.GetProgressFileByDTo(partnumbers, ItemFlats); 
           var fileName = $"BOMTool_{DateTime.Now.ToString()}.xlsx";

            await JSRuntime.InvokeAsync<object>("saveAsFile", fileName, Convert.ToBase64String(fileBytes));
           
        }

        public void clearfields()
        {
            selectedPartNum.PartNum = null;          
        }

     }
}
