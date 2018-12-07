using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Gbl;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Gbl
{
    public class ConfiguracionPersonas : IEntityTypeConfiguration<Personas>
    {
        public void Configure( EntityTypeBuilder<Personas> builder )
        {
            builder.ToTable("GBL_Personas");

            builder.Property(e => e.FechaNacimiento).HasMaxLength(10);

            builder.Property(e => e.NroDocumento).HasMaxLength(20);

            builder.Property(e => e.PrimerApellido).HasMaxLength(10);

            builder.Property(e => e.PrimerNombre).HasMaxLength(120);

            builder.Property(e => e.SegundoApellido).HasMaxLength(10);

            builder.Property(e => e.SegundoNombre).HasMaxLength(10);

            builder.HasOne(d => d.IdDireccionNavigation)
                .WithMany(p => p.GblPersonas)
                .HasForeignKey(d => d.IdDireccion)
                .HasConstraintName("FK_GBL_Personas_GBL_Direcciones");

            builder.HasOne(d => d.IdTelefonoPrincipalNavigation)
                .WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdTelefonoPrincipal)
                .HasConstraintName("FK_GBL_Personas_GBL_DatosContacto");
        }
    }
}
