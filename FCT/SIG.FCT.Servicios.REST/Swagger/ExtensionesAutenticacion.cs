using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;


namespace SIG.FCT.Servicios.REST.Swagger
{
    public static class ExtensionesAutenticacion
    {
        public static IServiceCollection AddSwaggerDocumentation( this IServiceCollection services )
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0", new Info
                {
                    Title = "API FCT",
                    Version = "v1.0",
                    Description = "Web API de facturación",
                    //TermsOfService = "None",
                    //Contact = new Contact
                    //{
                    //    Name = "Luis Hurtado",
                    //    Email = "lhurtado@outlook.com",
                    //    Url = "https://twitter.com/lhurtado"
                    //},
                    //License = new License
                    //{
                    //    Name = "Use under LICX",
                    //    Url = "https://example.com/license"
                    //}
                });

                var security = new Dictionary<string, IEnumerable<string>> {
                    { "Bearer", Enumerable.Empty<string>() },
                    //{ "Bearer", new string[] { }},
                };

                c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "Please enter JWT with Bearer into field. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });

                c.AddSecurityRequirement(security);

            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation( this IApplicationBuilder app )
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "Versioned API v1.0");
                c.RoutePrefix = string.Empty;
                c.DocumentTitle = "Title Documentation";
                c.DocExpansion(DocExpansion.None);
            });

            return app;
        }

        public static IServiceCollection AddBearerSecurity( this IServiceCollection services, string clave )
        {

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
              .AddJwtBearer(options =>
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = "MyCompany.Com",
                   ValidAudience = "Sistema.SIG",
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(clave)),
                   ClockSkew = TimeSpan.Zero
               });

            return services;
        }


    }
}