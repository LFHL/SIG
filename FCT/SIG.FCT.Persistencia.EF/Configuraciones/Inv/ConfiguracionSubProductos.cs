using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Inv
{
    public class ConfiguracionSubProductos : IEntityTypeConfiguration<SubProductos>
    {
        public void Configure( EntityTypeBuilder<SubProductos> builder )
        {
            builder.HasKey(e => new { e.IdProducto, e.IdSubProducto });

            builder.ToTable("INV_SubProductos");

            builder.HasOne(d => d.IdProductoNavigation)
                .WithMany(p => p.InvSubProductosIdProductoNavigation)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_SubProductos_INV_Productos");

            builder.HasOne(d => d.IdSubProductoNavigation)
                .WithMany(p => p.InvSubProductosIdSubProductoNavigation)
                .HasForeignKey(d => d.IdSubProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_SubProductos_INV_Productos1");
        }
    }
}
