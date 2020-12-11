using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOMTool.V.Helpers
{
    public class CustomAuthorizationMessageHandler : AuthorizationMessageHandler
    {
        public CustomAuthorizationMessageHandler(IAccessTokenProvider provider,
            NavigationManager navigation, IConfiguration Configuration) : base(provider, navigation)
        {
            ConfigureHandler(
                authorizedUrls: new[] { Configuration.GetValue<string>("ServerAPI") },
                scopes: new[] { "BOMTool.read", "BOMTool.write" }
            );
        }       
    }
}
