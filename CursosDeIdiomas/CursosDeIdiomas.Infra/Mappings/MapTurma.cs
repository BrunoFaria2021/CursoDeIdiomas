using CursosDeIdiomas.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursosDeIdiomas.Infra.Mappings
{
    public class MapTurma : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("Turma");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .HasColumnType("BIGINT");


            builder.Property(x => x.Numero)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("numero")
                    .HasColumnType("VARCHAR(5)");

            builder.Property(x => x.AnoLetivo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .HasColumnName("ano_letivo")
                    .HasColumnType("VARCHAR(4)");


        }
    }
}