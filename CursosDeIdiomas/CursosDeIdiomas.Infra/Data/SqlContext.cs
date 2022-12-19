using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Domain.Entities;
using CursosDeIdiomas.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace CursosDeIdiomas.Infra.Data
{
    public class SqlContext : DbContext
    {

        public SqlContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            builder.ApplyConfiguration(new MapAluno());
            builder.ApplyConfiguration(new MapTurma());
            builder.ApplyConfiguration(new MapMatricula());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=ARES-27\\SQLEXPRESS;Initial Catalog=CursoDeIdiomas;User Id=ARES-27\\bruno;Integrated Security=SSPI;");



        }

        /*  public SqlContext(DbContextOptions<SqlContext> options) : base (options) 
          {
          }*/
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }



    }

}
