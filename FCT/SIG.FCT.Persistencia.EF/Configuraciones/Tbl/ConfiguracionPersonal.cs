using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIG.FCT.CORE.Entidades.Tbl;

namespace SIG.FCT.Persistencia.EF.Configuraciones.Tbl
{
    public class ConfiguracionPersonal : IEntityTypeConfiguration<Personal>
    {
        public void Configure( EntityTypeBuilder<Personal> builder )
        {
            builder.ToTable("tblPersonal");

            builder.Property(e => e.Id).HasColumnName("ID");

            builder.Property(e => e.EndDate).HasColumnType("date");

            builder.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.StartDate).HasColumnType("date");
        }
    }

}