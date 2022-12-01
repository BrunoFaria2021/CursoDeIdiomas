using CursosDeIdiomas.Domain;
using CursosDeIdiomas.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection.Emit;

namespace CursosDeIdiomas.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            builder.ApplyConfiguration(new MapAluno());
            builder.ApplyConfiguration(new MapTurma());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=ADMINISTADOR\\SQLEXPRESS;Initial Catalog=CursoDeIdiomas;User Id=ADMINISTADOR\\bruno;Integrated Security=SSPI;");


        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) 
        {
        }
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Turma> Turmas { get; set; }
        


    }

}
