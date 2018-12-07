using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Fct
{
    public class ConfiguracionReimpresiones : IEntityTypeConfiguration<Reimpresiones>
    {
        public void Configure( EntityTypeBuilder<Reimpresiones> builder )
        {

            builder.ToTable("FCT_Reimpresiones");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Fecha).HasColumnType("datetime");

            builder.HasOne(d => d.IdFacturaNavigation)
                .WithMany(p => p.FctReimpresiones)
                .HasForeignKey(d => d.IdFactura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FCT_Reimpresiones_FCT_Facturas");
        }

    }
}
