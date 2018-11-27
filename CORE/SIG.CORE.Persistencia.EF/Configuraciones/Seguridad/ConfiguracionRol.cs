using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SIG.CORE.Seguridad.Entidades;

namespace SIG.CORE.Persistencia.EF.Configuraciones.Seguridad
{
    internal class ConfiguracionRol : IEntityTypeConfiguration<Rol>
    {
        public void Configure( EntityTypeBuilder<Rol> builder )
        {

            builder.ToTable("SEG_Roles");
            builder
             .Property(x => x.Name)
             .HasColumnName("Nombre")
             .HasMaxLength(30)
             .IsRequired();
            builder
                .Property(x => x.NormalizedName)
                .HasColumnName("NombreNormalizado")
                .HasMaxLength(30);
        }
    }

}
