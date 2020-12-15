using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Configuration;

namespace BOMTool.V.Helpers
{
    public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
            NavigationManager navigation, IConfiguration Configuration) : base(provider, navigation)
        {
            ConfigureHandler(
                authorizedUrls: new[] { Configuration.GetValue<string>("ServerAPI") },
                scopes: new[] { "bomtool.read", "bomtool.write" }
            );
        }       
    }
}
