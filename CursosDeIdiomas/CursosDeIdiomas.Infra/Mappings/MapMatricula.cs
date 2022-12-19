using CursosDeIdiomas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursosDeIdiomas.Infra.Mappings
{
    public class MapMatricula : MapBase<Matricula>
    {
       public MapMatricula() : base("Matriculas")
        { }
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            base.Configure(builder); 

            builder.HasKey(m => new { m.TurmaId, m.AlunoId });
            builder.Property(m => m.TurmaId)
                        .HasColumnName("TurmaId")
                        .IsRequired();
            builder.Property(m => m.AlunoId)
                        .HasColumnName("AlunoId")
                        .IsRequired();
            builder.HasOne(a => a.Turma)
                        .WithMany()
                        .HasForeignKey(t => t.TurmaId);
            builder.HasOne(t => t.Aluno)
                        .WithMany()
                        .HasForeignKey(a => a.AlunoId);
        }
    }
}
