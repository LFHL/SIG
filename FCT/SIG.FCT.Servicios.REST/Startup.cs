using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SIG.FCT.CORE.Aplicacion.Contratos.Repositorio;
using SIG.FCT.CORE.Aplicacion.Contratos.Servicios;
using SIG.FCT.CORE.Aplicacion.Servicios;

using SIG.FCT.Servicios.REST.Swagger;

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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<IUnidadDeTrabajo, RepositorioEnMemoria.UnidadDeTrabajo>();
            services.AddScoped<IServicioCliente, ServicioCliente>();
            services.AddScoped<IServicioOrden, ServicioOrden>();

            services.AddBearerSecurity(Configuration["Llave_super_secreta"]);
            services.AddSwaggerDocumentation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, IHostingEnvironment env )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();
            app.UseSwaggerDocumentation();
        }
    }
}
