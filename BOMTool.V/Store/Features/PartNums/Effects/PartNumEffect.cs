using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using BOMTool.V.Store.Features.PartNums.Actions;
using BOMTool.M;
using System.Collections.Generic;

namespace BOMTool.V.Store.Features.PartNums.Effects
{
    public class PartNumEffect : Effect<LoadPartNumsAction>
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<PartNumEffect> _logger;

        public PartNumEffect(ILogger<PartNumEffect> logger, IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            _logger = logger;
        }

        protected override async Task HandleAsync(LoadPartNumsAction action, IDispatcher dispatcher)
        {
            try
            {
                _logger.LogInformation("Loading Locations...");
                var client = _clientFactory.CreateClient("ServerAPI");
                var ResponseData = await client.GetFromJsonAsync<IEnumerable<PartNumbDto>>("PartNumbDto");

                _logger.LogInformation("Locations loaded successfully!");
                dispatcher.Dispatch(new LoadPartNumsSuccessAction(ResponseData));
            }
            catch (AccessTokenNotAvailableException ex)
            {
                ex.Redirect();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error loading Locations, reason: {e.Message}");
                dispatcher.Dispatch(new LoadPartNumsFailureAction(e.Message));
            }
        }
    }
}
