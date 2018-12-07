using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Fct
{
    public class ConfiguracionSistemasFacturacion : IEntityTypeConfiguration<SistemasFacturacion>
    {
        public void Configure( EntityTypeBuilder<SistemasFacturacion> builder )
        {

            builder.HasKey(e => e.Sfc);

            builder.ToTable("FCT_SistemasFacturacion");

            builder.Property(e => e.Sfc)
                .HasColumnName("SFC")
                .ValueGeneratedNever();

            builder.Property(e => e.Fabricante).HasMaxLength(250);

            builder.Property(e => e.Nombre).HasMaxLength(50);
        }

    }
}
