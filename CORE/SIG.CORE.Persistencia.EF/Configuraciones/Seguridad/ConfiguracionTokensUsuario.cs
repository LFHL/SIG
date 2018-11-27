using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SIG.CORE.Persistencia.EF.Configuraciones.Seguridad
{
    internal class ConfiguracionTokensUsuario : IEntityTypeConfiguration<IdentityUserToken<int>>
    {
        public void Configure( EntityTypeBuilder<IdentityUserToken<int>> builder )
        {
            builder.ToTable("SEG_TokensUsuario");
            builder
                .Property(x => x.UserId)
                .HasColumnName("IdUsuario");
            builder
                .Property(x => x.Name)
                .HasColumnName("Nombre");
            builder
                .Property(x => x.Value)
                .HasColumnName("Valor");

        }
    }

}
