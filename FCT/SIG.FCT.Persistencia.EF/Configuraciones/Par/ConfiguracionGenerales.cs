using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Par;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Par
{
    public class ConfiguracionGenerales : IEntityTypeConfiguration<Generales>
    {
        public void Configure( EntityTypeBuilder<Generales> builder )
        {
            builder.ToTable("PAR_Generales");

            builder.Property(e => e.Codigo).HasMaxLength(10);

            builder.Property(e => e.Habilitado)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Orden).HasDefaultValueSql("((1))");

            builder.HasOne(d => d.IdTipoNavigation)
                .WithMany(p => p.InverseIdTipoNavigation)
                .HasForeignKey(d => d.IdTipo)
                .HasConstraintName("FK_FCT_Parametros_FCT_Parametros");
        }
    }
}
