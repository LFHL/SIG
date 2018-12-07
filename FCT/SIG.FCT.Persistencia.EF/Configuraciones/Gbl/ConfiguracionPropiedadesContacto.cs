using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Gbl;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Gbl
{
    public class ConfiguracionPropiedadesContacto : IEntityTypeConfiguration<PropiedadesContacto>
    {
        public void Configure( EntityTypeBuilder<PropiedadesContacto> builder )
        {
            builder.ToTable("GBL_PropiedadesContacto");

            builder.Property(e => e.Valor).IsRequired();

            builder.HasOne(d => d.IdTipoNavigation)
                .WithMany(p => p.GblPropiedadesContacto)
                .HasForeignKey(d => d.IdTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GBL_DatosContacto_PAR_GENERALES");
        }
    }
}
