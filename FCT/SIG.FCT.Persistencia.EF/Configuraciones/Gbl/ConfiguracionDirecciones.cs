using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Gbl;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Gbl
{
    public class ConfiguracionDirecciones : IEntityTypeConfiguration<Direcciones>
    {
        public void Configure( EntityTypeBuilder<Direcciones> entity )
        {
            entity.ToTable("GBL_Direcciones");

            entity.Property(e => e.Departamento)
                .IsRequired()
                .HasMaxLength(12);

            entity.Property(e => e.Direccion1)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Direccion2).HasMaxLength(100);

            entity.Property(e => e.DireccionDescriptiva).HasMaxLength(250);

            entity.Property(e => e.Lugar).HasMaxLength(50);

            entity.Property(e => e.PosX).HasColumnName("Pos_X");

            entity.Property(e => e.PosY).HasColumnName("Pos_Y");
        }
    }
}
