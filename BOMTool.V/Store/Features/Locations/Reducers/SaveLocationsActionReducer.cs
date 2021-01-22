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
        public static LocationsState ReduceSaveLocationSuccessAction(LocationsState state, SaveLocationsSuccessAction action)
            => new LocationsState(true, null, state.Currents, action.Location);
                
        [ReducerMethod]
        public static LocationsState ReduceSaveLocationFailureAction(LocationsState state, SaveLocationsFailureAction action)
            => new LocationsState(false, action.ErrorMessage, null, state.Current);
    }
}
