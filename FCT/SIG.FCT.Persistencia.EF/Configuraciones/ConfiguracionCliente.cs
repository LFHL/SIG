using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades;

namespace SIG.FCT.Persistencia.EF.Configuraciones
{
    public class ConfiguracionCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure( EntityTypeBuilder<Cliente> builder )
        {

            builder
                .Property(x => x.Nombres)
                .HasMaxLength(30)
                .IsRequired();
            builder
                .Property(x => x.Apellidos)
                .HasMaxLength(30)
                .IsRequired();
        }
    }

}
