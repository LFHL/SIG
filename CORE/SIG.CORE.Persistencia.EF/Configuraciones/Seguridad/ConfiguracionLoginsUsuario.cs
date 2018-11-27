using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SIG.CORE.Persistencia.EF.Configuraciones.Seguridad
{
    internal class ConfiguracionLoginsUsuario : IEntityTypeConfiguration<IdentityUserLogin<int>>
    {
        public void Configure( EntityTypeBuilder<IdentityUserLogin<int>> builder )
        {
            builder.ToTable("SEG_LoginsUsuario");
            builder
                .Property(x => x.ProviderDisplayName)
                .HasColumnName("NombreProveedor");
            builder
                .Property(x => x.UserId)
                .HasColumnName("IdUsuario");
        }
    }

}
