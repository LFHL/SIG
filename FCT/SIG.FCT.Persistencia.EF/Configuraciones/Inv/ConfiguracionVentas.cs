using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Inv
{
    public class ConfiguracionVentas : IEntityTypeConfiguration<Ventas>
    {
        public void Configure( EntityTypeBuilder<Ventas> builder )
        {
            builder.ToTable("INV_Ventas");

            builder.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.TipoCambio).HasDefaultValueSql("((1))");

            builder.HasOne(d => d.IdClienteNavigation)
                .WithMany(p => p.InvVentas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_Ventas_INV_Clientes");

            builder.HasOne(d => d.IdMonedaNavigation)
                .WithMany(p => p.InvVentas)
                .HasForeignKey(d => d.IdMoneda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_Ventas_PAR_Generales1");
        }
    }
}
