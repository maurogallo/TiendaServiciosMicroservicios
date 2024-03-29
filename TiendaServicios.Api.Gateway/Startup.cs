﻿using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using TiendaServicios.Api.Gateway.ImplementRemote;
using TiendaServicios.Api.Gateway.InterfaceRemote;
using TiendaServicios.Api.Gateway.MessageHandler;

namespace TiendaServicios.Api.Gateway
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers();

            

            services.AddHttpClient("AutorService", config =>
            {
                config.BaseAddress = new Uri(Configuration["Services:Autor"]);
            });

            services.AddSingleton<IAutorRemote, AutorRemote>();

            services.AddOcelot().AddDelegatingHandler<LibroHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public  async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

           await app.UseOcelot();
        }
    }
}