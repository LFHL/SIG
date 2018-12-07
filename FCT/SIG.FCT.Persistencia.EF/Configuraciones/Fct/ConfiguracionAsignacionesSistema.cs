using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Fct
{
    public class ConfiguracionAsignacionesSistema : IEntityTypeConfiguration<AsignacionesSistema>
    {
        public void Configure( EntityTypeBuilder<AsignacionesSistema> builder )
        {

            builder.ToTable("FCT_AsignacionesSistema");

            builder.Property(e => e.Habilitado).HasDefaultValueSql("((1))");

            builder.Property(e => e.Sfc).HasColumnName("SFC");

            builder.HasOne(d => d.IdActividadEconomicaNavigation)
                .WithMany(p => p.AsignacionesSistema)
                .HasForeignKey(d => d.IdActividadEconomica)
                .HasConstraintName("FK_FCT_AsignacionesSistema_FCT_ActividadesEconomicas");

            builder.HasOne(d => d.IdTipoEmisorNavigation)
                .WithMany(p => p.FctAsignacionesSistema)
                .HasForeignKey(d => d.IdTipoEmisor)
                .HasConstraintName("FK_FCT_AsignacionesSistema_FCT_Parametros");

            builder.HasOne(d => d.NroSucursalNavigation)
                .WithMany(p => p.FctAsignacionesSistema)
                .HasForeignKey(d => d.NroSucursal)
                .HasConstraintName("FK_FCT_AsignacionesSistema_FCT_Sucursales");

            builder.HasOne(d => d.SfcNavigation)
                .WithMany(p => p.FctAsignacionesSistema)
                .HasForeignKey(d => d.Sfc)
                .HasConstraintName("FK_FCT_AsignacionesSistema_FCT_SistemasFacturacion");
        }

    }
}
