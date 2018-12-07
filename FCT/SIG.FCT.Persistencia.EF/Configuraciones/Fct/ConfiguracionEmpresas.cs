using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Fct;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Fct
{
    public class ConfiguracionEmpresas : IEntityTypeConfiguration<Empresas>
    {
        public void Configure( EntityTypeBuilder<Empresas> builder )
        {

            builder.ToTable("FCT_Empresas");

            builder.HasKey(e => e.Nit);

            builder.Property(e => e.Nit).HasColumnType("numeric(12, 0)");
        }

    }
}
