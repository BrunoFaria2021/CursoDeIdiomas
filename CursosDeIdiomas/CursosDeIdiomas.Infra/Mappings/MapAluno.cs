using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursosDeIdiomas.Domain;

namespace CursosDeIdiomas.Infra.Mappings
{
    public class MapAluno : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .HasColumnType("BIGINT");
                

            builder.Property(x => x.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nome")
                    .HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Cpf)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("Cpf")
                    .HasColumnType("VARCHAR(15)");

            builder.Property(x => x.Email)
                    .IsRequired()
                    .HasMaxLength(180)
                    .HasColumnName("email")
                    .HasColumnType("VARCHAR(180)");
        }
    }
}