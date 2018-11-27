using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SIG.CORE.Persistencia.EF.Modelo;
using SIG.CORE.Seguridad.Entidades;

using Swashbuckle.AspNetCore.Swagger;

namespace SIG.CORE.Servicios.Seguridad
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
            services.AddDbContext<ContextoSeguridad>(options => options
                .UseSqlServer(Configuration.GetConnectionString("defaultConnection")));

            services.AddIdentity<Usuario, Rol>()
                .AddEntityFrameworkStores<ContextoSeguridad>()
                .AddDefaultTokenProviders();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer();

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(ConfigureJson);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

        }

        private void ConfigureJson( MvcJsonOptions obj )
        {
            obj.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, IHostingEnvironment env )
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
