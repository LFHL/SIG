using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SIG.CORE.Persistencia.EF.Modelo;
using SIG.CORE.Seguridad.Entidades;

[assembly: HostingStartup(typeof(SIG.CORE.IU.Seguridad.Areas.Identity.IdentityHostingStartup))]
namespace SIG.CORE.IU.Seguridad.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}