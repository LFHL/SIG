using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.Persistencia.EF.Configuraciones
{
    public class ConfiguracionCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure( EntityTypeBuilder<Cliente> builder )
        {
            builder.Property(e => e.Nombres)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(e => e.Apellidos)
                .IsRequired()
                .HasMaxLength(30);
        }
    }
}
