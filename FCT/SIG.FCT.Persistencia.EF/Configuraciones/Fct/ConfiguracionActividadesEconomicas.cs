using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Fct
{
    public class ConfiguracionActividadesEconomicas : IEntityTypeConfiguration<ActividadesEconomicas>
    {
        public void Configure( EntityTypeBuilder<ActividadesEconomicas> builder )
        {
            builder.ToTable("FCT_ActividadesEconomicas");

            builder.Property(e => e.Habilitada)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Principal)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        }
    }
}
