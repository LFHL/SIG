using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Par;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Par
{
    public class ConfiguracionTiposObjeto : IEntityTypeConfiguration<TiposObjeto>
    {
        public void Configure( EntityTypeBuilder<TiposObjeto> builder )
        {
            builder.ToTable("PAR_TiposObjeto");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(12);

            builder.Property(e => e.TablaAsociada)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
