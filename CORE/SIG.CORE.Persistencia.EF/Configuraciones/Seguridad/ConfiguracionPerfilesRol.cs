using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SIG.CORE.Persistencia.EF.Configuraciones.Seguridad
{
    internal class ConfiguracionPerfilesRol : IEntityTypeConfiguration<IdentityRoleClaim<int>>
    {
        public void Configure( EntityTypeBuilder<IdentityRoleClaim<int>> builder )
        {
            builder.ToTable("SEG_PerfilesRol");
            builder
                .Property(p => p.Id)
                .UseSqlServerIdentityColumn();
            builder
                .Property(x => x.RoleId)
                .HasColumnName("IdRol");
            builder
                .Property(x => x.ClaimType)
                .HasColumnName("Tipo");
            builder
                .Property(x => x.ClaimValue)
                .HasColumnName("Valor");
        }
    }

}
