using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Inv
{
    public class ConfiguracionDetalleCompras : IEntityTypeConfiguration<DetalleCompras>
    {
        public void Configure( EntityTypeBuilder<DetalleCompras> builder )
        {
            builder.ToTable("INV_DetalleCompras");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.CostoUnidad).HasColumnType("numeric(18, 2)");

            builder.Property(e => e.Total)
                .HasColumnType("numeric(24, 2)")
                .HasComputedColumnSql("([Cantidad]*[CostoUnidad])");

            builder.HasOne(d => d.IdCompraNavigation)
                .WithMany(p => p.InvDetalleCompras)
                .HasForeignKey(d => d.IdCompra)
                .HasConstraintName("FK_INV_DetalleCompras_INV_Compras");

            builder.HasOne(d => d.IdProductoNavigation)
                .WithMany(p => p.InvDetalleCompras)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_DetalleCompras_INV_Productos");
        }
    }
}
