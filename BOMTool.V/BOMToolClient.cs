
using BOMTool.M.DTOs;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace BOMTool.V
{
    public class BOMToolClient
    {
        private IHttpClientFactory ClientFactory { get; set; }

        private ILogger<BOMToolClient> _logger;

        public BOMToolClient(
            IHttpClientFactory httpClientFactory,
            ILogger<BOMToolClient> logger)
        {
            ClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<byte[]> GetProgressFileByDTo(PartNumbDto PartNumbs, bool OnlyItem)
        {
            try
            {
                PartNumbDto partnums = PartNumbs;
                string PNDto = JsonConvert.SerializeObject(partnums);

                var client = ClientFactory.CreateClient("ServerAPI");
                var response = await client.GetAsync("/bomtool_api/v1/PartNum/Export?PNDto=" + PNDto + "&OnlyItem=" + OnlyItem);
                response.EnsureSuccessStatusCode();
                var bytes = await response.Content.ReadAsByteArrayAsync();
                return bytes;
            }
            catch (AccessTokenNotAvailableException ex)
            {
                ex.Redirect();
                return null;
            }
        }

    }
}
