using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.Persistencia.EF.Configuraciones
{
    public class ConfiguracionOrden : IEntityTypeConfiguration<Orden>
    {
        public void Configure( EntityTypeBuilder<Orden> builder )
        {

            builder.Property(x => x.FechaOrden)
                .IsRequired();
        }
    }

}

