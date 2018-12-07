using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Fct
{
    public class ConfiguracionFacturas : IEntityTypeConfiguration<Facturas>
    {
        public void Configure( EntityTypeBuilder<Facturas> builder )
        {

            builder.HasKey(e => e.IdVenta);

            builder.ToTable("FCT_Facturas");

            builder.Property(e => e.IdVenta).ValueGeneratedNever();

            builder.Property(e => e.CodigoDeControl)
                .IsRequired()
                .HasMaxLength(18);

            builder.Property(e => e.CodigoQr)
                .HasColumnName("CodigoQR")
                .HasColumnType("image");

            builder.Property(e => e.FechaEmision)
                .HasColumnType("date")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.MontoTotal).HasColumnType("numeric(18, 2)");

            builder.Property(e => e.NitCliente).HasColumnType("numeric(12, 0)");

            builder.Property(e => e.NroAutorizacion).HasColumnType("numeric(15, 0)");

            builder.Property(e => e.Numero)
                .HasColumnType("numeric(10, 0)")
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.RazonSocial)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(d => d.IdVentaNavigation)
                .WithOne(p => p.FctFacturas)
                .HasForeignKey<Facturas>(d => d.IdVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FCT_Facturas_INV_Ventas");

            builder.HasOne(d => d.NroAutorizacionNavigation)
                .WithMany(p => p.FctFacturas)
                .HasForeignKey(d => d.NroAutorizacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FCT_Facturas_FCT_Dosificaciones");
        }

    }
}
