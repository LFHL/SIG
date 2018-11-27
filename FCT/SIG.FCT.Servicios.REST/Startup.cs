using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SIG.FCT.CORE.Aplicacion.Contratos.Repositorio;
using SIG.FCT.CORE.Aplicacion.Contratos.Servicios;
using SIG.FCT.CORE.Aplicacion.Servicios;
using Swashbuckle.AspNetCore.Swagger;
using RepositorioEnMemoria = SIG.FCT.Persistencia.EF.Base;

namespace SIG.FCT.Servicios.REST
{
    public class Startup
    {
        public Startup( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            services.AddScoped<IUnidadDeTrabajo, RepositorioEnMemoria.UnidadDeTrabajo>();

            services.AddScoped<IServicioCliente, ServicioCliente>();
            services.AddScoped<IServicioOrden, ServicioOrden>();

            //services.addin

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "FCT API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, IHostingEnvironment env )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
