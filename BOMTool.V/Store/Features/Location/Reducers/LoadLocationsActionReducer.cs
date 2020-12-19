using BOMTool.V.Store.Features.Locations.Actions;
using BOMTool.V.Store.State;
using Fluxor;

namespace BOMTool.V.Store.Features.Locations.Reducers
{
    public class LoadLocationsActionReducer
    {
        [ReducerMethod]
        public static LocationsState ReduceLoadLocationAction(LocationsState state, LoadLocationsAction _)
            => new LocationsState(true, null, null, state.Current);

        [ReducerMethod]
        public static LocationsState ReduceLoadLocationSuccessAction(LocationsState state, LoadLocationsSuccessAction action)
            => new LocationsState(false, null, action.Locations, state.Current);

        [ReducerMethod]
        public static LocationsState ReduceLoadLocationFailureAction(LocationsState state, LoadLocationsFailureAction action)
            => new LocationsState(false, action.ErrorMessage, null, state.Current);
    }
}
