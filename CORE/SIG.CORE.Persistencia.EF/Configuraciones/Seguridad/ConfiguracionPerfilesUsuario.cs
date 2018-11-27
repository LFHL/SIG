using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SIG.CORE.Persistencia.EF.Configuraciones.Seguridad
{
    internal class ConfiguracionPerfilesUsuario : IEntityTypeConfiguration<IdentityUserClaim<int>>
    {
        public void Configure( EntityTypeBuilder<IdentityUserClaim<int>> builder )
        {
            builder.ToTable("SEG_PerfilesUsuario");
            builder
                .Property(p => p.Id)
                .UseSqlServerIdentityColumn();
            builder
                .Property(x => x.UserId)
                .HasColumnName("IdUsuario");
            builder
                .Property(x => x.ClaimType)
                .HasColumnName("Tipo");
            builder
                .Property(x => x.ClaimValue)
                .HasColumnName("Valor");

        }
    }

}
