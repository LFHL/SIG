using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Inv
{
    public class ConfiguracionDetalleVentas : IEntityTypeConfiguration<DetalleVentas>
    {
        public void Configure( EntityTypeBuilder<DetalleVentas> builder )
        {
            builder.ToTable("INV_DetalleVentas");

            builder.Property(e => e.Comentarios).HasMaxLength(250);

            builder.Property(e => e.MontoTotal)
                .HasColumnType("numeric(35, 2)")
                .HasComputedColumnSql("(([Cantidad]*[PrecioUnitario])*((1)-[PctDescuento]/(100)))");

            builder.Property(e => e.PrecioUnitario).HasColumnType("numeric(18, 2)");

            builder.HasOne(d => d.IdProductoNavigation)
                .WithMany(p => p.InvDetalleVentas)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_DetalleVentas_INV_Productos");

            builder.HasOne(d => d.IdVentaNavigation)
                .WithMany(p => p.InvDetalleVentas)
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("FK_INV_DetalleVentas_INV_Ventas");
        }
    }
}
