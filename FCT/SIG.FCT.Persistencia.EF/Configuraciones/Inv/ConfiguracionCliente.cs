using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Inv
{
    public class ConfiguracionCliente : IEntityTypeConfiguration<Clientes>
    {
        public void Configure( EntityTypeBuilder<Clientes> builder )
        {
            builder.ToTable("INV_Clientes");

            builder.Property(e => e.IdObjeto).HasColumnType("numeric(12, 0)");

            builder.Property(e => e.Nit).HasColumnType("numeric(12, 0)");

            builder.Property(e => e.RazonSocial)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(d => d.IdTipoObjetoNavigation)
                .WithMany(p => p.InvClientes)
                .HasForeignKey(d => d.IdTipoObjeto)
                .HasConstraintName("FK_INV_Clientes_PAR_TiposObjeto");
        }
    }
}
