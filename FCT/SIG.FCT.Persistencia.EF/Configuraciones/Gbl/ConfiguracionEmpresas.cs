using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Gbl;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Gbl
{
    public class ConfiguracionEmpresas : IEntityTypeConfiguration<Empresas>
    {
        public void Configure( EntityTypeBuilder<Empresas> builder )
        {
            builder.HasKey(e => e.Nit);

            builder.ToTable("GBL_Empresas");

            builder.Property(e => e.Nit).HasColumnType("numeric(12, 0)");

            builder.Property(e => e.MatriculaComercio).HasColumnType("numeric(8, 0)");

            builder.Property(e => e.RazonSocial).HasMaxLength(100);

            builder.HasOne(d => d.IdDireccionNavigation)
                .WithMany(p => p.GblEmpresas)
                .HasForeignKey(d => d.IdDireccion)
                .HasConstraintName("FK_GBL_Empresa_GBL_Direcciones");

            builder.HasOne(d => d.IdLogoNavigation)
                .WithMany(p => p.GblEmpresas)
                .HasForeignKey(d => d.IdLogo)
                .HasConstraintName("FK_GBL_Empresa_GBL_Imagenes");

            builder.HasOne(d => d.IdSitioWebNavigation)
                .WithMany(p => p.EmpresasIdSitioWebNavigation)
                .HasForeignKey(d => d.IdSitioWeb)
                .HasConstraintName("FK_GBL_Empresa_GBL_DatosContacto");

            builder.HasOne(d => d.IdTelefonoPrincipalNavigation)
                .WithMany(p => p.EmpresasIdTelefonoPrincipalNavigation)
                .HasForeignKey(d => d.IdTelefonoPrincipal)
                .HasConstraintName("FK_GBL_Empresa_GBL_DatosContacto1");
        }
    }
}
