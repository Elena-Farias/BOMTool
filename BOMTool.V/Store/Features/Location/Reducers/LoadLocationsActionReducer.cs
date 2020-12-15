using BOMTool.V.Store.Features.Locations.Actions;
using BOMTool.V.Store.State;
using Fluxor;

namespace BOMTool.V.Store.Features.Locations.Reducers
{
    public class LoadLocationsActionReducer
    {
        [ReducerMethod]
        public static LocationState ReduceLoadLocationAction(LocationState state, LoadLocationsAction _)
            => new LocationState(true, null, null, state.Current);

        [ReducerMethod]
        public static LocationState ReduceLoadLocationSuccessAction(LocationState state, LoadLocationsSuccessAction action)
            => new LocationState(false, null, action.Locations, state.Current);

        [ReducerMethod]
        public static LocationState ReduceLoadLocationFailureAction(LocationState state, LoadLocationsFailureAction action)
            => new LocationState(false, action.ErrorMessage, null, state.Current);
    }
}
