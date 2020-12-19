using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorise;
using BOMTool.M;
using Microsoft.AspNetCore.Components;
using BOMTool.M.DTOs;
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


       public async Task SeachPartNum(string locatioName, string partnumber)
        {
            if (partnum != "")
            {
                isLoading = true;
                stateServices.LoadPartNums(locatioName, partnumber); 
            }
        }
    }
}
