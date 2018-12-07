using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Inv;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Inv
{
    public class ConfiguracionProductos : IEntityTypeConfiguration<Productos>
    {
        public void Configure( EntityTypeBuilder<Productos> builder )
        {
            builder.ToTable("INV_Productos");

            builder.Property(e => e.Codigo).HasMaxLength(10);

            builder.Property(e => e.EsParaVenta)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Precio).HasColumnType("numeric(18, 2)");

            builder.HasOne(d => d.IdCategoriaNavigation)
                .WithMany(p => p.InvProductos)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_Productos_PAR_CategoriasProducto");
        }
    }
}
