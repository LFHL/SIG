using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Inv
{
    public class ConfiguracionCompras : IEntityTypeConfiguration<Compras>
    {
        public void Configure( EntityTypeBuilder<Compras> builder )
        {
            builder.ToTable("INV_Compras");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.IdMoneda).HasMaxLength(10);

            builder.Property(e => e.IdProveedor).HasMaxLength(10);

            builder.Property(e => e.TipoCambio).HasDefaultValueSql("((1))");
        }
    }
}
