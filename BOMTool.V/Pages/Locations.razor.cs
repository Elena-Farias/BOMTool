using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorise;
using BOMTool.M;
using BOMTool.V.Services;
using BOMTool.V.Store.State;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace BOMTool.V.Pages
{
    public partial class Locations
    {
        [Inject]
        IState<LocationsState> LocationsState { get; set; }

        [Inject]
        StateServices stateServices { get; set;  }

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync(); 
            if (LocationsState.Value.Currents is null)
            {
                stateServices.LoadLocations();
             }
        }

        private Modal modalRef;
        private bool IsNew;
        private Location selected = new Location();

        private void ShowModal(Location location, bool isNew)
        {
            IsNew = isNew;
            selected = location;
            modalRef.Show();
        }

        private void HideModal()
        {
            modalRef.Hide();
        }

    }
}
