using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using BOMTool.V.Store.Features.PartNums.Actions;
using BOMTool.M.DTOs;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace BOMTool.V.Store.Features.PartNums.Effects
{
    public class PartNumEffect : Effect<LoadPartNumsAction>
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<PartNumEffect> _logger;
        public List<PartNumbDto> ResponseData; 

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
                var isexport = action.Export;

                PartNumbDto partnums = action.PartNumbs;
                string PNDto = JsonConvert.SerializeObject(partnums);

                if (isexport)
                {
                    ResponseData = await client.GetFromJsonAsync<List<PartNumbDto>>("/v1/PartNum/Export?PNDto=" + PNDto);
                }
                else
                {                  
                     ResponseData = await client.GetFromJsonAsync<List<PartNumbDto>>("/v1/PartNum/?PNDto=" + PNDto);                                     
                }

                _logger.LogInformation("Locations loaded successfully!");
                dispatcher.Dispatch(new LoadPartNumsSuccessAction(ResponseData));
            }
            catch (AccessTokenNotAvailableException ex)
            {
                ex.Redirect();
            }
            catch (Exception e)
            {
                _logger.LogError($"Error loading PartNumbers, reason: {e.Message}");
                dispatcher.Dispatch(new LoadPartNumsFailureAction(e.Message));
            }
        }
               
    }
}
