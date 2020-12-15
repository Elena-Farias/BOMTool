using Fluxor;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BOMTool.V.Store.State;
using BOMTool.V.Services;

namespace BOMTool.V.Pages
{
    public partial class Index
    {
        [Inject]
        IState<LocationState> LocationsState { get; set; }

        [Inject]
        StateServices stateServices { get; set;  }

        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            
            if (LocationsState.Value.Current is null)
            {
                stateServices.LoadLocations();
            }

        }
    }
}
