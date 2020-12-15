using BOMTool.V.Store.State;
using Fluxor;

namespace BOMTool.V.Store.Features.PartNums
{
    public class PartNumFeature : Feature<PartNumState>
    {
        public override string GetName() => "PartNumState";

        protected override PartNumState GetInitialState() =>
            new PartNumState(false, null, null, null);
     }
}
