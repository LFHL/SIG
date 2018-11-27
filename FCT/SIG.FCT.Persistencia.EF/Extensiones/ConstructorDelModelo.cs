using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SIG.FCT.Persistencia.EF.Modelo;

namespace SIG.FCT.Persistencia.EF.Extensiones
{

    public static class ConstructorDelModelo
    {
        public static void ApplyAllConfigurations( this ModelBuilder modelBuilder )
        {
            var applyConfigurationMethodInfo = modelBuilder
                .GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public)
                .First(m => m.Name.Equals("ApplyConfiguration", StringComparison.OrdinalIgnoreCase));

            var ret = typeof(ContextoEnMemoria).Assembly
                .GetTypes()
                .Select(t => (t, i: t.GetInterfaces().FirstOrDefault(i => i.Name.Equals(typeof(IEntityTypeConfiguration<>).Name, StringComparison.Ordinal))))
                .Where(it => it.i != null)
                // TODO: Descomentar cuando usemos DotNet Core 2.2
                //.Select(it => (et: it.i.GetGenericArguments()[0], cfgObj: Activator.CreateInstance(it.t)))
                //.Select(it => applyConfigurationMethodInfo.MakeGenericMethod(it.et).Invoke(modelBuilder, new[] { it.cfgObj }))
                .ToList();
        }
    }
}
