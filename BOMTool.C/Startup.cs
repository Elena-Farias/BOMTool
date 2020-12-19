using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using BOMTool.C.Data;
using Newtonsoft.Json;
using BOMTool.C.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using AutoMapper;
using BOMTool.M.DTOs;
using BOMTool.M; 

namespace BOMTool.C
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(_config =>
            {
                _config.AddDefaultPolicy(b =>
                {
                    b.AllowAnyHeader();
                    b.AllowAnyMethod();
                    b.AllowAnyOrigin();
                });
            });


            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(config =>
        {
            config.Authority = "https://mxjuadev02.rbc.int/";
            config.Audience = "bomtool-api";
            config.RequireHttpsMetadata = false;
        });

         services.AddAuthorization();
         services.AddControllers();

         services.AddHttpContextAccessor();
         services.AddControllers().AddNewtonsoftJson(b =>
            {
                b.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });

            var connecionstring = _config.GetConnectionString("BOMToolConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connecionstring);
            });

            services.AddScoped<IOracleServices, OracleServices>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseCors();

            //app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
