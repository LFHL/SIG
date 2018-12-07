using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Fct
{
    public class ConfiguracionSucursales : IEntityTypeConfiguration<Sucursales>
    {
        public void Configure( EntityTypeBuilder<Sucursales> builder )
        {

            builder.HasKey(e => e.Numero);

            builder.ToTable("FCT_Sucursales");

            builder.Property(e => e.Numero).ValueGeneratedNever();

            builder.Property(e => e.Email).HasMaxLength(10);

            builder.Property(e => e.NombreComercial)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(e => e.Telefonos).HasMaxLength(50);

            builder.HasOne(d => d.IdDireccionNavigation)
                .WithMany(p => p.FctSucursales)
                .HasForeignKey(d => d.IdDireccion)
                .HasConstraintName("FK_FCT_Sucursales_GBL_Direcciones");

            builder.HasOne(d => d.IdLogoNavigation)
                .WithMany(p => p.FctSucursales)
                .HasForeignKey(d => d.IdLogo)
                .HasConstraintName("FK_FCT_Sucursales_GBL_Imagenes");
        }

    }
}
