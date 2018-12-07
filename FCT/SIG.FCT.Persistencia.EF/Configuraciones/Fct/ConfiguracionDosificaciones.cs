using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Fct
{
    public class ConfiguracionDosificaciones : IEntityTypeConfiguration<Dosificaciones>
    {
        public void Configure( EntityTypeBuilder<Dosificaciones> builder )
        {

            builder.HasKey(e => e.NroAutorizacion);

            builder.ToTable("FCT_Dosificaciones");

            builder.Property(e => e.NroAutorizacion).HasColumnType("numeric(15, 0)");

            builder.Property(e => e.FechaInicio).HasColumnType("date");

            builder.Property(e => e.FechaLimiteEmision).HasColumnType("date");

            builder.Property(e => e.LeyendaAsignada)
                .HasMaxLength(300)
                .IsUnicode(false);

            builder.Property(e => e.Llave).HasMaxLength(128);

            builder.Property(e => e.NroTramite).HasMaxLength(12);

            builder.HasOne(d => d.IdAsignacionNavigation)
                .WithMany(p => p.FctDosificaciones)
                .HasForeignKey(d => d.IdAsignacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FCT_Dosificaciones_FCT_AsignacionesSistema");
        }

    }
}
