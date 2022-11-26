using CursosDeIdiomas.Domain;
using Microsoft.EntityFrameworkCore;

namespace CursosDeIdiomas.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Turma> Turmas { get; set; }

    }

}
