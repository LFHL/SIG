using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SIG.CORE.Persistencia.EF.Modelo
{
    public class ContextoSeguridadFactory : IDesignTimeDbContextFactory<ContextoSeguridad>
    {
        public ContextoSeguridad CreateDbContext( string[] args )
        {
            var optionsBuilder = new DbContextOptionsBuilder<ContextoSeguridad>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SIG_SecurityDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;MultiSubnetFailover=False");
            return new ContextoSeguridad(optionsBuilder.Options);
        }
    }
}
