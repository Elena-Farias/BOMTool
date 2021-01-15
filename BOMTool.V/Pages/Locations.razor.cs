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

        public void ShowModal(Location location, bool isNew)
        {
            IsNew = isNew;
            selected = location;
            modalRef.Show();

        }

        public async Task AddLocation()
        {
            modalRef.Hide();
            stateServices.SaveLocation(selected, IsNew); 

        }


    }
}
