using Fluxor;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BOMTool.V.Store.Features.Locations.Actions;

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
    }


}
