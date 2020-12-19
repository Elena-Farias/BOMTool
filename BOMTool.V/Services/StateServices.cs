using Fluxor;
using Microsoft.Extensions.Logging;
using BOMTool.V.Store.Features.Locations.Actions;
using BOMTool.V.Store.Features.PartNums.Actions;


namespace BOMTool.V.Services
{
    public class StateServices
    {
        private readonly ILogger<StateServices> _logger;
        private readonly IDispatcher _dispacher;

        public StateServices(ILogger<StateServices> logger, IDispatcher dispactcher) =>
            (_logger, _dispacher) = (logger, dispactcher);

        public void LoadLocations()
        {
            _logger.LogInformation("Issuing action to load Locations...");
            _dispacher.Dispatch(new LoadLocationsAction());
        }

        public void LoadPartNums(string locationCode, string partnum)
        {
            _logger.LogInformation("Issuing action to load Locations...");
            _dispacher.Dispatch(new LoadPartNumsAction(locationCode, partnum));
        }
    }
 }
