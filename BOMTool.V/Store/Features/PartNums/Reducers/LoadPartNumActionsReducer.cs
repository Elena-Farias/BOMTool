using Fluxor;
using BOMTool.V.Store.Features.PartNums.Actions;
using BOMTool.V.Store.State;

namespace BOMTool.V.Store.Features.PartNums.Reducers
{
    public class LoadPartNumActionsReducer
    {
        [ReducerMethod]
        public static PartNumState ReduceLoadPartnumAction(PartNumState state, LoadPartNumsAction _) =>
            new PartNumState(true, null, null, state.Current);

        [ReducerMethod]
        public static PartNumState ReduceLoadPartNumsFailureAction(PartNumState state, LoadPartNumsSuccessAction action) =>
            new PartNumState(false, null, action.PartNums, state.Current);

        [ReducerMethod]
        public static PartNumState ReduceLoadPartNumFailureAction(PartNumState state, LoadPartNumsFailureAction action) =>
            new PartNumState(false, action.ErrorMessage, null, state.Current);
    }
}
