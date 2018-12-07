using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Par;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Par
{
    public class ConfiguracionCategoriasProducto : IEntityTypeConfiguration<CategoriasProducto>
    {
        public void Configure( EntityTypeBuilder<CategoriasProducto> builder )
        {
            builder.ToTable("PAR_CategoriasProducto");

            builder.Property(e => e.Codigo)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
