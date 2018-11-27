using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using SIG.CORE.Seguridad.Entidades;

namespace SIG.CORE.Persistencia.EF.Configuraciones.Seguridad
{
    internal class ConfiguracionUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure( EntityTypeBuilder<Usuario> builder )
        {
            builder.ToTable("SEG_Usuarios");
            builder
                .Property(p => p.Id)
                .UseSqlServerIdentityColumn();
            builder
                .Property(x => x.UserName)
                .HasColumnName("NombreUsuario")
                .HasMaxLength(30)
                .IsRequired();
            builder
                .Property(x => x.NormalizedUserName)
                .HasColumnName("NombreUsuarioNormalizado")
                .HasMaxLength(30);
            builder
                .Property(x => x.Email)
                .HasColumnName("Correo")
                .HasMaxLength(80)
                .IsRequired();
            builder
                .Property(x => x.NormalizedEmail)
                .HasColumnName("CorreoNormalizado")
                .HasMaxLength(80);
        }
    }

}
