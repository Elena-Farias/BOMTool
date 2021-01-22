using BOMTool.V.Store.Features.Locations.Actions.LoadLocations;
using BOMTool.V.Store.Features.Locations.Actions.SaveLocation;
using BOMTool.V.Store.State;
using Fluxor;

namespace BOMTool.V.Store.Features.Locations.Reducers
{
    public class SaveLocationsActionReducer
    {
        [ReducerMethod]
        public static LocationsState ReduceSaveLocationAction(LocationsState state, SaveLocationAction _)
          => new LocationsState(true, null, null, state.Current);

        [ReducerMethod] 
        public static LocationsState ReduceLoadLocationSuccessAction(LocationsState state, LoadLocationsSuccessAction action)
          => new LocationsState(false, null, action.Locations, state.Current);

        [ReducerMethod]
        public static LocationsState ReduceLoadLocationFailureAction(LocationsState state, LoadLocationsFailureAction action)
            => new LocationsState(false, action.ErrorMessage, null, state.Current);
    }
}
