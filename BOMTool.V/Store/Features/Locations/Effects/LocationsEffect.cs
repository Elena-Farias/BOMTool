using Fluxor;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using BOMTool.M;
using BOMTool.V.Store.Features.Locations.Actions.LoadLocations;
using BOMTool.V.Store.Features.Locations.Actions.SaveLocation;

namespace BOMTool.V.Store.Features.Locations.Effects
{
    //public class LocationsEffect : Effect<LoadLocationsAction>
    public class LocationsEffect 
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<LocationsEffect> _logger;
        public IEnumerable<Location> Locations;
        public HttpResponseMessage response; 

        public LocationsEffect(ILogger<LocationsEffect>logger, IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _logger = logger;
        }

        [EffectMethod]
        public async Task HandleLoadLocationAction(LoadLocationsAction action, IDispatcher dispatcher)
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

        [EffectMethod]
        public  async Task HandleSaveLocationsAction(SaveLocationAction action, IDispatcher dispatcher)
        { 
            try
            {
                _logger.LogInformation("Add Location...");
                var endpoint = "/v1/Location";
                var client = _clientFactory.CreateClient("ServerAPI");

                if (action.IsNew)
                {
                    response = await client.PostAsJsonAsync(endpoint, action.Location);
                }
                else
                {
                    response = await client.PutAsJsonAsync(endpoint, action.Location);
                }

                if (response.IsSuccessStatusCode)
                {
                    var ResponseData = await client.GetFromJsonAsync<IEnumerable<Location>>("Location");

                    _logger.LogInformation("Locations added successfully...");
                    dispatcher.Dispatch(new LoadLocationsSuccessAction(ResponseData));
                }

            }

            catch (Exception e)
            {
                _logger.LogError($"Error loading Location,  (e.Message)");
                dispatcher.Dispatch(new LoadLocationsFailureAction(e.Message));
            }

        }
    }
}
