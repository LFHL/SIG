using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Gbl;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Gbl
{
    public class ConfiguracionImagenes : IEntityTypeConfiguration<Imagenes>
    {
        public void Configure( EntityTypeBuilder<Imagenes> builder )
        {
            builder.ToTable("GBL_Imagenes");

            builder.Property(e => e.Imagen)
                .IsRequired()
                .HasColumnType("image");

            builder.Property(e => e.Nombre).HasMaxLength(50);
        }
    }
}
