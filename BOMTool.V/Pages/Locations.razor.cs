using Fluxor;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using BOMTool.V.Store.State;
using BOMTool.V.Services;

namespace BOMTool.V.Pages
{
    public partial class Locations
    {
        IState<LocationState> LocationState { get; set; }

        [Inject]
        StateServices stateService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            if (LocationState.Value.Currents is null)
            {
                stateService.LoadLocations();
            }

        }

    }
}
