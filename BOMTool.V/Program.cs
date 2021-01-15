using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Fluxor;
using System.Reflection;
using BOMTool.V.Helpers;
using BOMTool.V.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Blazored.Toast;

namespace BOMTool.V
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            var currentAssembly = typeof(Program).Assembly;

            builder.Services
          .AddBlazorise(options =>
          {
              options.ChangeTextOnKeyPress = true;
          })
           .AddBootstrapProviders()
           .AddFontAwesomeIcons();

            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient<CustomAuthorizationMessageHandler>();

            builder.Services.AddHttpClient("ServerAPI",
                client =>
                {
                    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ServerAPI"));
                }).AddHttpMessageHandler<CustomAuthorizationMessageHandler>();


            builder.Services.AddFluxor(options =>
            {
                options.ScanAssemblies(Assembly.GetExecutingAssembly());
                options.UseReduxDevTools();
            });

            builder.Services.AddScoped<StateServices>();

            builder.Services.AddOidcAuthentication(options =>
            {
                options.ProviderOptions.Authority = "https://mxjuadev02.rbc.int/";
                options.ProviderOptions.ClientId = "bomtool-spa";
                options.ProviderOptions.ResponseType = "id_token token";
                options.ProviderOptions.DefaultScopes.Add("openid");
                options.ProviderOptions.DefaultScopes.Add("profile");
                options.ProviderOptions.DefaultScopes.Add("roles");
                options.ProviderOptions.DefaultScopes.Add("bomtool.read");
                options.ProviderOptions.DefaultScopes.Add("bomtool.write");
                options.UserOptions.RoleClaim = "role";
            })
                   .AddAccountClaimsPrincipalFactory<ArrayClaimsPrincipalFactory<RemoteUserAccount>>();

            builder.Services.AddAuthorizationCore(builder =>
            {
                builder.AddPolicy("Administrator", p =>
                {
                    p.RequireRole("Administrator");
                });
            });


            //   builder.Services.AddSingleton(new HttpClient
            //  {
            //      BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            //  });

            //// await builder.Build().RunAsync();

            builder.Services.AddBlazoredToast();

            var host = builder.Build();
           
            host.Services
              .UseBootstrapProviders()
              .UseFontAwesomeIcons();

            await host.RunAsync();

        }
    }
}
