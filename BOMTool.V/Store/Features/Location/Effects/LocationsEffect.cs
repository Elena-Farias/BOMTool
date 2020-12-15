using Fluxor;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using BOMTool.M;
using BOMTool.V.Store.Features.Locations.Actions;

namespace BOMTool.V.Store.Features.Locations.Effects
{
    public class LocationsEffect : Effect<LoadLocationsAction>
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<LocationsEffect> _logger;

        public LocationsEffect(ILogger<LocationsEffect>logger, IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _logger = logger;
        }

        protected override async Task HandleAsync(LoadLocationsAction action, IDispatcher dispatcher)
        { 
            try
            {
                _logger.LogInformation("Loading Location...");
                var client = _clientFactory.CreateClient("ServerAPI");
                var ResponseData = await client.GetFromJsonAsync<IEnumerable<Location>>("Location");

                _logger.LogInformation("Locations load successfully...");
                dispatcher.Dispatch(new LoadLocationsSuccessAction(ResponseData));
              }
            catch (Exception e)
            {
                _logger.LogError($"Error loading Location,  (e.Message)");
                dispatcher.Dispatch(new LoadLocationsFailureAction(e.Message));
            }
        }
    }
}
