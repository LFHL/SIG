using Microsoft.EntityFrameworkCore;
using SIG.FCT.Persistencia.EF.Base;

namespace SIG.FCT.Persistencia.EF.Modelo
{
    public class AppDbContextFactory : DesignTimeDbContextFactoryBase<ContextoFCT>
    {
        protected override ContextoFCT CreateNewInstance( DbContextOptions<ContextoFCT> options )
        {
            return new ContextoFCT(options);
        }
    }
}
