using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SIG.CORE.Persistencia.EF.Configuraciones.Seguridad
{
    internal class ConfiguracionRolesUsuario : IEntityTypeConfiguration<IdentityUserRole<int>>
    {
        public void Configure( EntityTypeBuilder<IdentityUserRole<int>> builder )
        {
            builder.ToTable("SEG_RolesUsuario");

            builder
             .Property(x => x.UserId)
             .HasColumnName("IdUsuario")
             .IsRequired();
            builder
             .Property(x => x.RoleId)
             .HasColumnName("IdRol")
             .IsRequired();
        }
    }
}
